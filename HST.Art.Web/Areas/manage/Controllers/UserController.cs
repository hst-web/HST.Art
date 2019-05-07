using HST.Art.Core;
using System;
using System.Web.Mvc;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class UserController : ApplicationBase
    {
        // GET: User
        public ActionResult Index()
        {
            Account account = GetAccount();
            //ResourceMember model = new ResourceMemberController().GetModelById(Convert.ToInt16(account.Id));
            return null;// View(model);
        }

        /// <summary>
        /// 修改密码
        /// </summary>                                          
        /// <param name="oldPwd">原密码</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="renewPwd">确认新密码</param>
        /// <returns></returns>
        [HttpPost]
        public string Update(string oldPwd, string newPwd, string renewPwd)
        {
            bool isSuccess = false;
            //var model = new ResourceMemberController().GetModelById(Convert.ToInt16(GetAccount().Id));
            //if (model == null) return "error";
            //string hashPwd = string.Empty;
            //if (model.SaltPassword > 0)
            //    hashPwd = encryption.Md5Hash(oldPwd + model.SaltPassword);
            //else
            //    hashPwd = encryption.Md5Hash(oldPwd);

            //if (!string.Equals(hashPwd, model.Password))
            //{
            //    return "旧密码输入错误";
            //}

            //model.Password = model.SaltPassword > 0 ? encryption.Md5Hash(newPwd + model.SaltPassword) : encryption.Md5Hash(newPwd);
            //isSuccess = new ResourceMemberController().Update(model);

            if (isSuccess)
            {
                RemoveStoredData();
                return "ok";
            }
            return "error";
        }
    }
}