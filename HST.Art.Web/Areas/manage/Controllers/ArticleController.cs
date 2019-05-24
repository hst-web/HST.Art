using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class ArticleController : ApplicationBase
    {
        ArticleService articleService = new ArticleService();
        CategoryDictionaryService cdService = new CategoryDictionaryService();
        List<CategoryDictionary> cdEnabledList = new List<CategoryDictionary>();
        List<CategoryDictionary> cdAllList = new List<CategoryDictionary>();
        public ActionResult List()
        {
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
                    case SearchType.Name:
                        fkey = "Name";
                        break;
                    case SearchType.Number:
                        fkey = "Number";
                        break;
                    case SearchType.Type:
                        fkey = "Category";
                        break;
                    case SearchType.Area:
                        fkey = "City";
                        break;
                }

                fillter.keyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<Article> downList = articleService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<Article> data = new ReturnPageResultIList<Core.Article>(downList, totalNum);
            IList<ArticleViewModel> gmList = new List<ArticleViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new ArticleViewModel() { Id = g.Id, UserId = g.UserId, Title = g.Title, CategoryName = g.CategoryName, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Category = g.Category, UserName = g.UserName, ParCategory = g.ParCategory, HeadImg = g.HeadImg, SmallHeadImg = GetThumb(g.HeadImg), Section = g.Section, ParCategoryName = g.ParCategoryName }).ToList();

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
            Article data = articleService.Get(id);
            if (data != null)
            {
                ArticleViewModel model = new ArticleViewModel();
                model.Id = data.Id;
                model.Title = data.Title;
                model.CategoryName = data.CategoryName;
                model.UserName = data.UserName;
                model.State = (int)data.State;
                model.UserId = data.UserId;
                model.Description = data.Content;
                model.HeadImg = data.HeadImg;
                model.SmallHeadImg = GetThumb(data.HeadImg);
                model.Section = data.Section;

                if (cdEnabledList != null && cdEnabledList.Count > 0)
                {
                    if (cdEnabledList.Where(g => g.Id == data.Category).Count() > 0)
                        model.Category = data.Category;
                    if (cdEnabledList.Where(g => g.Id == data.ParCategory).Count() > 0)
                        model.ParCategory = data.ParCategory;
                }

                return View(model);
            }

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Edit(ArticleViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                Article data = articleService.Get(model.Id);
                data.Title = model.Title;
                data.Content = !string.IsNullOrEmpty(model.Description) ? model.Description.Replace("\r\n", "") : string.Empty;
                data.Category = model.Category;
                data.State = (PublishState)model.State;
                data.HeadImg = model.HeadImg;
                data.Section = model.Section;
                data.ParCategory = model.ParCategory;
                rmodel.isSuccess = articleService.Update(data);
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
        [ValidateInput(false)]
        public JsonResult Add(ArticleViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                Account account = GetAccount();
                Article downModel = new Article()
                {
                    Title = model.Title,
                    Content = !string.IsNullOrEmpty(model.Description) ? model.Description.Replace("\r\n", "") : string.Empty,
                    Category = model.Category,
                    State = (PublishState)model.State,
                    HeadImg = model.HeadImg,
                    ParCategory = model.ParCategory,
                    UserId = account.Id,
                    Section = model.Section,
                    Author = account.UserName
                };

                rmodel.isSuccess = articleService.Add(downModel);
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
                rmodel.isSuccess = articleService.LogicDelete(id);
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
                rmodel.isSuccess = articleService.Publish(id);
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
                rmodel.isSuccess = articleService.Recovery(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }
        #endregion

        /// <summary>
        /// 通过模块类别获取类别集合
        /// </summary>
        /// <param name="sectionType">模块类别</param>
        /// <param name="searchType">筛选类型（0：所有类别，1：可用类别）</param>
        /// <returns></returns>
        public JsonResult GetCategoryList(SectionType sectionType, int searchType = 0)
        {
            List<KeyValueViewModel> rmodel = new List<KeyValueViewModel>();
            if (sectionType <= 0) return Json(rmodel, JsonRequestBehavior.AllowGet);

            if (cdAllList == null || cdAllList.Count <= 0)
            {
                InitData();
            }

            if (cdAllList != null && cdAllList.Count > 0)
            {
                if (searchType > 0)
                {
                    rmodel = cdEnabledList.FindAll(g => g.Type == (CategoryType)sectionType).Select(g => new KeyValueViewModel() { Key = g.Id, Value = g.Name }).ToList();
                }
                else
                {
                    rmodel = cdAllList.FindAll(g => g.Type == (CategoryType)sectionType).Select(g => new KeyValueViewModel() { Key = g.Id, Value = g.Name }).ToList();
                }
            }

            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 通过父级id获取类别集合
        /// </summary>
        /// <param name="parentId">父级id</param>
        /// <param name="searchType">筛选类型（0：所有类别，1：可用类别）</param>
        /// <returns></returns>
        public JsonResult GetCategoryList(int parentId, int searchType = 0)
        {
            List<KeyValueViewModel> rmodel = new List<KeyValueViewModel>();
            if (parentId <= 0) return Json(rmodel, JsonRequestBehavior.AllowGet);

            if (cdAllList == null || cdAllList.Count <= 0)
            {
                InitData();
            }

            if (cdAllList != null && cdAllList.Count > 0)
            {
                if (searchType > 0)
                {
                    rmodel = cdEnabledList.FindAll(g => g.Parent == parentId).Select(g => new KeyValueViewModel() { Key = g.Id, Value = g.Name }).ToList();
                }
                else
                {
                    rmodel = cdAllList.FindAll(g => g.Parent == parentId).Select(g => new KeyValueViewModel() { Key = g.Id, Value = g.Name }).ToList();
                }
            }

            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Detail(int id)
        {
            Article data = articleService.Get(id);

            if (data != null)
                return View(new ArticleViewModel
                {
                    Id = data.Id,
                    CategoryName = data.CategoryName,
                    UserName = data.UserName,
                    State = (int)data.State,
                    Category = data.Category,
                    UserId = data.UserId,
                    Description = data.Content,
                    HeadImg = data.HeadImg,
                    SmallHeadImg = GetThumb(data.HeadImg)
                });
            else
                return View();
        }

        private void InitData()
        {
            List<CategoryType> categoryList = new List<CategoryType>() {
                 CategoryType.Association,
                 CategoryType.Examination,
                 CategoryType.Industry,
                 CategoryType.Social
            };

            Dictionary<CategoryDictionary, List<CategoryDictionary>> dicCategorys = new Dictionary<CategoryDictionary, List<CategoryDictionary>>();
            cdAllList = cdService.GetAll(categoryList);
            if (cdAllList != null && cdAllList.Count > 0)
            {
                cdEnabledList = cdAllList.FindAll(g => g.State == PublishState.Upper);
                List<CategoryDictionary> examList = cdAllList.FindAll(g => g.Type == CategoryType.Examination);

                if (examList.Count > 0)
                {
                    List<CategoryDictionary> parList = examList.FindAll(g => g.Parent == 0);
                    foreach (CategoryDictionary item in parList)
                    {
                        dicCategorys.Add(item, examList.FindAll(g => g.Parent == item.Id));
                    }
                }
            }

            ViewBag.ExamCategory = dicCategorys;
        }
    }
}