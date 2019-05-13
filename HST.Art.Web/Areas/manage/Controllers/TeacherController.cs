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
            Account accouont = GetAccount();
            ViewBag.IsSupAdmin = accouont.IsAdmin;
            ViewBag.TeaCertificateId = accouont.Id;
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
                    case SearchType.State:
                        fkey = "State";
                        break;
                    case SearchType.Number:
                        fkey = "Telephone";
                        break;
                }

                fillter.keyValueList.Add(new KeyValueObj() { Key = fkey, Value = svm.FilterVal });
            }

            List<TeaCertificate> userList = teaService.GetPage(fillter, out totalNum);
            ReturnPageResultIList<TeaCertificate> data = new ReturnPageResultIList<Core.TeaCertificate>(userList, totalNum);
            //IList<TeaCertificateViewModel> gmList = new List<TeaCertificateViewModel>();

            //if (data != null && data.DataT != null)
            //    gmList = data.DataT.Select(g => new TeaCertificateViewModel() { Id = g.Id, RealName = g.Name, TeaCertificateName = g.TeaCertificateName, Phone = g.Telephone, State = (int)g.State, CreateTime = g.CreateDate.ToString("yyyy-MM-dd HH:MM"), Email = g.Email, IsSupAdmin = g.IsAdmin }).ToList();

            return Json(new
            {
                recordsFiltered = data.totalRecords,
                recordsTotal = data.totalPages,
               // data = gmList
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
            Account account = GetAccount();
            ViewBag.IsSupAdmin = account.IsAdmin;
            ViewBag.IsSelf = id == account.Id;

            if (data != null) { return null; }
                //return View(new TeaCertificateViewModel
                //{
                //    Id = data.Id,
                //    TeaCertificateName = data.TeaCertificateName,
                //    Phone = data.Telephone,
                //    Email = data.Email,
                //    State = (int)data.State,
                //    RealName = data.Name,
                //    IsSupAdmin = data.IsAdmin,
                //    Password = Constant.INIT_MARKET_PASSWORD
                //});
            else
                return View();
        }

        [HttpPost]
        public JsonResult Edit(UserViewModel model)
        {
            ResultRetrun rmodel = new ResultRetrun();
            if (ModelState.IsValid)
            {
                TeaCertificate data = teaService.Get(model.Id);
                data.Name = model.RealName;
               // data.Telephone = model.Phone;
               // data.Email = model.Email;
                data.State = (PublishState)model.State;

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
            return View();
        }
        [HttpPost]
        //public JsonResult Add(TeaCertificateViewModel model)
        //{
        //    ResultRetrun rmodel = new ResultRetrun();
        //    if (ModelState.IsValid)
        //    {
        //        TeaCertificate userModel = new TeaCertificate()
        //        {
        //            Email = model.Email,
        //            Name = model.RealName,
        //            Password = model.Password,
        //            Telephone = model.Phone,
        //            State = (PublishState)model.State,
        //            TeaCertificateName = model.TeaCertificateName
        //        };
        //        rmodel.isSuccess = teaService.Add(userModel);
        //    }

        //    return Json(rmodel);
        //}
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
    }
}