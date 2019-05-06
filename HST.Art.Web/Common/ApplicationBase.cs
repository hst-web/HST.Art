using HST.Art.Core;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace HST.Art.Web
{
    public class ApplicationBase : Controller
    {
        private const int MAX_COOKIESTIME = 4;//最大cookies储存时间
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            SetCurrentCookies = filterContext.RequestContext.HttpContext.Request.Cookies;
            string cookieStr = GetCookieStr();
            if (string.IsNullOrEmpty(cookieStr))
            {
                string tmpRouteName = RouteData.GetRequiredString("controller");
                if (!tmpRouteName.Equals("Account"))
                {
                    //filterContext.Result = new RedirectResult("/Account/Login");
                    filterContext.Result = new EmptyResult();
                    filterContext.HttpContext.Response.Write("<script>top.location ='/Account/Login';</script>");
                    filterContext.HttpContext.Response.End();
                }
            }
        }

        /// <summary>
        /// 防伪cookie
        /// </summary>
        public HttpCookieCollection SetCurrentCookies
        {
            get; set;
        }

        public bool LoginBase(string username, string pwd)
        {
            // ResourceMemberController rm = new ResourceMemberController();
            object model = null; //rm.GetSingleMember(username, pwd);  object->var
            if (model != null)
            {
                //bool isSupAdmin = model.ResRole != null && model.ResRole.RoleType == 1;
                //Account account = new Account() { Id = model.Id.ToString(), UserName = System.Web.HttpUtility.UrlEncode(model.UserName.ToString()), IsAdmin = isSupAdmin };
                //HttpCookie cookie = new HttpCookie("userInfo");
                //cookie.Value = Base64Generate(JsonConvert.SerializeObject(account));
                //cookie.Expires = DateTime.Now.AddHours(MAX_COOKIESTIME);

                if (Response != null)
                {
                   // Response.Cookies.Add(cookie);
                }
                else
                {
                    //System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
                }

                return true;
            }
            return false;
        }


        /// <summary>
        /// 取得用户信息
        /// </summary>
        /// <returns></returns>
        public Account GetAccount()
        {
            //string cookieStr = CookiesEvent.GetCookies(SetCurrentCookies, "userInfo");
            //if (!string.IsNullOrEmpty(cookieStr))
            //{
            //    Account account = JsonMethod.JsonDeserialize<Account>(GetBase64Generate(cookieStr));
            //    account.UserName = System.Web.HttpUtility.UrlDecode(account.UserName);
            //    return account;
            //}

            return null;
        }



        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public ActionResult LogoutBase()
        {
            RemoveStoredData();
            return RedirectLogin();
        }

        /// <summary>
        /// 登录跳转
        /// </summary>
        /// <returns></returns>
        public ActionResult RedirectLogin()
        {
            return Redirect("~/Home/Index");
        }

        /// <summary>
        /// 清除认证信息
        /// </summary>
        public void RemoveStoredData()
        {
            if (this.HttpContext != null)
            {
               // CommonMethod.ClearCookiesAll(this.HttpContext);
            }
            else
            {
                //CommonMethod.ClearCookies(System.Web.HttpContext.Current, "userInfo");
            }
            //CacheHelper.RemoveAllCache();
        }

        /// <summary>
        /// 返回认证cookie字符串
        /// </summary>
        /// <returns></returns>
        private string GetCookieStr()
        {
            return "";//CookiesEvent.GetCookies(SetCurrentCookies, "userInfo");
        }

        /// <summary>
        /// 64位加密方式
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string Base64Generate(string encryptStr)
        {
            return "";// encryption.EncodeBase64(Encoding.ASCII, encryptStr + "|" + "ee7018a6AA5b53e50");
        }

        /// <summary>
        /// 获取加密密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string GetBase64Generate(string decryptStr)
        {
            string result = null;// encryption.DecodeBase64(Encoding.ASCII, decryptStr);

            if (!string.IsNullOrEmpty(result))
            {
                var tt = result.Split('|');
                if (tt[0] != null && tt[1] == "ee7018a6AA5b53e50")
                    return tt[0] ?? tt[0];
            }
            return string.Empty;
        }





    }
}