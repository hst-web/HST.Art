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
    
    #line 6 "..\..\Areas\manage\Views\Article\Edit.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\manage\Views\Article\Edit.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\manage\Views\Article\Edit.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Article/Edit.cshtml")]
    public partial class _Areas_manage_Views_Article_Edit_cshtml : System.Web.Mvc.WebViewPage<ArticleViewModel>
    {
        public _Areas_manage_Views_Article_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\manage\Views\Article\Edit.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..\Areas\manage\Views\Article\Edit.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\manage\Views\Article\Edit.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\manage\Views\Article\Edit.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Areas\manage\Views\Article\Edit.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 268), Tuple.Create("\"", 324)
, Tuple.Create(Tuple.Create("", 274), Tuple.Create<System.Object, System.Int32>(Href("~/Content/lib/webuploader/0.1.5/webuploader.min.js")
, 274), false)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 390), Tuple.Create("\"", 430)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Href("~/Content/lib/ckeditor/ckeditor.js")
, 396), false)
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

            
            #line 21 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                              Write(Html.ActionLink("文章管理", "List"));

            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" onclick=\"location.reload()\"");

WriteLiteral(">编辑文章</a> </nav>\r\n<article");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Areas\manage\Views\Article\Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Areas\manage\Views\Article\Edit.cshtml"
     using (Ajax.BeginForm("Edit", "Article", new { }, new AjaxOptions() { HttpMethod = "Post", OnSuccess = "formSuccess(data)", OnBegin = "disSubmit('sub_btn')", OnComplete = "enSubmit('sub_btn')" }, new { id = "", @class = "form form-horizontal" }))
    {
        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\manage\Views\Article\Edit.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\manage\Views\Article\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                  

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-sm-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>文章头图：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-sm-6 \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ");

            
            #line 30 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                    Write(string.IsNullOrEmpty(Model.HeadImg) ? "" : "style=position:relative");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"upfileImg\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1478), Tuple.Create("\"", 1552)
, Tuple.Create(Tuple.Create("", 1486), Tuple.Create("up-img-left", 1486), true)
            
            #line 31 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 1497), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.HeadImg) ?"":"up-imgBtn"
            
            #line default
            #line hidden
, 1498), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 32 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    Write(string.IsNullOrEmpty(Model.HeadImg) ? "上传图片" : "更改图片");

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1691), Tuple.Create("\"", 1779)
, Tuple.Create(Tuple.Create("", 1699), Tuple.Create("help-block", 1699), true)
, Tuple.Create(Tuple.Create(" ", 1709), Tuple.Create("help-tip", 1710), true)
, Tuple.Create(Tuple.Create(" ", 1718), Tuple.Create("help-img", 1719), true)
            
            #line 34 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 1727), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.HeadImg) ?"":"hidden"
            
            #line default
            #line hidden
, 1728), false)
);

WriteLiteral(" style=\"top:8px;position:absolute\"");

WriteLiteral(">请上传jpg、jpeg、gif、bmp、png等图片类型的文件</span>\r\n                    <div");

WriteLiteral(" class=\"formControls\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"imglist\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                            <li>\r\n");

            
            #line 38 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 38 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                 if (!string.IsNullOrEmpty(Model.SmallHeadImg))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2145), Tuple.Create("\"", 2170)
            
            #line 40 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2151), Tuple.Create<System.Object, System.Int32>(Model.SmallHeadImg
            
            #line default
            #line hidden
, 2151), false)
);

WriteLiteral(" style=\"max-width:125px\"");

WriteLiteral(" onerror=\'nofind()\'");

WriteLiteral(" />\r\n");

            
            #line 41 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </li>\r\n                        </ul>\r\n               " +
"         <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"loc_temp_img\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.HeadImg, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 48 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.HeadImg, new { id = "memberFileImg", @class = "hide-area input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-sm-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>所属模块：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-sm-3 \"");

WriteLiteral(">\r\n                <select");

WriteLiteral(" class=\"select select-box\"");

WriteLiteral(" name=\"Section\"");

WriteLiteral(" id=\"sel_section\"");

WriteLiteral(" onchange=\"bindData()\"");

WriteLiteral(">\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2990), Tuple.Create("\"", 3026)
            
            #line 55 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2998), Tuple.Create<System.Object, System.Int32>((int)SectionType.Industry
            
            #line default
            #line hidden
, 2998), false)
);

WriteLiteral(" ");

            
            #line 55 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                             Write(Model.Section == SectionType.Industry ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 55 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                                                       Write(SectionType.Industry.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3163), Tuple.Create("\"", 3202)
            
            #line 56 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3171), Tuple.Create<System.Object, System.Int32>((int)SectionType.Association
            
            #line default
            #line hidden
, 3171), false)
);

WriteLiteral(" ");

            
            #line 56 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                Write(Model.Section == SectionType.Association ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 56 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                                                             Write(SectionType.Association.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3345), Tuple.Create("\"", 3384)
            
            #line 57 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3353), Tuple.Create<System.Object, System.Int32>((int)SectionType.Examination
            
            #line default
            #line hidden
, 3353), false)
);

WriteLiteral(" ");

            
            #line 57 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                Write(Model.Section == SectionType.Examination ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 57 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                                                             Write(SectionType.Examination.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3527), Tuple.Create("\"", 3561)
            
            #line 58 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3535), Tuple.Create<System.Object, System.Int32>((int)SectionType.Social
            
            #line default
            #line hidden
, 3535), false)
);

WriteLiteral(" ");

            
            #line 58 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                           Write(Model.Section == SectionType.Social ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 58 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                                                   Write(SectionType.Social.GetDescription());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n            <label");

WriteLiteral(" class=\"form-label col-sm-1 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>所属类别：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-sm-4 \"");

WriteLiteral(">\r\n                <select");

WriteAttribute("class", Tuple.Create(" class=\"", 3878), Tuple.Create("\"", 3964)
, Tuple.Create(Tuple.Create("", 3886), Tuple.Create("select", 3886), true)
, Tuple.Create(Tuple.Create(" ", 3892), Tuple.Create("select-box", 3893), true)
, Tuple.Create(Tuple.Create(" ", 3903), Tuple.Create("inline", 3904), true)
            
            #line 63 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 3910), Tuple.Create<System.Object, System.Int32>(Model.Section==SectionType.Examination?"":"hidden"
            
            #line default
            #line hidden
, 3911), false)
);

WriteLiteral(" style=\"width:47%;\"");

WriteLiteral(" id=\"sel_parCategory\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"0\"");

WriteLiteral(">所属大类</option>\r\n");

            
            #line 65 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 65 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                     foreach (CategoryDictionary item in ViewBag.ParentCategory)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4197), Tuple.Create("\"", 4213)
            
            #line 67 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4205), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 4205), false)
);

WriteLiteral(" ");

            
            #line 67 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                             Write(Model.ParCategory == item.Id ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 67 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                              Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 68 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n                <select");

WriteAttribute("class", Tuple.Create(" class=\"", 4359), Tuple.Create("\"", 4458)
, Tuple.Create(Tuple.Create("", 4367), Tuple.Create("select", 4367), true)
, Tuple.Create(Tuple.Create(" ", 4373), Tuple.Create("select-box", 4374), true)
, Tuple.Create(Tuple.Create("  ", 4384), Tuple.Create("inline", 4386), true)
, Tuple.Create(Tuple.Create(" ", 4392), Tuple.Create("float-right", 4393), true)
            
            #line 70 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 4404), Tuple.Create<System.Object, System.Int32>(Model.Section==SectionType.Examination?"":"hidden"
            
            #line default
            #line hidden
, 4405), false)
);

WriteLiteral(" style=\"width:48%\"");

WriteLiteral(" id=\"sel_exCategory\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">所属类别</option>\r\n");

            
            #line 72 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 72 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                     foreach (CategoryDictionary item in ViewBag.ExCategorys)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4685), Tuple.Create("\"", 4701)
            
            #line 74 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4693), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 4693), false)
);

WriteLiteral(" ");

            
            #line 74 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                             Write(Model.Category == item.Id ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 74 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 75 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n                <select");

WriteAttribute("class", Tuple.Create(" class=\"", 4844), Tuple.Create("\"", 4923)
, Tuple.Create(Tuple.Create("", 4852), Tuple.Create("select", 4852), true)
, Tuple.Create(Tuple.Create(" ", 4858), Tuple.Create("select-box", 4859), true)
            
            #line 77 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create(" ", 4869), Tuple.Create<System.Object, System.Int32>(Model.Section==SectionType.Examination?"hidden":""
            
            #line default
            #line hidden
, 4870), false)
);

WriteLiteral(" id=\"sel_category\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">所属类别</option>\r\n");

            
            #line 79 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 79 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                     foreach (CategoryDictionary item in ViewBag.Categorys)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 5128), Tuple.Create("\"", 5144)
            
            #line 81 "..\..\Areas\manage\Views\Article\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 5136), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 5136), false)
);

WriteLiteral(" ");

            
            #line 81 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                             Write(Model.Category == item.Id ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 81 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                                                                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 82 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </select>\r\n");

WriteLiteral("                ");

            
            #line 84 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.HiddenFor(g => g.ParCategory, new { @Value = 0 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 85 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Category, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 86 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Category, new { id = "Category", @class = "hide-area input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-sm-2 \"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>文章标题：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-sm-8 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 92 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.Title, new { placeholder = "请输入文章标题", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 93 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.ValidationMessageFor(m => m.Title, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 96 "..\..\Areas\manage\Views\Article\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"form-label col-sm-2 \"");

WriteLiteral(">文章详情：</label>\r\n            <div");

WriteLiteral(" class=\"formControls col-sm-8 \"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 100 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.TextAreaFor(m => m.Description, new { @class = "ckeditor textarea", rows = "10", placeholder = "请输入文章详情..." }));

            
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

            
            #line 108 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.State, (int)PublishState.Upper, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("上架\r\n                    </label>\r\n                    <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 111 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                   Write(Html.RadioButtonFor(m => m.State, (int)PublishState.Lower, new { id = "" }));

            
            #line default
            #line hidden
WriteLiteral("下架\r\n                    </label>\r\n                </div>\r\n            </div>\r\n   " +
"     </div>\r\n");

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

            
            #line 119 "..\..\Areas\manage\Views\Article\Edit.cshtml"
           Write(Html.ActionLink("取消", "List", null, new { @class = "btn btn-default radius" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 122 "..\..\Areas\manage\Views\Article\Edit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</article>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var editor = CKEDITOR.replace(\'Description\',\r\n   " +
"       {\r\n              height: 260,\r\n              toolbar: \'Basic\',\r\n         " +
"     filebrowserImageUploadUrl: \"");

            
            #line 131 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                     Write(Url.Action("UploadEditer", "Upload"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n          });\r\n\r\n        $(\"#sel_parCategory\").change(function () {\r\n         " +
"   $(\"#ParCategory\").val($(this).val());\r\n            $.ajax({\r\n                " +
"url: \"");

            
            #line 137 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                 Write(Url.Action("GetCategorysById"));

            
            #line default
            #line hidden
WriteLiteral(@""",
                type: ""Get"",
                data: { ""parentId"": $(""#ParCategory"").val(), ""searchType"": 1 },
                dataType: ""json"",
                success: function (data) {
                    var stringBuild = new StringBuffer();
                    $.each(data, function (i, v) {
                        stringBuild.append(""<option value='"" + v.Key + ""'>"" + v.Value + ""</option>"");
                    });

                    $(""#sel_exCategory"").empty().append(""<option value=''>所属类别</option>"").append(stringBuild.toString());
                    $(""#sel_exCategory"").change();
                }
            })
        });

        $(""#sel_exCategory,#sel_category"").on(""change"", function () {
            $(""#Category"").val($(this).val()).blur();
        });
    });

    function bindData() {
        if ($(""#sel_section"").val() == '");

            
            #line 159 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                    Write((int)SectionType.Examination);

            
            #line default
            #line hidden
WriteLiteral(@"') {
            $(""#sel_parCategory,#sel_exCategory"").removeClass(""hidden"");
            $(""#sel_category"").addClass(""hidden"");
            $(""#sel_parCategory"").val(0).change();

        } else {
            $(""#sel_parCategory,#sel_exCategory"").addClass(""hidden"");
            $(""#sel_category"").removeClass(""hidden"");
            $.ajax({
                url: """);

            
            #line 168 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                 Write(Url.Action("GetCategorysBySection"));

            
            #line default
            #line hidden
WriteLiteral(@""",
                type: ""Get"",
                data: { ""sectionType"": $(""#sel_section"").val(), ""searchType"": 1 },
                dataType: ""json"",
                success: function (data) {
                    var stringBuild = new StringBuffer();
                    $.each(data, function (i, v) {
                        stringBuild.append(""<option value='"" + v.Key + ""'>"" + v.Value + ""</option>"");
                    });

                    $(""#sel_category"").empty().append(""<option value=''>所属类别</option>"").append(stringBuild.toString());
                    $(""#sel_category"").change();
                }
            })
        }
    }

    function formSuccess(result) {
        if (result != null) {
            if (result.isSuccess) {
                top.layer.alert('操作成功！', {
                    icon: 6, closeBtn: 0, yes: function () {
                        window.location = '");

            
            #line 190 "..\..\Areas\manage\Views\Article\Edit.cshtml"
                                      Write(Url.Action("List", "Article"));

            
            #line default
            #line hidden
WriteLiteral(@"'
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

            
            #line 241 "..\..\Areas\manage\Views\Article\Edit.cshtml"
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
"$(\"#memberFileImg,#loc_temp_img\").val(jsonresult.FilePath);\r\n                $(\"" +
"#memberFileImg\").blur();\r\n                $(\"#\" + file.id).find(\"span.title\").ht" +
"ml(jsonresult.FileName);\r\n                $(\"#upfileImg\").find(\"div.webuploader-" +
"pick\").html(\"更改图片\");\r\n                $(\"#upfileImg\").parent().attr(\"style\", \"po" +
"sition:relative\");//\r\n                $(\"#upfileImg\").addClass(\"up-imgBtn\");\r\n  " +
"          }\r\n            else {\r\n                layer.msg(jsonresult.Message);\r" +
"\n            }\r\n\r\n            uploader.reset();\r\n        });\r\n\r\n        uploader" +
".on(\'uploadError\', function (file, reason) {\r\n            layer.msg(reason);\r\n  " +
"      });\r\n        uploader.on(\'error\', function (handler) {\r\n            if (ha" +
"ndler == \"Q_EXCEED_NUM_LIMIT\") {\r\n                layer.alert(\"超出最大张数\");\r\n      " +
"      }\r\n            if (handler == \"F_DUPLICATE\") {\r\n                layer.aler" +
"t(\"该文件已在上传列表\", 3);\r\n            }\r\n\r\n            if (handler == \"Q_TYPE_DENIED\")" +
" {\r\n                layer.alert(\"该文件不满足上传要求，可能您上传的文件为0KB\");\r\n            }\r\n    " +
"    });\r\n        uploader.on(\'uploadComplete\', function (file) {\r\n            $(" +
"\'#\' + file.id).find(\'.percent_small\').fadeOut();\r\n        });\r\n\r\n    });\r\n\r\n</sc" +
"ript>");

        }
    }
}
#pragma warning restore 1591
