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
    
    #line 6 "..\..\Views\Home\SecondMenu.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Home\SecondMenu.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/SecondMenu.cshtml")]
    public partial class _Views_Home_SecondMenu_cshtml : System.Web.Mvc.WebViewPage<HeaderViewModel>
    {
        public _Views_Home_SecondMenu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\SecondMenu.cshtml"
   
    string pcName = string.IsNullOrEmpty(Request.QueryString["pctype"]) ? "" : Request.QueryString["pctype"];
    string fcName = string.IsNullOrEmpty(Request.QueryString["fctype"]) ? "" : Request.QueryString["fctype"];

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Views\Home\SecondMenu.cshtml"
 if (Model != null)
{
    if (Model.CategoryList != null && Model.CategoryList.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <ul");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Home\SecondMenu.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Home\SecondMenu.cshtml"
             foreach (CategoryDictionary item in Model.CategoryList)
            {
                switch (Model.SectionType)
                {
                    case CategoryType.Industry:

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 648), Tuple.Create("\"", 748)
            
            #line 19 "..\..\Views\Home\SecondMenu.cshtml"
, Tuple.Create(Tuple.Create("", 656), Tuple.Create<System.Object, System.Int32>(fcName.Equals(item.Id.ToString(),StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 656), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 752), Tuple.Create("\"", 811)
            
            #line 19 "..\..\Views\Home\SecondMenu.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 759), Tuple.Create<System.Object, System.Int32>(Url.Action("industry","home",new {fctype=item.Id })
            
            #line default
            #line hidden
, 759), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\Views\Home\SecondMenu.cshtml"
                                                                                                                                                                                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 20 "..\..\Views\Home\SecondMenu.cshtml"
                        break;
                    case CategoryType.Association:

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 945), Tuple.Create("\"", 1045)
            
            #line 22 "..\..\Views\Home\SecondMenu.cshtml"
, Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(fcName.Equals(item.Id.ToString(),StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 953), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1049), Tuple.Create("\"", 1111)
            
            #line 22 "..\..\Views\Home\SecondMenu.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1056), Tuple.Create<System.Object, System.Int32>(Url.Action("association","home",new {fctype=item.Id })
            
            #line default
            #line hidden
, 1056), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\Views\Home\SecondMenu.cshtml"
                                                                                                                                                                                              Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 23 "..\..\Views\Home\SecondMenu.cshtml"
                        break;
                    case CategoryType.Examination:

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1245), Tuple.Create("\"", 1345)
            
            #line 25 "..\..\Views\Home\SecondMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(pcName.Equals(item.Id.ToString(),StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 1253), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1349), Tuple.Create("\"", 1411)
            
            #line 25 "..\..\Views\Home\SecondMenu.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1356), Tuple.Create<System.Object, System.Int32>(Url.Action("examination","home",new {pctype=item.Id })
            
            #line default
            #line hidden
, 1356), false)
);

WriteLiteral(">");

            
            #line 25 "..\..\Views\Home\SecondMenu.cshtml"
                                                                                                                                                                                              Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 26 "..\..\Views\Home\SecondMenu.cshtml"
                        break;
                    case CategoryType.Social:

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1540), Tuple.Create("\"", 1640)
            
            #line 28 "..\..\Views\Home\SecondMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(fcName.Equals(item.Id.ToString(),StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 1548), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1644), Tuple.Create("\"", 1702)
            
            #line 28 "..\..\Views\Home\SecondMenu.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1651), Tuple.Create<System.Object, System.Int32>(Url.Action("social","home",new { fctype=item.Id })
            
            #line default
            #line hidden
, 1651), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\Views\Home\SecondMenu.cshtml"
                                                                                                                                                                                          Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 29 "..\..\Views\Home\SecondMenu.cshtml"
                        break;
                    case CategoryType.Download:

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1833), Tuple.Create("\"", 1933)
            
            #line 31 "..\..\Views\Home\SecondMenu.cshtml"
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create<System.Object, System.Int32>(fcName.Equals(item.Id.ToString(),StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 1841), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1937), Tuple.Create("\"", 1996)
            
            #line 31 "..\..\Views\Home\SecondMenu.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1944), Tuple.Create<System.Object, System.Int32>(Url.Action("download","home",new {fctype=item.Id })
            
            #line default
            #line hidden
, 1944), false)
);

WriteLiteral(">");

            
            #line 31 "..\..\Views\Home\SecondMenu.cshtml"
                                                                                                                                                                                           Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 32 "..\..\Views\Home\SecondMenu.cshtml"
                        break;
                }
                
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Home\SecondMenu.cshtml"
                                                                
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 37 "..\..\Views\Home\SecondMenu.cshtml"
    }

}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591