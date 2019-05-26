using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using HST.Utillity;
using System.Collections.Generic;
using System.Linq;

namespace HST.Art.Web.Areas.manage.Controllers
{
    public class StudentController : ApplicationBase
    {
        StuCertificateService stuService = new StuCertificateService();

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
            fillter.KeyValueList = new List<KeyValueObj>();
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

                fillter.KeyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<StuCertificate> stuList = stuService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<StuCertificate> data = new ReturnPageResultIList<Core.StuCertificate>(stuList, totalNum);
            IList<StuViewModel> gmList = new List<StuViewModel>();

            if (data != null && data.DataT != null)
                gmList = data.DataT.Select(g => new StuViewModel() { Id = g.Id, UserId = g.UserId, StudentName = g.Name, Number = g.Number, Gender = g.Gender, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Category = g.Category, Province = Convert.ToInt32(g.Province), City = Convert.ToInt32(g.City), UserName = g.UserName, Area = GetAreaStr(g.Province, g.City) }).ToList();

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
            StuCertificate data = stuService.Get(id);
            ViewBag.AreaCity = City;
            ViewBag.AreaProvince = Province;

            if (data != null)
                return View(new StuViewModel
                {
                    Id = data.Id,
                    StudentName = data.Name,
                    Number = data.Number,
                    City = string.IsNullOrEmpty(data.City) ? 0 : Convert.ToInt32(data.City),
                    Province = string.IsNullOrEmpty(data.Province) ? 0 : Convert.ToInt32(data.Province),
                    State = (int)data.State,
                    Category = data.Category,
                    Gender = data.Gender,
                    HeadImg = data.HeadImg
                });
            else
                return View();
        }

        [HttpPost]
        public JsonResult Edit(StuViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                StuCertificate data = stuService.Get(model.Id);
                data.Number = model.Number;
                data.Name = model.StudentName;
                data.Category = model.Category;
                data.State = (PublishState)model.State;
                data.Gender = model.Gender;
                data.City = model.City.ToString();
                data.Province = model.Province < 1 ? Constant.DEFAULT_PROVINCE : model.Province.ToString();
                data.HeadImg = model.HeadImg;

                rmodel.isSuccess = stuService.Update(data);
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
        public JsonResult Add(StuViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                StuCertificate stuModel = new StuCertificate()
                {
                    Number = model.Number,
                    Name = model.StudentName,
                    Category = model.Category,
                    State = (PublishState)model.State,
                    Gender = model.Gender,
                    City = model.City.ToString(),
                    Province = model.Province.ToString(),
                    UserId = GetAccount().Id,
                    HeadImg = model.HeadImg
                };
                rmodel.isSuccess = stuService.Add(stuModel);
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
                rmodel.isSuccess = stuService.LogicDelete(id);
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
                rmodel.isSuccess = stuService.Publish(id);
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
                rmodel.isSuccess = stuService.Recovery(id);
            }
            catch (Exception ex)
            {
                rmodel.message = "操作失败，原因：" + ex.Message;
            }
            return Json(rmodel, JsonRequestBehavior.AllowGet);
        }
        #endregion

        [HttpGet]
        public JsonResult CheckStuNumber(int id, string number)
        {
            ResultRetrun rmodel = new ResultRetrun();
            FilterEntityModel filterModel = new FilterEntityModel();
            filterModel.KeyValueList = new List<KeyValueObj>();
            filterModel.KeyValueList.Add(new KeyValueObj() { Key = "number", Value = number, FieldType = FieldType.String });

            List<StuCertificate> stuList = stuService.GetAll(filterModel);
            if (stuList != null && stuList.Count > 0)
            {
                if (stuList.Where(g => !g.Id.Equals(id)).Count() > 0)
                    rmodel.message = "证书编号已经存在";
                else
                    rmodel.isSuccess = true;
            }
            else
                rmodel.isSuccess = true;
            return Json(rmodel.isSuccess, JsonRequestBehavior.AllowGet);
        }
    }
}