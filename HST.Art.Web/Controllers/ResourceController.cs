using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Configuration;

namespace HST.Art.Web.Controllers
{
    public class ResourceController : ApplicationBase
    {
        // GET: ResPage
        public ActionResult List()
        {
            InitData();
            return View();
        }

        /// <summary>
        /// DataTable读取数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="upgradetime"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetJsonData(SreachDataTable dt, string name, int packgeId, int format, int memberTypeId, int sort)
        {
            //ResourceFilterModel fillter = new ResourceFilterModel()
            //{
            //    Name = name,
            //    PackageId = packgeId,
            //    Format = (ResourceFormat)format,
            //    FilterSort = (FilterSortOrder)sort,
            //    MemberTypeId = memberTypeId,
            //    pageNumber = dt.pageIndex,
            //    pageSize = dt.length
            //};

            //ReturnPageResultIList<Resource> data = new cncbk_resource_application.Controller.ResourceController().GetAllWhere(fillter);
            IList<ResourceViewModel> gmList = new List<ResourceViewModel>();

            //if (data != null && data.DataT != null)
            //    gmList = data.DataT.Select(g => new ResourceViewModel() { Id = g.Id, Title = g.Title, PackageName = g.ResourcePackage.Name, Format = g.Format.HasValue ? (int)g.Format.Value : 0, State = g.State ? 1 : 0, ShowTimeStart = g.ShowTimeStart.HasValue ? g.ShowTimeStart.Value.ToString("yyyy-MM-dd HH:00") : "", ShowTimeEnd = g.ShowTimeEnd.HasValue ? g.ShowTimeEnd.Value.ToString("yyyy-MM-dd HH:00") : "", UpgradeTime = g.UpgradeTime.HasValue ? g.UpgradeTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "", PvSum = g.PvSum.HasValue ? g.PvSum.Value : 0 }).ToList();

            return Json(new
            {
                //recordsFiltered = data.totalRecords,
                //recordsTotal = data.totalPages,
                data = gmList
            }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id <= 0) return null;
            InitData();

            //Resource model = new cncbk_resource_application.Controller.ResourceController().Get(id);
            ResourceViewModel viewModel = new ResourceViewModel()
            {
                //Id = model.Id,
                //Title = model.Title,
                //State = model.State ? 1 : 0,
                //PackageId = model.PackageId,
                //Format = model.Format.HasValue ? model.Format.Value : 0,
                //Description = model.Description,
                //Original = model.Original,
                //ShowTimeStart = model.ShowTimeStart.HasValue ? model.ShowTimeStart.Value.ToString("yyyy-MM-dd HH:00") : "",
                //ShowTimeEnd = model.ShowTimeEnd.HasValue ? model.ShowTimeEnd.Value.ToString("yyyy-MM-dd HH:00") : "",
                //ResFile = model.ResourceFile,
                //MemberTypeIds = model.ResourceResourcePermissions.Select(g => g.MemberTypeId).Distinct().ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public string Edit(ResourceViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Original > 0)
                {
                    //model.ResFile.Size = 0;
                    //model.ResFile.Extension = System.IO.Path.GetExtension(model.ResFile.Url);
                    //model.ResFile.FileName = System.IO.Path.GetFileName(model.ResFile.Url);
                    //model.ResFile.RealName = model.ResFile.FileName;
                    //model.ResFile.ServerId = 0;
                }
                else
                {
                    //FileServer fileServer = new cncbk_resource_application.Controller.ResourceController().GetFileServer();
                    //model.ResFile.ServerId = fileServer.Id;
                }

                System.ComponentModel.NullableConverter nullableDateTime = new System.ComponentModel.NullableConverter(typeof(DateTime?));
                //Resource res = new Resource()
                //{
                //    Id = model.Id,
                //    Title = model.Title,
                //    State = model.State > 0,
                //    PackageId = model.PackageId,
                //    ShowTimeStart = string.IsNullOrEmpty(model.ShowTimeStart) ? null : (DateTime?)nullableDateTime.ConvertFromString(model.ShowTimeStart),
                //    ShowTimeEnd = string.IsNullOrEmpty(model.ShowTimeEnd) ? null : (DateTime?)nullableDateTime.ConvertFromString(model.ShowTimeEnd),
                //    Description = model.Description,
                //    Format = model.Format,
                //    Original = model.Original,
                //    ResourceFile = model.ResFile,
                //    ResourceResourcePermissions = GetResPers(new ResourcePermissionController().GetAll(), model.MemberTypeIds, model.Id)
                //};
                //bool isSucessed = new cncbk_resource_application.Controller.ResourceController().Update(res);

                return "error";
            }

            return "error";
        }

        [HttpGet]
        public ActionResult Add()
        {
            InitData();
            ResourceViewModel model = new ResourceViewModel();
            //FileServer fileServer = new cncbk_resource_application.Controller.ResourceController().GetFileServer();
            //model.ResFile = new ResourceFile() { ServerId = fileServer != null ? fileServer.Id : 0 };
            return View(model);
        }

        [HttpPost]
        public string Add(ResourceViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Original > 0)
                {
                    //model.ResFile.Size = 0;
                    //model.ResFile.Extension = System.IO.Path.GetExtension(model.ResFile.Url);
                    //model.ResFile.FileName = System.IO.Path.GetFileName(model.ResFile.Url);
                    //model.ResFile.RealName = model.ResFile.FileName;
                    //model.ResFile.ServerId = 0;
                }

                System.ComponentModel.NullableConverter nullableDateTime = new System.ComponentModel.NullableConverter(typeof(DateTime?));
                //Resource rpackge = new Resource()
                //{
                //    Description = model.Description,
                //    Format = model.Format,
                //    ResourceFile = model.ResFile,
                //    Original = model.Original,
                //    PackageId = model.PackageId,
                //    ShowTimeStart = string.IsNullOrEmpty(model.ShowTimeStart) ? null : (DateTime?)nullableDateTime.ConvertFromString(model.ShowTimeStart),
                //    ShowTimeEnd = string.IsNullOrEmpty(model.ShowTimeEnd) ? null : (DateTime?)nullableDateTime.ConvertFromString(model.ShowTimeEnd),
                //    Title = model.Title,
                //    State = model.State > 0,
                //    ResourceResourcePermissions = GetResPers(new ResourcePermissionController().GetAll(), model.MemberTypeIds)
                //};
                //bool isSucessed = new cncbk_resource_application.Controller.ResourceController().Add(rpackge);

                //if (isSucessed)
                //{
                //    string ipAddress = GetWebClientIp();
                //    LogHelper.Info(string.Format("用户:{0}(ID_{1}),添加了类型为{2}的资源:\"{3}\",IP地址为:{4}", GetAccount().UserName, GetAccount().Id, model.FormatStr, model.Title, ipAddress));
                //    return "ok";
                //}

                return "error";
            }

            return "error";
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            if (id <= 0) return null;

            //Resource model = new cncbk_resource_application.Controller.ResourceController().Get(id);
            //ResourceViewModel viewModel = new ResourceViewModel()
            //{
            //    Id = model.Id,
            //    Title = model.Title,
            //    State = model.State ? 1 : 0,
            //    PackageId = model.PackageId,
            //    Format = model.Format.HasValue ? model.Format.Value : 0,
            //    Description = model.Description,
            //    Original = model.Original,
            //    DownloadSum = model.DownloadSum.HasValue ? model.DownloadSum.Value : 0,
            //    PvSum = model.PvSum.HasValue ? model.PvSum.Value : 0,
            //    ShowTimeStart = model.ShowTimeStart.HasValue ? model.ShowTimeStart.Value.ToString("yyyy-MM-dd HH:00") : "",
            //    ShowTimeEnd = model.ShowTimeEnd.HasValue ? model.ShowTimeEnd.Value.ToString("yyyy-MM-dd HH:00") : "",
            //    ResFile = model.ResourceFile,
            //    FileId = model.ResourceFile.Id,
            //    FileUrl = model.Original == 0 ? model.ResourceFile.FileServer == null ? "" : model.ResourceFile.FileServer.Url + model.ResourceFile.Url : model.ResourceFile.Url,
            //    PackageName = model.ResourcePackage.Name,
            //    MemberTypeName = GetMemberTypeName(model.ResourceResourcePermissions.Select(g => g.MemberTypeId).Distinct().ToList())
            //};

            return null;// View(viewModel);
        }

        [HttpGet]
        public ActionResult Preview(int id, int format)
        {
            //ResourceFile model = new cncbk_resource_application.Controller.ResourceController().GetResFileById(id);
            //if (model == null) return View();
            //if (model.FileServer != null) model.Url = model.FileServer.Url + model.Url;

            ViewBag.format = format;
            return null;// View(model);
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DownloadFile(int id)
        {
            string files = string.Empty;
            string contentType = string.Empty;
            //ResourceFile model = new cncbk_resource_application.Controller.ResourceController().GetResFileById(id);
            //if (model == null) return null;
            //string locAddr = WebConfigurationManager.AppSettings["FileAddr"].ToString();//上传地址
            //files = locAddr + model.Url;

            //switch (model.Extension.ToLower())
            //{
            //    case ".pdf": contentType = "application/pdf"; break;
            //    case ".ppt": contentType = "application/vnd.ms-powerpoint"; break;
            //    case ".pptx": contentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation"; break;
            //    case ".mp4": contentType = "video/mp4"; break;
            //    case ".doc": contentType = "application/msword"; break;
            //    case ".docx": contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"; break;
            //    case ".mp3": contentType = "audio/mpeg"; break;
            //}

            return null;// File(files, contentType, Url.Encode(model.FileName));
        }

        /// <summary>
        /// 获取客户端ip地址
        /// </summary>
        /// <returns></returns>
        private string GetWebClientIp()
        {
            string userIP = "未获取用户IP";

            try
            {
                if (System.Web.HttpContext.Current == null
            || System.Web.HttpContext.Current.Request == null
            || System.Web.HttpContext.Current.Request.ServerVariables == null)
                    return "";

                string CustomerIP = "";

                //CDN加速后取到的IP   
                CustomerIP = System.Web.HttpContext.Current.Request.Headers["Cdn-Src-Ip"];
                if (!string.IsNullOrEmpty(CustomerIP))
                {
                    return CustomerIP;
                }

                CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];


                if (!String.IsNullOrEmpty(CustomerIP))
                    return CustomerIP;

                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                    if (CustomerIP == null)
                        CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                else
                {
                    CustomerIP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                }

                if (string.Compare(CustomerIP, "unknown", true) == 0)
                    return System.Web.HttpContext.Current.Request.UserHostAddress;
                return CustomerIP;
            }
            catch { }

            return userIP;
        }


        //private List<ResourceResourcePermission> GetResPers(List<ResourcePermission> rpList, List<int> mtList, int resourceId = 0)
        //{
        //    List<ResourceResourcePermission> resPerList = new List<ResourceResourcePermission>();
        //    if (rpList == null || rpList.Count <= 0)
        //        return null;

        //    if (mtList == null || mtList.Count <= 0)
        //        return null;

        //    for (int i = 0; i < rpList.Count; i++)
        //    {
        //        for (int j = 0; j < mtList.Count; j++)
        //        {
        //            ResourceResourcePermission model = new ResourceResourcePermission();
        //            model.PermissionId = rpList[i].Id;
        //            model.MemberTypeId = mtList[j];
        //            model.ResourceId = resourceId;
        //            resPerList.Add(model);
        //        }
        //    }

        //    return resPerList;
        //}


        [HttpPost]
        public string Delete(int id, string name = "")
        {
            //if (id <= 0) return "error";
            //bool isSucessed = new cncbk_resource_application.Controller.ResourceController().Delete(id);
            //if (isSucessed)
            //{
            //    string ipAddress = GetWebClientIp();
            //    LogHelper.Info(string.Format("用户:{0}(ID_{1}),删除了资源:\"{2}(ID_{3})\",IP地址为:{4}", GetAccount().UserName, GetAccount().Id, name, id, ipAddress));
            //    return "ok";
            //}

            return "error";

        }

        private void InitData()
        {
            List<KeyValueViewModel> packges = new List<KeyValueViewModel>();
            List<KeyValueViewModel> memberTypes = new List<KeyValueViewModel>();

            //List<ResourcePackage> packgeList = new ResourcePackageController().GetAll();
            //if (packgeList != null && packgeList.Count > 0)
            //    packges = packgeList.Select(g => (new KeyValueViewModel() { Key = g.Id, Value = g.Name })).ToList();
            //List<MemberType> memberTypeList = new ResourceMemberController().GetMemberTypes();
            //if (memberTypeList != null && memberTypeList.Count > 0)
            //    memberTypes = memberTypeList.Select(g => new KeyValueViewModel() { Key = g.Id, Value = g.MemberName }).ToList();
            //ViewBag.memberTypes = memberTypes;
            //ViewBag.packges = packges;

        }

        private string GetMemberTypeName(List<int> typeList)
        {
            if (typeList == null || typeList.Count <= 0) return "";

            string typeName = "";
            //List<MemberType> memberTypeList = new ResourceMemberController().GetMemberTypes();

            //foreach (MemberType item in memberTypeList)
            //{
            //    if (typeList.Where(g => g == item.Id).Count() > 0)
            //    {
            //        typeName += item.MemberName + "、";
            //    }
            //}

            return typeName.TrimEnd('、');
        }

        /// <summary>
        /// 检查资料名是否存在
        /// </summary>
        /// <param name="title">名称</param>
        /// <param name="id">id</param>
        /// <param name="packageId">包id</param>
        /// <param name="format">文件格式</param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult CheckResName(string title, int id, int packageId, int format)
        {
            //ResourceFilterModel filter = new ResourceFilterModel() { Name = title, PackageId = packageId, Format = (ResourceFormat)format };
            //List<Resource> resList = new cncbk_resource_application.Controller.ResourceController().GetByFilter(filter);

            //if (resList != null && resList.Count > 0)
            //{
            //    if (resList.Where(g => g.Id == id).Count() <= 0)
            //    {
            //        return Json("资料名称已存在", JsonRequestBehavior.AllowGet);
            //    }
            //}

            return Json(true, JsonRequestBehavior.AllowGet);
        }


    }
}