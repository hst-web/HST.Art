using HST.Art.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HST.Art.Service;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class AcademicianController:ApplicationBase
    {
        MemberUnitService AcadeService = new MemberUnitService();
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

            List<MemberUnit> acadeList =AcadeService.GetPage(fillter,out totalNum);
            ReturnPageResultIList<MemberUnit> data = new ReturnPageResultIList<Core.MemberUnit>(acadeList, totalNum);
            IList<AcadeViewModel> gmList = new List<AcadeViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new AcadeViewModel() {
                    Id = g.Id, HeadImg = g.HeadImg,
                    AcadeNumber = g.Number,
                    AcadeName = g.Name,
                    AcadeStar = (int)g.Star,
                    Province = Convert.ToInt32(g.Province),
                    City = Convert.ToInt32(g.City),
                    Area = GetAreaStr(g.Province, g.City),
                    State = (int)g.State,
                    CategoryName = g.CategoryName,
                    Category =g.Category
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