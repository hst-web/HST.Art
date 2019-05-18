using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HST.Art.Service;
using HST.Art.Core;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class ArticleController : ApplicationBase
    {
        ArticleService ArticleService = new ArticleService();
        CategoryDictionaryService cdService = new CategoryDictionaryService();

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
                    case SearchType.Type:
                        fkey = "Category";
                        break;
                    case SearchType.Number:
                        fkey = "Number";
                        break;
                    case SearchType.Area:
                        fkey = "City";
                        break;
                }

                fillter.keyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<Article> articleList = ArticleService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<Article> data = new ReturnPageResultIList<Core.Article>(articleList, totalNum);
            IList<ArticleViewModel> gmList = new List<ArticleViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new ArticleViewModel()
                {
                    Id = g.Id,
                    Section =g.Section,
                    Category = g.Category,
                    HeadImg = g.HeadImg,
                    Title = g.Title,
                    CreateDate = g.CreateDate.ToString("yyyy-MM-dd HH:MM"),
                    Author=g.Author,
                    CategoryName=g.CategoryName,
                    State = (int)g.State,
                }).ToList();

            return Json(new
            {
                recordsFiltered = data.totalRecords,
                recordsTotal = data.totalPages,
                data = gmList
            }, JsonRequestBehavior.AllowGet);


        }

        private string GetAreaStr(string province, string city)
        {
            string proStr = Province.Where(g => g.Key == Convert.ToInt32(province)).FirstOrDefault().Value;
            string cityStr = City.Where(g => g.Key == Convert.ToInt32(city)).FirstOrDefault().Value;

            return proStr + "-" + cityStr;

        }

        private void InitData()
        {
            List<CategoryDictionary> cdAllList = cdService.GetAll(CategoryType.Member);
            List<CategoryDictionary> cdEnabledList = null;
            if (cdAllList != null && cdAllList.Count > 0)
            {
                cdEnabledList = cdAllList.FindAll(g => g.State == PublishState.Upper);
            }

            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;
            ViewBag.AllCategory = cdAllList;
            ViewBag.EnabledCategory = cdEnabledList;
        }
    }
}