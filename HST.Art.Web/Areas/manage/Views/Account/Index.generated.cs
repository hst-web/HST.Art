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
    
    #line 3 "..\..\Areas\manage\Views\Account\Index.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\manage\Views\Account\Index.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/manage/Views/Account/Index.cshtml")]
    public partial class _Areas_manage_Views_Account_Index_cshtml : System.Web.Mvc.WebViewPage<AccountViewModel>
    {
        public _Areas_manage_Views_Account_Index_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("<!--[if lt IE 9]>\r\n<script type=\"text/javascript\" src=\"lib/html5shiv.js\"></script" +
">\r\n<script type=\"text/javascript\" src=\"lib/respond.min.js\"></script>\r\n<![endif]-" +
"->\r\n");

            
            #line 10 "..\..\Areas\manage\Views\Account\Index.cshtml"
Write(Scripts.Render("~/bundles/saos"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..\Areas\manage\Views\Account\Index.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\manage\Views\Account\Index.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Areas\manage\Views\Account\Index.cshtml"
Write(Styles.Render("~/appcss"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--[if IE 6]>\r\n<script type=\"text/javascript\" src=\"lib/DD_belatedPNG_0.0.8a-mi" +
"n.js\" ></script>\r\n<script>DD_belatedPNG.fix(\'*\');</script>\r\n<![endif]-->\r\n\r\n<nav" +
"");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe67f;</i> 首页 <span");

WriteLiteral(" class=\"c-gray en\"");

WriteLiteral(">&gt;</span> 个人信息 <a");

WriteLiteral(" class=\"btn btn-primary radius r\"");

WriteLiteral(" style=\"line-height:1.6em;margin-top:3px\"");

WriteLiteral(" href=\"javascript:location.replace(location.href);\"");

WriteLiteral(" title=\"刷新\"");

WriteLiteral("><i");

WriteLiteral(" class=\"Hui-iconfont\"");

WriteLiteral(">&#xe68f;</i></a></nav>\r\n<div");

WriteLiteral(" class=\"page-container\"");

WriteLiteral(">\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"tab-system\"");

WriteLiteral(" class=\"HuiTab\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"tabBar cl\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"current\"");

WriteLiteral(">个人信息</span>\r\n                <span");

WriteLiteral(" class=\"\"");

WriteLiteral(">修改密码</span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"tabCon user-wrap\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\Areas\manage\Views\Account\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\manage\Views\Account\Index.cshtml"
                 using (Ajax.BeginForm("Update", "Account", new AjaxOptions() { HttpMethod = "Post", OnSuccess = "formSuccess(data)", OnBegin = "disSubmit('sub_btn')", OnComplete = "enSubmit('sub_btn')" }, new { id = "", @class = "form form-horizontal" }))
            {
                    
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\manage\Views\Account\Index.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\manage\Views\Account\Index.cshtml"
                                            
                    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\manage\Views\Account\Index.cshtml"
               Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Areas\manage\Views\Account\Index.cshtml"
                                              

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral(">\r\n                            用户名：\r\n                        </label>\r\n          " +
"              <div");

WriteLiteral(" class=\"formControls text col-xs-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 40 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Model.UserName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>\r\n                            姓名：\r\n                        </label>\r\n   " +
"                     <div");

WriteLiteral(" class=\"formControls text col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 48 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.RealName, new { placeholder = "请输入姓名", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.RealName, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>\r\n                            手机：\r\n                        </label>\r\n   " +
"                     <div");

WriteLiteral(" class=\"formControls text col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, new { placeholder = "请输入手机号", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Phone, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral(">\r\n                            邮箱：\r\n                        </label>\r\n           " +
"             <div");

WriteLiteral(" class=\"formControls text col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 66 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { placeholder = "请输入邮箱", @class = "input-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Areas\manage\Views\Account\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, null, new { @class = "error-lable" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"btn_submit\"");

WriteLiteral(" class=\"col-xs-6  col-xs-offset-3 col-sm-offset-1 mt-10\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary radius\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" id=\"sub_btn\"");

WriteLiteral(">保存</button>                         \r\n                        </div>\r\n          " +
"          </div>\r\n");

            
            #line 75 "..\..\Areas\manage\Views\Account\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"tabCon user-wrap\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" id=\"form-admin\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>原密码：</label>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-8 col-md-3\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"input-text\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" placeholder=\"原密码\"");

WriteLiteral(" id=\"oldPwd\"");

WriteLiteral(" name=\"oldPwd\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>新密码：</label>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-8 col-md-3\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"input-text\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" placeholder=\"新密码\"");

WriteLiteral(" id=\"newPwd\"");

WriteLiteral(" name=\"newPwd\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"form-label col-xs-2 col-md-1\"");

WriteLiteral(" style=\"padding-right:0px\"");

WriteLiteral("><span");

WriteLiteral(" class=\"c-red\"");

WriteLiteral(">*</span>确认密码：</label>\r\n                        <div");

WriteLiteral(" class=\"formControls col-xs-8 col-md-3\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" class=\"input-text\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" placeholder=\"确认新密码\"");

WriteLiteral(" id=\"renewPwd\"");

WriteLiteral(" name=\"renewPwd\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"row cl\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-xs-8 col-md-3 col-xs-offset-4 col-sm-offset-1 mt-10\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary radius\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">修改</button>\r\n                        </div>\r\n                    </div>\r\n       " +
"         </form>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");

            
            #line 109 "..\..\Areas\manage\Views\Account\Index.cshtml"
Write(Scripts.Render("~/bundles/validate"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $(""#tab-system"").Huitab({
                index: 0
            });

            $(""#form-admin"").validate({
                rules: {
                    oldPwd: {
                        required: true,
                        minlength: 6
                    },
                    newPwd: {
                        required: true,
                        minlength: 6
                    },
                    renewPwd: {
                        required: true,
                        minlength: 6,
                        equalTo: ""#newPwd""
                    }

                },
                messages: {
                    oldPwd: {
                        required: ""请输入原密码"",
                    },
                    newPwd: {
                        required: ""请输入新密码"",
                    },
                    renewPwd: {
                        required: ""请输入确认新密码"",
                        equalTo: ""确认新密码与新密码不一致""
                    }
                },
                onkeyup: false,
                focusCleanup: true,
                success: ""valid"",
                submitHandler: function (form) {
                    $(form).ajaxSubmit({
                        type: 'post',
                        url: """);

            
            #line 152 "..\..\Areas\manage\Views\Account\Index.cshtml"
                         Write(Url.Action("UpdatePwd"));

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                        success: function (data) {\r\n                         " +
"   if (data == \"ok\") {\r\n                                layer.alert(\'修改成功，请重新登录！" +
"\', {\r\n                                    icon: 6,\r\n                            " +
"        closeBtn: 0,\r\n                                    yes: function () {\r\n  " +
"                                      layer.closeAll();\r\n                       " +
"                 parent.location.reload();\r\n                                    " +
"}\r\n                                });\r\n                            } else if (d" +
"ata == \"error\") {\r\n                                layer.alert(\'修改失败！\', { icon: " +
"5 });\r\n                            } else {\r\n                                lay" +
"er.alert(data, { icon: 7 });\r\n                            }\r\n                   " +
"     },\r\n                        error: function (XmlHttpRequest, textStatus, er" +
"rorThrown) {\r\n                            layer.alert(\'修改失败！\', { icon: 5 });\r\n  " +
"                      }\r\n                    });\r\n                }\r\n           " +
" });\r\n        });\r\n\r\n        function formSuccess(result) {\r\n            if (res" +
"ult != null) {\r\n                if (result == \"ok\") {\r\n                    layer" +
".alert(\'保存成功！\', {\r\n                        icon: 6,\r\n                        clo" +
"seBtn: 0,\r\n                        yes: function () {\r\n                         " +
"   layer.closeAll();\r\n                            location.reload();\r\n          " +
"              }\r\n                    });\r\n                } else\r\n              " +
"      layer.alert(\'保存失败！\', { icon: 5 });//icon:6为开心图\r\n            } else\r\n      " +
"          layer.alert(\'保存失败！\', { icon: 5 });//icon:6为开心图\r\n        }\r\n    </scrip" +
"t>\r\n");

});

        }
    }
}
#pragma warning restore 1591
