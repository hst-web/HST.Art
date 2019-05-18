using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using HST.Utillity;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class DownloadController : ApplicationBase
    {
        FileDownloadService downService = new FileDownloadService();
        CategoryDictionaryService cdService = new CategoryDictionaryService();

        public ActionResult List()
        {

            //ImagHelper.MakeThumbnail("", "", 1, 1);

            InitData();
            return View();
        }

        [HttpPost]
        public ActionResult GetJsonData(SearchDataTable dt, SearchViewModel svm)
        {
            int totalNum = 0;
            FilterEntityModel fillter = new FilterEntityModel();
            fillter.PageIndex = dt.pageIndex;
            fillter.PageSize = dt.length;
            fillter.keyValueList = new List<KeyValueObj>();
            if (svm != null && !string.IsNullOrEmpty(svm.FilterKey) && !string.IsNullOrEmpty(svm.FilterVal))
            {
                string fkey = string.Empty;
                SearchType ftype = (SearchType)Convert.ToInt16(svm.FilterKey);

                switch (ftype)
                {
                    case SearchType.Title:
                        fkey = "Title";
                        break;
                    case SearchType.Type:
                        fkey = "Category";
                        break;
                    case SearchType.State:
                        fkey = "State";
                        break;
                }

                fillter.keyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<FileDownload> downList = downService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<FileDownload> data = new ReturnPageResultIList<Core.FileDownload>(downList, totalNum);
            IList<DownloadViewModel> gmList = new List<DownloadViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new DownloadViewModel() { Id = g.Id, UserId = g.UserId, FileName = g.Name, CategoryName = g.CategoryName, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Category = g.Category, FileType = g.Type, FileTitle = g.Title, UserName = g.UserName }).ToList();

            return Json(new
            {
                recordsFiltered = data.totalRecords,
                recordsTotal = data.totalPages,
                data = gmList
            }, JsonRequestBehavior.AllowGet);

        }


        #region 更新
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            FileDownload data = downService.Get(id);
            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;

            if (data != null)
                return View(new DownloadViewModel
                {
                    Id = data.Id,
                    FileName = data.Name,
                    FileTitle = data.Title,
                    CategoryName = data.CategoryName,
                    UserName = data.UserName,
                    State = (int)data.State,
                    Category = data.Category,
                    UserId = data.UserId,
                    Description = data.Description,
                    FileImg = data.HeadImg,
                    FileType = data.Type,
                    Src = data.Src
                });
            else
                return View();
        }

        [HttpPost]
        public JsonResult Edit(DownloadViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                FileDownload data = downService.Get(model.Id);
                data.Title = model.FileTitle;
                data.Name = model.FileName;
                data.Description = model.Description;
                data.Category = model.Category;
                data.State = (PublishState)model.State;
                data.HeadImg = model.FileImg;
                data.Src = model.Src;
                data.Type = model.FileType;

                rmodel.isSuccess = downService.Update(data);
            }

            return Json(rmodel);
        }


        #endregion

        #region 新增
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(DownloadViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                FileDownload downModel = new FileDownload()
                {
                    Title = model.FileTitle,
                    Name = model.FileName,
                    Description = model.Description,
                    Category = model.Category,
                    State = (PublishState)model.State,
                    HeadImg = model.FileImg,
                    Src = model.Src,
                    Type = model.FileType,
                    UserId = GetAccount().Id
                };
                rmodel.isSuccess = downService.Add(downModel);
            }

            return Json(rmodel);
        }
        #endregion

        #region 状态操作
        public override JsonResult Delete(int id)
        {
            ResultRetrun rmodel = new ResultRetrun();
            try
            {
                rmodel.isSuccess = downService.LogicDelete(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }

        public override JsonResult Publish(int id)
        {
            ResultRetrun rmodel = new ResultRetrun();
            try
            {
                rmodel.isSuccess = downService.Publish(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }

        public override JsonResult Shelves(int id)
        {
            ResultRetrun rmodel = new ResultRetrun();
            try
            {
                rmodel.isSuccess = downService.Recovery(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }
        #endregion

        private void InitData()
        {
            List<CategoryDictionary> cdAllList = cdService.GetAll(CategoryType.Download);
            List<CategoryDictionary> cdEnabledList = null;
            if (cdAllList != null && cdAllList.Count > 0)
            {
                cdEnabledList = cdAllList.FindAll(g => g.State == PublishState.Upper);
            }

            ViewBag.AllCategory = cdAllList;
            ViewBag.EnabledCategory = cdEnabledList;
        }
    }
}