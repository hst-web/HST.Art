using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using HST.Utillity;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class UserController : ApplicationBase
    {
        UserService uService = new UserService();
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


        #region 验证方法
        [HttpGet]
        public JsonResult CheckUserName(int id, string username)
        {
            return CheckIsExist(id, username, LoginType.UserName);
        }
        [HttpGet]
        public JsonResult CheckPhone(int id, string phone)
        {
            return CheckIsExist(id, phone, LoginType.Telephone);
        }

        [HttpGet]
        public JsonResult CheckEmail(int id, string email)
        {
            return CheckIsExist(id, email, LoginType.Email);
        }

        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="value">名称</param>
        /// <param name="type">id</param>
        /// <returns></returns>
        private JsonResult CheckIsExist(int id, string value, LoginType loginType)
        {
            ResultRetrun rmodel = new ResultRetrun();
            string nameTemp = loginType.GetDescription();
            FilterEntityModel filterModel = new FilterEntityModel();
            filterModel.keyValueList = new List<KeyValueObj>();

            switch (loginType)
            {
                case LoginType.UserName:
                    filterModel.keyValueList.Add(new KeyValueObj() { Key = "UserName", Value = value, FieldType = FieldType.String });
                    break;
                case LoginType.Telephone:
                    filterModel.keyValueList.Add(new KeyValueObj() { Key = "Telephone", Value = value, FieldType = FieldType.String });
                    break;
                case LoginType.Email:
                    filterModel.keyValueList.Add(new KeyValueObj() { Key = "Email", Value = value, FieldType = FieldType.String });
                    break;
            }

            List<User> userList = uService.GetAll(filterModel);
            if (userList != null && userList.Count > 0 && id > 0)
            {
                if (userList.Where(g => !g.Id.Equals(id)).Count() > 0)
                    rmodel.message = nameTemp + "已经存在";
                else
                    rmodel.isSuccess = true;
            }
            else
                rmodel.isSuccess = true;
            return Json(rmodel.isSuccess, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}