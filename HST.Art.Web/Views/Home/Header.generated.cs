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
    
    #line 2 "..\..\Views\Home\Header.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Home\Header.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Header.cshtml")]
    public partial class _Views_Home_Header_cshtml : System.Web.Mvc.WebViewPage<Organization>
    {
        public _Views_Home_Header_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 66), Tuple.Create("\"", 101)
            
            #line 5 "..\..\Views\Home\Header.cshtml"
, Tuple.Create(Tuple.Create("", 73), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home")
            
            #line default
            #line hidden
, 73), false)
);

WriteLiteral(" class=\"fl logo\"");

WriteLiteral("><img");

WriteLiteral(" src=\"/Content/image/logo.jpg\"");

WriteLiteral(" /></a>\r\n<div");

WriteLiteral(" class=\"fr top_fr\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Home\Header.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Home\Header.cshtml"
     if (!string.IsNullOrEmpty(Model.Telephone))
    {

            
            #line default
            #line hidden
WriteLiteral("        <p><i");

WriteLiteral(" class=\"iconfont icon-dianhua\"");

WriteLiteral("></i>");

            
            #line 9 "..\..\Views\Home\Header.cshtml"
                                           Write(Model.Telephone);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 10 "..\..\Views\Home\Header.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 11 "..\..\Views\Home\Header.cshtml"
     if (!string.IsNullOrEmpty(Model.Email))
    {

            
            #line default
            #line hidden
WriteLiteral("        <p><i");

WriteLiteral(" class=\"iconfont icon-email-icon\"");

WriteLiteral("></i>");

            
            #line 13 "..\..\Views\Home\Header.cshtml"
                                              Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 14 "..\..\Views\Home\Header.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
