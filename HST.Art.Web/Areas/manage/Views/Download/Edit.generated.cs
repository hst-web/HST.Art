﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 6 "..\..\Areas\manage\Views\Download\Edit.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\Download\Edit.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\Download\Edit.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Download/Edit.cshtml")]
    public partial class _Areas_manage_Views_Download_Edit_cshtml : System.Web.Mvc.WebViewPage<DownloadViewModel>
    {
        public _Areas_manage_Views_Download_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\manage\Views\Download\Edit.cshtml"
  
    Layout = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Areas\manage\Views\Download\Edit.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\manage\Views\Download\Edit.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\manage\Views\Download\Edit.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Areas\manage\Views\Download\Edit.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 267), Tuple.Create("\"", 323)
, Tuple.Create(Tuple.Create("", 273), Tuple.Create<System.Object, System.Int32>(Href("~/Content/lib/webuploader/0.1.5/webuploader.min.js")
, 273), false)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 389), Tuple.Create("\"", 429)
, Tuple.Create(Tuple.Create("", 395), Tuple.Create<System.Object, System.Int32>(Href("~/Content/lib/ckeditor/ckeditor.js")
, 395), false)
);

WriteLiteral("></script>\r\n<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    .form-horizontal .form-label {\r\n        text-align: right;\r\n    }\r\n</style" +
">\r\n<nav");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe67f;</i> 首页 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span>");

            
            #line 21 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                                                                              Write(Html.ActionLink("下载管理", "List"));

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" onclick=\"location.reload()\"");

WriteLiteral(">编辑下载</a> </nav>\r\n<article");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Areas\manage\Views\Download\Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\manage\Views\Download\Edit.cshtml"
     using (Ajax.BeginForm("Edit", "Download", new { }, new AjaxOptions() { HttpMethod = "Post", OnSuccess = "formSuccess(data)", OnBegin = "disSubmit('sub_btn')", OnComplete = "enSubmit('sub_btn')" }, new { id = "", @class = "form form-horizontal" }))
    {
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\manage\Views\Download\Edit.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\manage\Views\Download\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>文件头图：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ");

            
            #line 30 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                    Write(string.IsNullOrEmpty(Model.FileImg) ? "" : "style=position:relative");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"upfileImg\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1478), Tuple.Create("\"", 1551)
, Tuple.Create(Tuple.Create("", 1486), Tuple.Create("up-img-left", 1486), true)
            
            #line 31 "..\..\Areas\manage\Views\Download\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 1497), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FileImg)?"":"up-imgBtn"
            
            #line default
            #line hidden
, 1498), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 32 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                    Write(string.IsNullOrEmpty(Model.FileImg) ? "上传图片" : "更改图片");

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1690), Tuple.Create("\"", 1777)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create("help-block", 1698), true)
, Tuple.Create(Tuple.Create(" ", 1708), Tuple.Create("help-tip", 1709), true)
, Tuple.Create(Tuple.Create(" ", 1717), Tuple.Create("help-img", 1718), true)
            
            #line 34 "..\..\Areas\manage\Views\Download\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 1726), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FileImg)?"":"hidden"
            
            #line default
            #line hidden
, 1727), false)
);

WriteLiteral(" style=\"top:8px;position:absolute\"");

WriteLiteral(">请上传jpg、jpeg、gif、bmp、png等图片类型的文件</span>\r\n                    <div");

WriteLiteral(" class=\"formControls\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"imglist\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <li><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1989), Tuple.Create("\"", 2014)
            
            #line 37 "..\..\Areas\manage\Views\Download\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1995), Tuple.Create<System.Object, System.Int32>(Model.SmallFileImg
            
            #line default
            #line hidden
, 1995), false)
);

WriteLiteral(" /></li>\r\n                        </ul>\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"loc_temp_img\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.FileImg, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.FileImg, new { id = "downFileImg", @class = "hide-area input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>所属类别：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-3 \"");

WriteLiteral(">\r\n                <select");

WriteLiteral(" class=\"select select-box\"");

WriteLiteral(" id=\"sel_type\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择所属类别</option>\r\n");

            
            #line 51 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                     foreach (CategoryDictionary item in ViewBag.AllCategory)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option ");

            
            #line 53 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                            Write(item.Id == Model.Category ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 53 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                                                                 Write(item.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 53 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                                                                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 54 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n");

WriteLiteral("                ");

            
            #line 56 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Category, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 57 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Category, new { @class = "hide-area input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>下载标题：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.FileTitle, new { placeholder = "请输入下载标题", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 65 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.FileTitle, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>附件文件：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group \"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"upfile\"");

WriteLiteral(" style=\"float:left\"");

WriteLiteral(">\r\n                        本地上传\r\n                    </div>\r\n                    " +
"<span");

WriteAttribute("class", Tuple.Create(" class=\"", 3980), Tuple.Create("\"", 4069)
, Tuple.Create(Tuple.Create("", 3988), Tuple.Create("help-block", 3988), true)
, Tuple.Create(Tuple.Create(" ", 3998), Tuple.Create("help-tip", 3999), true)
, Tuple.Create(Tuple.Create(" ", 4007), Tuple.Create("help-file", 4008), true)
            
            #line 75 "..\..\Areas\manage\Views\Download\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 4017), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FileName)?"":"hidden"
            
            #line default
            #line hidden
, 4018), false)
);

WriteLiteral(" style=\"top:8px;position:absolute\"");

WriteLiteral(">请上传word、ppt、pdf、excel、txt和图片等类型的文件</span>\r\n                    <div");

WriteLiteral(" class=\"formControls file-up\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"filelist\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <li><span>");

            
            #line 78 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                 Write(Model.FileName);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n                        </ul>\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"loc_temp_inp\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 83 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Src, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 84 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Src, new { id = "file_src", @class = "hide-area input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral(">附件详情：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-8 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 90 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Description, new { @class = "ckeditor textarea", rows = "10", placeholder = "请输入附件详情..." }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-2 \"");

WriteLiteral(">状态：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"radio-list\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 98 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.State, (int)PublishState.Upper, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("上架\r\n                    </label>\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 101 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.State, (int)PublishState.Lower, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("下架\r\n                    </label>\r\n                </div>\r\n                ");

WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"btn_submit\"");

WriteLiteral(" class=\"col-xs-6  col-xs-offset-3 col-sm-offset-2 mt-10\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"btn btn-primary radius\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" id=\"sub_btn\"");

WriteLiteral(">保存</button>\r\n");

WriteLiteral("                ");

            
            #line 113 "..\..\Areas\manage\Views\Download\Edit.cshtml"
           Write(Html.ActionLink("取消", "List", null, new { @class = "btn btn-default radius" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 116 "..\..\Areas\manage\Views\Download\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 118 "..\..\Areas\manage\Views\Download\Edit.cshtml"
       Write(Html.HiddenFor(m => m.FileName, new { id = "file_name" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 119 "..\..\Areas\manage\Views\Download\Edit.cshtml"
       Write(Html.HiddenFor(m => m.Extension, new { id = "file_extension" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 120 "..\..\Areas\manage\Views\Download\Edit.cshtml"
       Write(Html.HiddenFor(m => m.FileType));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 122 "..\..\Areas\manage\Views\Download\Edit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</article>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var editor = CKEDITOR.replace(\'Description\',\r\n   " +
"       {\r\n              height: 260,\r\n              toolbar: \'Basic\',\r\n         " +
"     filebrowserImageUploadUrl: \"");

            
            #line 131 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                     Write(Url.Action("UploadEditer", "Upload"));

            
            #line default
            #line hidden
WriteLiteral(@"""
          });

        $(""#sel_type"").change(function () {
            $(""#Category"").val($(this).val()).blur();

        })
    });

    function formSuccess(result) {
        if (result != null) {
            if (result.isSuccess) {
                top.layer.alert('操作成功！', {
                    icon: 6, closeBtn: 0, yes: function () {
                        window.location = '");

            
            #line 145 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                      Write(Url.Action("List", "Download"));

            
            #line default
            #line hidden
WriteLiteral(@"';
                        parent.layer.closeAll();
                    }
                });
            } else {
                top.layer.alert('操作失败！', { icon: 5 });
            }
        } else {
            top.layer.alert('操作失败！', { icon: 5 });
        }
    }
</script>

<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    var maxcount = 8;
    //上传参数
    var jq_uploadFormData = { BidFileDomain: ' ', uploadQueryData: { Suffix: 0 } };
    if (!WebUploader.Uploader.support()) {
        $("".FJsp2"").html(""说明：当前浏览器不支持附件上传"");
        $(""#upfile"").hide();
        //alert( 'Web Uploader 不支持您的浏览器！如果你使用的是IE浏览器，请尝试升级 flash 播放器');
        alert(""当前浏览器不支持附件上传，如果你使用的是IE浏览器，请尝试升级 flash 播放器"");
        throw new Error('WebUploader does not support the browser you are using.');
    }
    var BASE_URL = ""/content/webuploader-0.1.5"";
    var file_ids = []; //已上传文件的路径
    var file_info = []; //记录文件的GUID和存储路径
    var isfilesuping = false;
    // 文件上传
    jQuery(function () {
        var id = ""upfile"";
        var $ = jQuery,
    state = 'pending',
    $probar = $(""#"" + id).siblings(""div"").find("".pros""),
    uploader;
        uploader = WebUploader.create({
            // 不压缩image
            resize: false,
            //发送后台时参数
            formData: jq_uploadFormData.uploadQueryData,
            fileVal: jq_uploadFormData.BidFileDomain,
            method: ""POST"",
            //是否分块（大文件上传）
            chunked: true,
            //设置文件上传域名称
            fileVal: 'file',
            //每块最大限制（默认5M 因为是.net 所以设置2M）
            chunkSize: 2097152,
            // swf文件路径
            swf: BASE_URL + '/Uploader.swf',
            // 文件接收服务端。
            server: jq_uploadFormData.BidFileDomain + '");

            
            #line 196 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                                  Write(Url.Action("Upload", "Upload"));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            //创建选择文件按钮\r\n            pick: { id: \"#\" + id, innerHTML: \"\", mult" +
"iple: false },\r\n            //选择文件自动上传\r\n            auto: true,\r\n            //a" +
"ccept:{title:\"只能上传rar,zip文件\",extensions :\'rar,zip\',mimeTypes:\'application/x-zip-" +
"compressed\'},\r\n            fileNumLimit: maxcount\r\n        });\r\n\r\n        //文件大小" +
"限制,超过则不加入队列\r\n        uploader.on(\'beforeFileQueued\', function (file, han, msg) {" +
"\r\n            var xzlist = (\"pdf,zip,rar,tar,gz,doc,docx,ppt,pptx,xlsx,xls,csv,m" +
"p4,txt,mp3,jpg,jpeg,gif,bmp,png\").split(\",\");\r\n            var imglist = (\"jpg,j" +
"peg,gif,bmp,png\").split(\",\");\r\n            var filenamelist = file.name.split(\'." +
"\');\r\n            var filehz = filenamelist[filenamelist.length - 1];\r\n\r\n        " +
"    if (xzlist.indexOf(filehz) < 0) {\r\n                layer.alert(\"请上传指定类型格式的文件" +
"\", 0);\r\n                return false;\r\n            }\r\n\r\n            if (imglist." +
"indexOf(filehz) >= 0) {\r\n                if (file.size > (1024 * 1024 * 5)) {\r\n " +
"                   layer.alert(\"图片大小不可超过5M\", 0);\r\n                    return fal" +
"se;\r\n                }\r\n            }\r\n\r\n            if (file.size > (1024 * 102" +
"4 * 10)) {\r\n                layer.alert(\"文件大小不可超过10M\", 0);\r\n                retu" +
"rn false;\r\n            }\r\n\r\n            var filelen = $(\"#filelist>li\").length;\r" +
"\n            if (filelen >= maxcount) {\r\n                layer.alert(\"超出最大上传数量\"," +
" 0);\r\n                return false;\r\n            }\r\n        });\r\n        //某个文件开" +
"始上传前触发，一个文件只会触发一次。\r\n        uploader.on(\'uploadStart\', function (file) {\r\n      " +
"      uploader.options.formData.guid = WebUploader.Base.guid();\r\n        });\r\n  " +
"      // 当有文件添加进来的时候\r\n        uploader.on(\'fileQueued\', function (file) {\r\n     " +
"       $(\".help-file\").hide();\r\n            $(\".yangli\").hide()\r\n            $(\"" +
".yulan\").show();\r\n            uploader.makeThumb(file, function (error, ret) {\r\n" +
"                var file_list = [];\r\n                file_list.push(\"<li id=\'\" +" +
" file.id + \"\'>\");\r\n                file_list.push(\"<em class=\'rar\'></em>\");\r\n   " +
"             file_list.push(\"<span class=\'title\'><span/>\");\r\n                fil" +
"e_list.push(\"<div class=\'percent_small\'>\");\r\n                file_list.push(\"<di" +
"v class=\'per_pic2\'>\");\r\n                file_list.push(\"<div class=\'change_per2\'" +
" style=\'width:1%\'></div>\");\r\n                file_list.push(\"</div>\");\r\n        " +
"        file_list.push(\"<span class=\'showtitle\'>正准备上传…</span></div>\");\r\n        " +
"        file_list.push(\"</div></li>\");\r\n                $(\"#filelist\").empty().a" +
"ppend(file_list.join(\'\'));\r\n            });\r\n        });\r\n        //重置\r\n        " +
"uploader.on(\'reset\', function (file) {\r\n\r\n        });\r\n        // 文件上传过程中创建进度条实时" +
"显示。\r\n        uploader.on(\'uploadProgress\', function (file, percentage) {\r\n      " +
"      var jd = parseInt(percentage * 100);\r\n            if (jd > 1) {\r\n         " +
"       $(\"#\" + file.id).find(\".change_per2\").css(\"width\", jd + \'%\');\r\n          " +
"      $(\"#\" + file.id).find(\".per_pic2,.showtitle\").attr(\"title\", \'已上传\' + jd + \'" +
"%\');\r\n                $(\"#\" + file.id).find(\".showtitle\").text(\'已上传\' + jd + \'%\')" +
";\r\n            }\r\n            if (jd >= 100) {\r\n                $(\"#\" + file.id)" +
".find(\".per_pic2,.showtitle\").attr(\"title\", \"处理中...\");\r\n            }\r\n         " +
"   isfilesuping = uploader.getStats().progressNum != 0;\r\n        });\r\n\r\n        " +
"uploader.on(\'uploadSuccess\', function (file, obj) {\r\n\r\n            isfilesuping " +
"= uploader.getStats().progressNum != 0;\r\n            var jsonresult = obj._raw;\r" +
"\n            jsonresult = eval(\'(\' + jsonresult + \')\');\r\n            if (jsonres" +
"ult.FilePath) {\r\n                $(\"#\" + file.id).find(\".showtitle\").text(\"\");\r\n" +
"                $(\"#file_src,#loc_temp_inp\").val(jsonresult.FilePath);\r\n        " +
"        $(\"#file_src\").blur();\r\n                $(\"#file_name\").val(jsonresult.F" +
"ileName);\r\n                $(\"#file_extension\").val(jsonresult.Extension)\r\n     " +
"           $(\"#\" + file.id).find(\"span.title\").html(jsonresult.FileName);\r\n     " +
"       }\r\n            else {\r\n                layer.msg(jsonresult.Message);\r\n  " +
"          }\r\n\r\n            uploader.reset();\r\n        });\r\n\r\n        uploader.on" +
"(\'uploadError\', function (file, reason) {\r\n            layer.msg(reason);\r\n     " +
"   });\r\n        uploader.on(\'error\', function (handler) {\r\n            if (handl" +
"er == \"Q_EXCEED_NUM_LIMIT\") {\r\n                layer.alert(\"超出最大张数\");\r\n         " +
"   }\r\n            if (handler == \"F_DUPLICATE\") {\r\n                layer.alert(\"" +
"该文件已在上传列表\", 3);\r\n            }\r\n\r\n            if (handler == \"Q_TYPE_DENIED\") {\r" +
"\n                layer.alert(\"该文件不满足上传要求，可能您上传的文件为0KB\");\r\n            }\r\n       " +
" });\r\n        uploader.on(\'uploadComplete\', function (file) {\r\n            $(\'#\'" +
" + file.id).find(\'.percent_small\').fadeOut();\r\n        });\r\n\r\n    });\r\n\r\n</scrip" +
"t>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    var maxcount = 8;
    //上传参数
    var jq_imgFormData = { BidFileDomain: ' ', uploadQueryData: { Suffix: 1 } };
    if (!WebUploader.Uploader.support()) {
        $("".FJsp2"").html(""说明：当前浏览器不支持附件上传"");
        $(""#upfileImg"").hide();
        //alert( 'Web Uploader 不支持您的浏览器！如果你使用的是IE浏览器，请尝试升级 flash 播放器');
        alert(""当前浏览器不支持附件上传，如果你使用的是IE浏览器，请尝试升级 flash 播放器"");
        throw new Error('WebUploader does not support the browser you are using.');
    }
    var BASE_URL = ""/content/webuploader-0.1.5"";
    var file_ids = []; //已上传文件的路径
    var file_info = []; //记录文件的GUID和存储路径
    var isfilesuping = false;
    // 文件上传
    jQuery(function () {
        var id = ""upfileImg"";
        var $ = jQuery,
    state = 'pending',
    $probar = $(""#"" + id).siblings(""div"").find("".pros""),
    uploader;
        uploader = WebUploader.create({
            // 不压缩image
            resize: false,
            //发送后台时参数
            formData: jq_imgFormData.uploadQueryData,
            fileVal: jq_imgFormData.BidFileDomain,
            method: ""POST"",
            //是否分块（大文件上传）
            chunked: true,
            //设置文件上传域名称
            fileVal: 'file',
            //每块最大限制（默认5M 因为是.net 所以设置2M）
            chunkSize: 2097152,
            // swf文件路径
            swf: BASE_URL + '/Uploader.swf',
            // 文件接收服务端。
            server: jq_imgFormData.BidFileDomain + '");

            
            #line 357 "..\..\Areas\manage\Views\Download\Edit.cshtml"
                                               Write(Url.Action("Upload", "Upload"));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            //创建选择文件按钮\r\n            pick: { id: \"#\" + id, innerHTML: \"\", mult" +
"iple: false },\r\n            //选择文件自动上传\r\n            auto: true,\r\n            //a" +
"ccept:{title:\"只能上传rar,zip文件\",extensions :\'rar,zip\',mimeTypes:\'application/x-zip-" +
"compressed\'},\r\n            fileNumLimit: maxcount\r\n        });\r\n\r\n        //文件大小" +
"限制,超过则不加入队列\r\n        uploader.on(\'beforeFileQueued\', function (file, han, msg) {" +
"\r\n            var xzlist = (\"jpg,jpeg,gif,bmp,png\").split(\",\");\r\n            var" +
" filenamelist = file.name.split(\'.\');\r\n            var filehz = filenamelist[fil" +
"enamelist.length - 1];\r\n\r\n            if (xzlist.indexOf(filehz) < 0) {\r\n       " +
"         layer.alert(\"请上传指定类型格式的文件\", 0);\r\n                return false;\r\n       " +
"     }\r\n\r\n            if (file.size > (1024 * 1024 * 10)) {\r\n                lay" +
"er.alert(\"图片大小不可超过5M\", 0);\r\n                return false;\r\n            }\r\n\r\n    " +
"        var filelen = $(\"#imglist>li\").length;\r\n            if (filelen >= maxco" +
"unt) {\r\n                layer.alert(\"超出最大上传数量\", 0);\r\n                return fals" +
"e;\r\n            }\r\n        });\r\n        //某个文件开始上传前触发，一个文件只会触发一次。\r\n        uploa" +
"der.on(\'uploadStart\', function (file) {\r\n            uploader.options.formData.g" +
"uid = WebUploader.Base.guid();\r\n        });\r\n        // 当有文件添加进来的时候\r\n        upl" +
"oader.on(\'fileQueued\', function (file) {\r\n            $(\".help-img\").hide();\r\n  " +
"          $(\".yangli\").hide()\r\n            $(\".yulan\").show();\r\n            uplo" +
"ader.makeThumb(file, function (error, ret) {\r\n                var file_list = []" +
";\r\n                file_list.push(\"<li id=\'\" + file.id + \"\'>\");\r\n               " +
" file_list.push(\"<img src=\'\" + ret + \"\'/>\");\r\n                file_list.push(\"<d" +
"iv class=\'percent_small\'>\");\r\n                file_list.push(\"<div class=\'per_pi" +
"c2\'>\");\r\n                file_list.push(\"<div class=\'change_per2\' style=\'width:1" +
"%\'></div>\");\r\n                file_list.push(\"</div>\");\r\n                file_li" +
"st.push(\"<span class=\'showtitle\'>正准备上传…</span></div>\");\r\n                file_li" +
"st.push(\"</div></li>\");\r\n                $(\"#imglist\").empty().append(file_list." +
"join(\'\'));\r\n            });\r\n        });\r\n        //重置\r\n        uploader.on(\'res" +
"et\', function (file) {\r\n\r\n        });\r\n        // 文件上传过程中创建进度条实时显示。\r\n        upl" +
"oader.on(\'uploadProgress\', function (file, percentage) {\r\n            var jd = p" +
"arseInt(percentage * 100);\r\n            if (jd > 1) {\r\n                $(\"#\" + f" +
"ile.id).find(\".change_per2\").css(\"width\", jd + \'%\');\r\n                $(\"#\" + fi" +
"le.id).find(\".per_pic2,.showtitle\").attr(\"title\", \'已上传\' + jd + \'%\');\r\n          " +
"      $(\"#\" + file.id).find(\".showtitle\").text(\'已上传\' + jd + \'%\');\r\n            }" +
"\r\n            if (jd >= 100) {\r\n                $(\"#\" + file.id).find(\".per_pic2" +
",.showtitle\").attr(\"title\", \"处理中...\");\r\n            }\r\n            isfilesuping " +
"= uploader.getStats().progressNum != 0;\r\n        });\r\n\r\n        uploader.on(\'upl" +
"oadSuccess\', function (file, obj) {\r\n\r\n            isfilesuping = uploader.getSt" +
"ats().progressNum != 0;\r\n            var jsonresult = obj._raw;\r\n            jso" +
"nresult = eval(\'(\' + jsonresult + \')\');\r\n            if (jsonresult.FilePath) {\r" +
"\n                $(\"#\" + file.id).find(\".showtitle\").text(\"\");\r\n                " +
"$(\"#downFileImg,#loc_temp_img\").val(jsonresult.FilePath);\r\n                $(\"#d" +
"ownFileImg\").blur();\r\n                $(\"#\" + file.id).find(\"span.title\").html(j" +
"sonresult.FileName);\r\n                $(\"#upfileImg\").find(\"div.webuploader-pick" +
"\").html(\"更改图片\");\r\n                $(\"#upfileImg\").parent().attr(\"style\", \"positi" +
"on:relative\");//\r\n                $(\"#upfileImg\").addClass(\"up-imgBtn\");\r\n      " +
"      }\r\n            else {\r\n                layer.msg(jsonresult.Message);\r\n   " +
"         }\r\n\r\n            uploader.reset();\r\n        });\r\n\r\n        uploader.on(" +
"\'uploadError\', function (file, reason) {\r\n            layer.msg(reason);\r\n      " +
"  });\r\n        uploader.on(\'error\', function (handler) {\r\n            if (handle" +
"r == \"Q_EXCEED_NUM_LIMIT\") {\r\n                layer.alert(\"超出最大张数\");\r\n          " +
"  }\r\n            if (handler == \"F_DUPLICATE\") {\r\n                layer.alert(\"该" +
"文件已在上传列表\", 3);\r\n            }\r\n\r\n            if (handler == \"Q_TYPE_DENIED\") {\r\n" +
"                layer.alert(\"该文件不满足上传要求，可能您上传的文件为0KB\");\r\n            }\r\n        " +
"});\r\n        uploader.on(\'uploadComplete\', function (file) {\r\n            $(\'#\' " +
"+ file.id).find(\'.percent_small\').fadeOut();\r\n        });\r\n\r\n    });\r\n\r\n</script" +
">");

        }
    }
}
#pragma warning restore 1591
