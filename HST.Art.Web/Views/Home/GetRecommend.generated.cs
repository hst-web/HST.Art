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
    
    #line 2 "..\..\Views\Home\GetRecommend.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Home\GetRecommend.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/GetRecommend.cshtml")]
    public partial class _Views_Home_GetRecommend_cshtml : System.Web.Mvc.WebViewPage<SidebarViewModel>
    {
        public _Views_Home_GetRecommend_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<p");

WriteLiteral(" class=\"list_ti\"");

WriteLiteral(">最新信息</p>\r\n<div");

WriteLiteral(" class=\"list_new\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\Views\Home\GetRecommend.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Home\GetRecommend.cshtml"
     if (Model.NewestList != null && Model.NewestList.Count > 0)
    {
        foreach (WebNewsViewModel item in Model.NewestList)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"list_div\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Home\GetRecommend.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Home\GetRecommend.cshtml"
                 switch (Model.SectionType)
                {
                    case CategoryType.Industry:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 443), Tuple.Create("\"", 548)
            
            #line 16 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 450), Tuple.Create<System.Object, System.Int32>(Url.Action("industry", "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 450), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 17 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 17 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 19 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 20 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 23 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                    case CategoryType.Association:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1049), Tuple.Create("\"", 1158)
            
            #line 25 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 1056), Tuple.Create<System.Object, System.Int32>(Url.Action("association", "home", new { qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 1056), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 26 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 26 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 28 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 29 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 32 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                    case CategoryType.Examination:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1659), Tuple.Create("\"", 1791)
            
            #line 34 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 1666), Tuple.Create<System.Object, System.Int32>(Url.Action("examination", "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category,pctype=item.ParCategory })
            
            #line default
            #line hidden
, 1666), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 35 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 35 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 37 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 38 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 41 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                    case CategoryType.Social:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2287), Tuple.Create("\"", 2390)
            
            #line 43 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 2294), Tuple.Create<System.Object, System.Int32>(Url.Action("social", "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 2294), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 44 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 44 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 46 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 47 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 50 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                    case CategoryType.Member:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2886), Tuple.Create("\"", 2989)
            
            #line 52 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 2893), Tuple.Create<System.Object, System.Int32>(Url.Action("about", "home", new { qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 2893), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 53 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 53 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 55 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 56 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 59 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                    case CategoryType.Download:

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3487), Tuple.Create("\"", 3592)
            
            #line 61 "..\..\Views\Home\GetRecommend.cshtml"
, Tuple.Create(Tuple.Create("", 3494), Tuple.Create<System.Object, System.Int32>(Url.Action("download", "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 3494), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"list_p fl\"");

WriteLiteral("><b>");

            
            #line 62 "..\..\Views\Home\GetRecommend.cshtml"
                                               Write(item.CreateTime.ToString("dd"));

            
            #line default
            #line hidden
WriteLiteral("</b>");

            
            #line 62 "..\..\Views\Home\GetRecommend.cshtml"
                                                                                  Write(item.CreateTime.ToString("yyyy-MM"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <div");

WriteLiteral(" class=\"list_fr_n fr\"");

WriteLiteral(">\r\n                                <p>");

            
            #line 64 "..\..\Views\Home\GetRecommend.cshtml"
                              Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                                <span>");

            
            #line 65 "..\..\Views\Home\GetRecommend.cshtml"
                                 Write(item.CreateTime.ToString("HH:mm"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n");

            
            #line 68 "..\..\Views\Home\GetRecommend.cshtml"
                        break;
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 72 "..\..\Views\Home\GetRecommend.cshtml"
        }
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 77 "..\..\Views\Home\GetRecommend.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div><!--/list_new-->\r\n");

        }
    }
}
#pragma warning restore 1591
