using HST.Art.Service;
using HST.Art.Core;
using HST.Utillity;
using System.Web.Mvc;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class AccountController : ApplicationBase
    {
        UserService uService = new UserService();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (LoginBase(model.Account, model.Password))
            {
                return RedirectLogin();
            }
            else
            {
                ModelState.AddModelError("ErrorMessage", "密码或用户名错误！");
                return View(model);
            }
        }
       
        public ActionResult LoginOut()
        {
            LogoutBase();
            return RedirectLogin();
        }

        public ActionResult Index()
        {
            Account account = GetAccount();
            User userInfo = uService.Get(account.Id);

            AccountViewModel accountModel = new AccountViewModel() {
                Id= userInfo.Id,
                UserName=userInfo.UserName,
                Email=userInfo.Email,
                Phone=userInfo.Telephone,
                RealName=userInfo.Name,
                IsSupAdmin=userInfo.IsAdmin,
                CreateTime=userInfo.CreateDate
            };

            return View(accountModel);
        }

        /// <summary>
        /// 更新账户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public string Update(AccountViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            User userModel = uService.Get(model.Id);
            userModel.Email = model.Email;
            userModel.Telephone = model.Phone;
            userModel.Name = model.RealName;

            bool isSuccess = uService.Update(userModel);
            if (isSuccess)
            {
                return "ok";
            }
            return "error";
        }

        /// <summary>
        /// 修改密码
        /// </summary>                                          
        /// <param name="oldPwd">原密码</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="renewPwd">确认新密码</param>
        /// <returns></returns>
        [HttpPost]
        public string UpdatePwd(string oldPwd, string newPwd, string renewPwd)
        {
            bool isSuccess = false;
            var model = uService.Get(GetAccount().Id);
            if (model == null) return "error";

            if (!string.Equals(EncryptHelper.Encode(oldPwd, model.Salt), model.Password))
            {
                return "旧密码输入错误";
            }

            isSuccess = uService.UpdatePassword(GetAccount().Id, newPwd);

            if (isSuccess)
            {
                RemoveStoredData();
                return "ok";
            }
            return "error";
        }
    }
}
