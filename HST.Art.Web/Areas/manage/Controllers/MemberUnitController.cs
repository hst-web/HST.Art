using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class MemberUnitController : ApplicationBase
    {
        MemberUnitService muService = new MemberUnitService();
        CategoryDictionaryService cdService = new CategoryDictionaryService();
        List<CategoryDictionary> cdEnabledList = new List<CategoryDictionary>();
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
            fillter.KeyValueList = new List<KeyValueObj>();
            if (svm != null && !string.IsNullOrEmpty(svm.FilterKey) && !string.IsNullOrEmpty(svm.FilterVal))
            {
                string fkey = string.Empty;
                SearchType ftype = (SearchType)Convert.ToInt16(svm.FilterKey);

                switch (ftype)
                {
                    case SearchType.Name:
                        fkey = "Name";
                        fillter.FilterType = FilterType.Like;
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

                fillter.KeyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<MemberUnit> downList = muService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<MemberUnit> data = new ReturnPageResultIList<Core.MemberUnit>(downList, totalNum);
            IList<MemberUnitViewModel> gmList = new List<MemberUnitViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new MemberUnitViewModel() { Id = g.Id, UserId = g.UserId, MemberUnitName = g.Name, CategoryName = g.CategoryName, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Category = g.Category, UserName = g.UserName, Number = g.Number, Star = g.Star, HeadImg = g.HeadImg, SmallHeadImg = GetThumb(g.HeadImg), Province = Convert.ToInt32(g.Province), City = Convert.ToInt32(g.City), Area = GetAreaStr(g.Province, g.City) }).ToList();

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
            MemberUnit data = muService.Get(id);
            InitData();
            if (data != null)
            {
                MemberUnitViewModel model = new MemberUnitViewModel();
                model.Id = data.Id;
                model.MemberUnitName = data.Name;
                model.CategoryName = data.CategoryName;
                model.UserName = data.UserName;
                model.State = (int)data.State;
                model.UserId = data.UserId;
                model.Description = data.Description;
                model.HeadImg = data.HeadImg;
                model.SmallHeadImg = GetThumb(data.HeadImg);
                model.Star = data.Star;
                model.City = string.IsNullOrEmpty(data.City) ? 0 : Convert.ToInt32(data.City);
                model.Province = string.IsNullOrEmpty(data.Province) ? 0 : Convert.ToInt32(data.Province);
                model.Number = data.Number;
                model.Category = data.Category;

                #region 类别可用判断  预留
                //if (cdEnabledList != null && cdEnabledList.Count > 0 && cdEnabledList.Where(g => g.Id == data.Category).Count() > 0)
                //{
                //    model.Category = data.Category;
                //}
                #endregion

                return View(model);
            }

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Edit(MemberUnitViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                MemberUnit data = muService.Get(model.Id);
                data.Name = model.MemberUnitName;
                data.Description = !string.IsNullOrEmpty(model.Description) ? model.Description.Replace("\r\n", "") : string.Empty;
                data.Category = model.Category;
                data.State = (PublishState)model.State;
                data.HeadImg = model.HeadImg;
                data.Star = model.Star;
                data.City = model.City.ToString();
                data.Province = model.Province < 1 ? Constant.DEFAULT_PROVINCE : model.Province.ToString();
                data.Number = model.Number;

                rmodel.isSuccess = muService.Update(data);
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
            InitData();
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public JsonResult Add(MemberUnitViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                MemberUnit downModel = new MemberUnit()
                {
                    Name = model.MemberUnitName,
                    Description = !string.IsNullOrEmpty(model.Description) ? model.Description.Replace("\r\n", "") : string.Empty,
                    Category = model.Category,
                    State = (PublishState)model.State,
                    HeadImg = model.HeadImg,
                    Star = model.Star,
                    UserId = GetAccount().Id,
                    Number = model.Number,
                    City = model.City.ToString(),
                    Province = model.Province.ToString()
                };
                rmodel.isSuccess = muService.Add(downModel);
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
                rmodel.isSuccess = muService.LogicDelete(id);
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
                rmodel.isSuccess = muService.Publish(id);
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
                rmodel.isSuccess = muService.Recovery(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }
        #endregion

        public ActionResult Detail(int id)
        {
            MemberUnit data = muService.Get(id);

            if (data != null)
                return View(new MemberUnitViewModel
                {
                    Id = data.Id,
                    MemberUnitName = data.Name,
                    CategoryName = data.CategoryName,
                    UserName = data.UserName,
                    State = (int)data.State,
                    Category = data.Category,
                    UserId = data.UserId,
                    Description = data.Description,
                    HeadImg = data.HeadImg,
                    SmallHeadImg = GetThumb(data.HeadImg),
                    Star = data.Star,
                    City = string.IsNullOrEmpty(data.City) ? 0 : Convert.ToInt32(data.City),
                    Province = string.IsNullOrEmpty(data.Province) ? 0 : Convert.ToInt32(data.Province),
                    Number = data.Number,
                    CreateTime = data.CreateDate.ToString("yyyy-MM-dd HH;MM")
                });
            else
                return View();
        }

        private void InitData()
        {
            List<CategoryDictionary> cdAllList = cdService.GetAll(CategoryType.Member);
            if (cdAllList != null && cdAllList.Count > 0)
            {
                cdEnabledList = cdAllList.FindAll(g => g.State == PublishState.Upper);
            }

            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;
            ViewBag.AllCategory = cdAllList != null ? cdAllList : new List<CategoryDictionary>();
            ViewBag.EnabledCategory = cdEnabledList;
        }

        [HttpGet]
        public JsonResult CheckNumber(int id, string number)
        {
            ResultRetrun rmodel = new ResultRetrun();
            FilterEntityModel filterModel = new FilterEntityModel();
            filterModel.KeyValueList = new List<KeyValueObj>();
            filterModel.KeyValueList.Add(new KeyValueObj() { Key = "number", Value = number, FieldType = FieldType.String });

            List<MemberUnit> muList = muService.GetAll(filterModel);
            if (muList != null && muList.Count > 0)
            {
                if (muList.Where(g => !g.Id.Equals(id)).Count() > 0)
                    rmodel.message = "会员单位编号已经存在";
                else
                    rmodel.isSuccess = true;
            }
            else
                rmodel.isSuccess = true;
            return Json(rmodel.isSuccess, JsonRequestBehavior.AllowGet);
        }
    }
}