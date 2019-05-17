using HST.Art.Core;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using HST.Utillity;
using HST.Art.Service;
using System.Collections.Generic;

namespace HST.Art.Web
{
    public class ApplicationBase : Controller
    {
        private Dictionary<int, string> _cityDic;
        private Dictionary<int, string> _provinceDic;
        private const int MAX_COOKIESTIME = 4;//最大cookies储存时间
        public string ErrorMsg = string.Empty;
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            SetCurrentCookies = filterContext.RequestContext.HttpContext.Request.Cookies;
            string cookieStr = GetCookieStr();
            if (string.IsNullOrEmpty(cookieStr))
            {
                string tmpRouteName = RouteData.GetRequiredString("controller");
                if (!tmpRouteName.Equals("Account", StringComparison.InvariantCultureIgnoreCase))
                {
                    //filterContext.Result = new RedirectResult("/Account/Login");
                    filterContext.Result = new EmptyResult();
                    filterContext.HttpContext.Response.Write("<script>top.location ='/manage/account/login';</script>");
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

        public Dictionary<int, string> City
        {
            get
            {
                Dictionary<int, string> dicCity = JsonConvert.DeserializeObject<Dictionary<int, string>>(Constant.AREA_CITY);
                if (dicCity != null) _cityDic = dicCity;
                return _cityDic;
            }
        }

        public Dictionary<int, string> Province
        {
            get
            {
                Dictionary<int, string> dicProvince = JsonConvert.DeserializeObject<Dictionary<int, string>>(Constant.AREA_PROVINCE);
                if (dicProvince != null) _provinceDic = dicProvince;
                return _provinceDic;
            }
        }

        public bool LoginBase(string username, string pwd)
        {
            AccountService accountService = new AccountService();
            Account model = accountService.GetSingleMember(username, pwd, out ErrorMsg);
            if (model != null)
            {
                HttpCookie cookie = new HttpCookie("accountInfo");
                cookie.Value = Base64Generate(JsonConvert.SerializeObject(model));
                cookie.Expires = DateTime.Now.AddHours(MAX_COOKIESTIME);

                if (Response != null)
                {
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
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
            string cookieStr = CookiesEvent.GetCookies(SetCurrentCookies, "accountInfo");
            if (!string.IsNullOrEmpty(cookieStr))
            {
                Account account = JsonConvert.DeserializeObject<Account>(GetBase64Generate(cookieStr));
                account.UserName = System.Web.HttpUtility.UrlDecode(account.UserName);
                return account;
            }

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
            return Redirect("~/manage/home/index");
        }

        /// <summary>
        /// 清除认证信息
        /// </summary>
        public void RemoveStoredData()
        {
            if (this.HttpContext != null)
            {
                CookiesEvent.ClearCookiesAll(this.HttpContext);
            }
            else
            {
                CookiesEvent.ClearCookies(System.Web.HttpContext.Current, "accountInfo");
            }
            CacheHelper.RemoveAll();
        }

        /// <summary>
        /// 返回认证cookie字符串
        /// </summary>
        /// <returns></returns>
        private string GetCookieStr()
        {

            return CookiesEvent.GetCookies(SetCurrentCookies, "accountInfo");
        }

        /// <summary>
        /// 64位加密方式
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string Base64Generate(string encryptStr)
        {
            return EncryptHelper.Encode(encryptStr + "|" + "ee7018a6AA5b53e50");
        }

        /// <summary>
        /// 获取加密密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string GetBase64Generate(string decryptStr)
        {
            string result = EncryptHelper.Decode(decryptStr);

            if (!string.IsNullOrEmpty(result))
            {
                var tt = result.Split('|');
                if (tt[0] != null && tt[1] == "ee7018a6AA5b53e50")
                    return tt[0] ?? tt[0];
            }
            return string.Empty;
        }

        #region 虚方法

        public virtual JsonResult Delete(int id)
        {
            throw new ArgumentNullException("Calling methods requires overriding base classes");
        }

        public virtual JsonResult Publish(int id)
        {
            throw new ArgumentNullException("Calling methods requires overriding base classes");
        }

        public virtual JsonResult Shelves(int id)
        {
            throw new ArgumentNullException("Calling methods requires overriding base classes");
        }
        #endregion
    }
}