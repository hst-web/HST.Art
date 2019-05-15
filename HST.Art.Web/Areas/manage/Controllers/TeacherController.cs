using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using HST.Utillity;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class TeacherController : ApplicationBase
    {
        TeaCertificateService teaService = new TeaCertificateService();

        public ActionResult List()
        {
            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;

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

            List<TeaCertificate> userList = teaService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<TeaCertificate> data = new ReturnPageResultIList<Core.TeaCertificate>(userList, totalNum);
            IList<TeaViewModel> gmList = new List<TeaViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new TeaViewModel() { Id = g.Id, UserId = g.UserId, TeacherName = g.Name, Number = g.Number, Gender = g.Gender, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Category = g.Category, Level = g.Level, Province = Convert.ToInt32(g.Province), City = Convert.ToInt32(g.City), UserName = g.UserName, Area = GetAreaStr(g.Province, g.City) }).ToList();

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
            TeaCertificate data = teaService.Get(id);
            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;

            if (data != null)
                return View(new TeaViewModel
                {
                    Id = data.Id,
                    TeacherName = data.Name,
                    Number = data.Number,
                    City = string.IsNullOrEmpty(data.City) ? 0 : Convert.ToInt32(data.City),
                    Province = string.IsNullOrEmpty(data.Province) ? 0 : Convert.ToInt32(data.Province),
                    State = (int)data.State,
                    Category = data.Category,
                    Level = data.Level,
                    Gender = data.Gender,
                    HeadImg = data.HeadImg
                });
            else
                return View();
        }

        [HttpPost]
        public JsonResult Edit(TeaViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                TeaCertificate data = teaService.Get(model.Id);
                data.Number = model.Number;
                data.Name = model.TeacherName;
                data.Level = model.Level;
                data.Category = model.Category;
                data.State = (PublishState)model.State;
                data.Gender = model.Gender;
                data.City = model.City.ToString();
                data.Province = model.Province < 1 ? Constant.DEFAULT_PROVINCE : model.Province.ToString();
                data.HeadImg = model.HeadImg;

                rmodel.isSuccess = teaService.Update(data);
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
            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;
            return View();
        }
        [HttpPost]
        public JsonResult Add(TeaViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                TeaCertificate teaModel = new TeaCertificate()
                {
                    Number = model.Number,
                    Name = model.TeacherName,
                    Level = model.Level,
                    Category = model.Category,
                    State = (PublishState)model.State,
                    Gender = model.Gender,
                    City = model.City.ToString(),
                    Province = model.Province.ToString(),
                    UserId = GetAccount().Id,
                    HeadImg = model.HeadImg
                };
                rmodel.isSuccess = teaService.Add(teaModel);
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
                rmodel.isSuccess = teaService.LogicDelete(id);
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
                rmodel.isSuccess = teaService.Publish(id);
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
                rmodel.isSuccess = teaService.Recovery(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }
        #endregion

        [HttpGet]
        public JsonResult CheckTeaNumber(int id, string number)
        {
            ResultRetrun rmodel = new ResultRetrun();
            FilterEntityModel filterModel = new FilterEntityModel();
            filterModel.keyValueList = new List<KeyValueObj>();
            filterModel.keyValueList.Add(new KeyValueObj() { Key = "number", Value = number, FieldType = FieldType.String });

            List<TeaCertificate> userList = teaService.GetAll(filterModel);
            if (userList != null && userList.Count > 0)
            {
                if (userList.Where(g => !g.Id.Equals(id)).Count() > 0)
                    rmodel.message = "证书编号已经存在";
                else
                    rmodel.isSuccess = true;
            }
            else
                rmodel.isSuccess = true;
            return Json(rmodel.isSuccess, JsonRequestBehavior.AllowGet);
        }

        private string GetAreaStr(string province, string city)
        {
            string proStr = Province.Where(g => g.Key == Convert.ToInt32(province)).FirstOrDefault().Value;
            string cityStr = City.Where(g => g.Key == Convert.ToInt32(city)).FirstOrDefault().Value;

            return proStr + "-" + cityStr;

        }
    }
}