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
    
    #line 6 "..\..\Areas\manage\Views\Student\Edit.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\Student\Edit.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\Student\Edit.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Student/Edit.cshtml")]
    public partial class _Areas_manage_Views_Student_Edit_cshtml : System.Web.Mvc.WebViewPage<StuViewModel>
    {
        public _Areas_manage_Views_Student_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\manage\Views\Student\Edit.cshtml"
  
    Layout = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Areas\manage\Views\Student\Edit.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\manage\Views\Student\Edit.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\manage\Views\Student\Edit.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Areas\manage\Views\Student\Edit.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    .form-horizontal .form-label {\r\n        text-align: right;\r\n    }\r\n</style" +
">\r\n<article");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Areas\manage\Views\Student\Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\manage\Views\Student\Edit.cshtml"
     using (Ajax.BeginForm("Edit", "Student", new { }, new AjaxOptions() { HttpMethod = "Post", OnSuccess = "formSuccess(data)", OnBegin = "disSubmit('sub_btn')", OnComplete = "enSubmit('sub_btn')" }, new { id = "", @class = "form form-horizontal" }))
    {
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\manage\Views\Student\Edit.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                
        
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\manage\Views\Student\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>证书类别：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"radio-list\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.Category, CertificateType.Prize, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("获奖证书\r\n                    </label>\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 32 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.Category, CertificateType.Train, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("学员认证\r\n                    </label>\r\n                </div>\r\n            </div>\r\n " +
"       </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>证书编号：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Areas\manage\Views\Student\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Number, new { placeholder = "请输入证书编号", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Areas\manage\Views\Student\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Number, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>学员姓名：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Areas\manage\Views\Student\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.StudentName, new { placeholder = "请输入学员姓名", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 48 "..\..\Areas\manage\Views\Student\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.StudentName, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 51 "..\..\Areas\manage\Views\Student\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>性别：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"radio-list\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 57 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.Gender, Gender.Female, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("女\r\n                    </label>\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.Gender, Gender.Male, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("男\r\n                    </label>\r\n                </div>\r\n            </div>\r\n    " +
"    </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>所在地区：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Areas\manage\Views\Student\Edit.cshtml"
           Write(Html.HiddenFor(g=>g.Province));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <select");

WriteLiteral("  class=\"select select-box inline\"");

WriteLiteral(" disabled");

WriteLiteral(" style=\"width:45%;background:#eee\"");

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 70 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                     foreach (KeyValuePair<int, string> item in ViewBag.AreaProvince)
                     {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3283), Tuple.Create("\"", 3300)
            
            #line 72 "..\..\Areas\manage\Views\Student\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3291), Tuple.Create<System.Object, System.Int32>(item.Key
            
            #line default
            #line hidden
, 3291), false)
);

WriteLiteral(" ");

            
            #line 72 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                              Write(Model.Province == item.Key ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 72 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                                                                             Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 73 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n                <select");

WriteLiteral(" name=\"City\"");

WriteLiteral(" class=\"select select-box  inline float-right\"");

WriteLiteral(" style=\"width:50%\"");

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 76 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                     foreach (KeyValuePair<int, string> item in ViewBag.AreaCity)
                {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3657), Tuple.Create("\"", 3674)
            
            #line 78 "..\..\Areas\manage\Views\Student\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3665), Tuple.Create<System.Object, System.Int32>(item.Key
            
            #line default
            #line hidden
, 3665), false)
);

WriteLiteral(" ");

            
            #line 78 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                              Write(Model.City == item.Key ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 78 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                                                                         Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 79 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n\r\n            </div>\r\n        </div>\r\n");

            
            #line 84 "..\..\Areas\manage\Views\Student\Edit.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-xs-3 \"");

WriteLiteral(">状态：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-xs-6 \"");

WriteLiteral(">\r\n                <select");

WriteLiteral(" class=\"select select-box\"");

WriteLiteral(" name=\"State\"");

WriteLiteral(">\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4073), Tuple.Create("\"", 4107)
            
            #line 89 "..\..\Areas\manage\Views\Student\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4081), Tuple.Create<System.Object, System.Int32>((int)PublishState.Lower
            
            #line default
            #line hidden
, 4081), false)
);

WriteLiteral(" ");

            
            #line 89 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                                           Write(Model.State == (int)PublishState.Lower ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">下架</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4209), Tuple.Create("\"", 4243)
            
            #line 90 "..\..\Areas\manage\Views\Student\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4217), Tuple.Create<System.Object, System.Int32>((int)PublishState.Upper
            
            #line default
            #line hidden
, 4217), false)
);

WriteLiteral(" ");

            
            #line 90 "..\..\Areas\manage\Views\Student\Edit.cshtml"
                                                           Write(Model.State == (int)PublishState.Upper ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">上架</option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"btn_submit\"");

WriteLiteral(" class=\"col-xs-6  col-xs-offset-3 col-sm-offset-2 mt-10\"");

WriteLiteral(">\r\n\r\n                <button");

WriteLiteral(" class=\"btn btn-primary radius\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" id=\"sub_btn\"");

WriteLiteral(">保存</button>\r\n                <input");

WriteLiteral(" name=\"\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" onclick=\"layer_close();\"");

WriteLiteral(" class=\"btn btn-default radius \"");

WriteLiteral(" value=\"取消\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n");

            
            #line 101 "..\..\Areas\manage\Views\Student\Edit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</article>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    function formSuccess(result) {
        if (result != null) {
            if (result.isSuccess) {
                var index = parent.layer.getFrameIndex(window.name);
                layer.alert('保存成功！', {
                    icon: 6,
                    closeBtn: 0,
                    yes: function () {
                        if (parent[1] != null) {
                            parent[pageIndex()].table1.ajax.reload();
                        } else {
                            parent.table1.ajax.reload();
                        }
                        parent.layer.close(index);
                    }
                });
            } else
                layer.alert('保存失败！', { icon: 5 });//icon:6为开心图
        } else
            layer.alert('保存失败！', { icon: 5 });//icon:6为开心图
    }
</script>");

        }
    }
}
#pragma warning restore 1591
