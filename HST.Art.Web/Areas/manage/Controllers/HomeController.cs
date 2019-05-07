using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class HomeController : ApplicationBase
    {
        // GET: Home
        public ActionResult Index()
        {
            var tmp = GetAccount();
            ViewBag.UserName = tmp.UserName;
            //ViewBag.IsSuperAdmin = tmp.IsSuperAdmin;
            //List<ResourceMenu> menuList = new List<ResourceMenu>();
            //ResourceMember resMem = new ResourceMemberController().GetModelById(Convert.ToInt16(GetAccount().Id));
            //if (resMem.ResRole != null && resMem.ResRole.RmList != null && resMem.ResRole.RmList.Count > 0)
            //{
            //    foreach (var item in resMem.ResRole.RmList)
            //    {
            //        ResourceMenu menu = new ResourceMenu();
            //        menu.Id = item.Menuid;
            //        menu.Name = item.ResMenu.Name;
            //        menuList.Add(menu);
            //    }
            //}

            // ViewBag.RoleName = resMem.ResRole == null ? "管理员" : resMem.ResRole.RoleName;

            return null;// View(menuList);
        }
        public ActionResult welcome()
        {
            return View();

        }

        /// <summary>
        /// 资料包统计
        /// </summary>
        /// <returns></returns>
        public JsonResult ResPackageStatistics()
        {
            // ResourceStatistics model = new ResourceStatisticsControll().GetResPackgeStatistics();
            // model = model == null ? new ResourceStatistics() : model;
            return null;// Json(model, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 资料统计
        /// </summary>
        /// <returns></returns>
        public JsonResult ResourceStatistics()
        {
            // ResourceStatistics model = new ResourceStatisticsControll().GetResourceStatistics();
            // model = model == null ? new ResourceStatistics() : model;
            return null; //Json(model, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SearchLog(string SearchDate)
        {
            if (string.IsNullOrEmpty(SearchDate)) return Json("", JsonRequestBehavior.AllowGet);
            string fileName = SearchDate.Replace("-", "") + ".txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + "log\\";
            if (!Directory.Exists(path)) return Json("", JsonRequestBehavior.AllowGet);
            FileInfo fi = new FileInfo(path + fileName);
            if (!fi.Exists) return Json("", JsonRequestBehavior.AllowGet);

            LogViewModel model = new LogViewModel();
            model.SearchDate = SearchDate;
            model.FileCount = 1;
            model.DownloadUrl = @"\log\" + fileName;

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FileResult DownloadFile(string SearchDate)
        {
            string fileName = SearchDate.Replace("-", "") + ".txt";
            string downFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\log\" + fileName;
            FileStream fs = new FileStream(downFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            
            return File(fs, "text/plain", Url.Encode(fileName));
        }
    }
}
