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
    
    #line 2 "..\..\Views\Home\Index.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Home\Index.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Home\Index.cshtml"
    using HST.Utillity;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<HomeViewModel>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "山东省艺术职业教育专业建设指导委员会";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"banner\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"cont\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"swiper-container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"swiper-wrapper\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Home\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Home\Index.cshtml"
                 if (Model.BannerList != null && Model.BannerList.Count > 0)
                {
                    foreach (var item in Model.BannerList)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteLiteral(" class=\"swiper-slide\"");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 507), Tuple.Create("\"", 527)
            
            #line 17 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 514), Tuple.Create<System.Object, System.Int32>(item.WebLink
            
            #line default
            #line hidden
, 514), false)
);

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 533), Tuple.Create("\"", 551)
            
            #line 17 "..\..\Views\Home\Index.cshtml"
                , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(item.ImgSrc
            
            #line default
            #line hidden
, 539), false)
);

WriteLiteral(" onerror=\"javascript: this.src = \'/Content/image/zhanwei_banner.jpg\';\"");

WriteLiteral(" /></a>\r\n");

            
            #line 18 "..\..\Views\Home\Index.cshtml"
                    }
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"swiper-slide\"");

WriteLiteral("><img");

WriteLiteral(" src=\"/Content/image/zhanwei_banner.jpg\"");

WriteLiteral(" /></div>\r\n");

            
            #line 23 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"swiper-pagination\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"swiper-button-next\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"swiper-button-prev\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"cont_box\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"index_new_fl fl\"");

WriteLiteral(">\r\n        <p><b>NEWS</b><i></i>协会公告</p>\r\n        ");

WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"index_new_cont fl\"");

WriteLiteral(">\r\n");

            
            #line 38 "..\..\Views\Home\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Home\Index.cshtml"
         if (Model.BulletinList != null && Model.BulletinList.Count>0)
        {
            foreach (var item in Model.BulletinList)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"index_ul\"");

WriteLiteral(">\r\n");

            
            #line 43 "..\..\Views\Home\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\Home\Index.cshtml"
                       
                        string actionName = string.Empty;
                        int parCategory = 0;
                        switch (item.SectionType)
                        {
                            case CategoryType.Industry:
                                actionName = "industry";
                                break;
                            case CategoryType.Association:
                                actionName = "association";
                                break;
                            case CategoryType.Examination:
                                actionName = "examination";
                                parCategory = item.ParCategory;
                                break;
                            case CategoryType.Social:
                                actionName = "social";
                                break;
                            case CategoryType.Member:
                                actionName = "about";
                                break;
                            case CategoryType.Download:
                                actionName = "download";
                                break;
                        }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 70 "..\..\Views\Home\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Home\Index.cshtml"
                     if (parCategory > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2783), Tuple.Create("\"", 2912)
            
            #line 72 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2790), Tuple.Create<System.Object, System.Int32>(Url.Action(actionName, "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category,pctype=item.ParCategory })
            
            #line default
            #line hidden
, 2790), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"fl\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\Home\Index.cshtml"
                                     Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <span");

WriteLiteral(" class=\"fr\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Home\Index.cshtml"
                                        Write(item.CreateTime.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n");

            
            #line 76 "..\..\Views\Home\Index.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3196), Tuple.Create("\"", 3301)
            
            #line 79 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3203), Tuple.Create<System.Object, System.Int32>(Url.Action(actionName, "home", new {qtype = QSType.detail, id =item.Id, fctype = item.Category })
            
            #line default
            #line hidden
, 3203), false)
);

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"fl\"");

WriteLiteral(">");

            
            #line 80 "..\..\Views\Home\Index.cshtml"
                                     Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                            <span");

WriteLiteral(" class=\"fr\"");

WriteLiteral(">");

            
            #line 81 "..\..\Views\Home\Index.cshtml"
                                        Write(item.CreateTime.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n");

            
            #line 83 "..\..\Views\Home\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");

            
            #line 85 "..\..\Views\Home\Index.cshtml"
            }
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 90 "..\..\Views\Home\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <!--/index_new_cont-->\r\n    <div");

WriteLiteral(" class=\"index_new_fr fr\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"searc-cert\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3745), Tuple.Create("\"", 3785)
            
            #line 94 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 3752), Tuple.Create<System.Object, System.Int32>(Url.Action("Certificate","Home")
            
            #line default
            #line hidden
, 3752), false)
);

WriteLiteral("><b><img");

WriteLiteral(" src=\"/Content/image/index_new.jpg\"");

WriteLiteral(" /></b><span>证书查询 >></span></a></p>\r\n    </div>\r\n</div><!--/cont_box-->\r\n\r\n<div");

WriteLiteral(" class=\"cont_box\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"index_fl fl\"");

WriteLiteral(">\r\n        <h1><i></i>行业资讯</h1>\r\n");

            
            #line 101 "..\..\Views\Home\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\Home\Index.cshtml"
         if (Model.IndustryList != null && Model.IndustryList.Count > 0)
            {
                foreach (var item in Model.IndustryList)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"index_hy_box\"");

WriteLiteral(">\r\n\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4223), Tuple.Create("\"", 4317)
            
            #line 107 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4230), Tuple.Create<System.Object, System.Int32>(Url.Action("industry", new { qtype = QSType.detail, id=item.Id,fctype=item.Category })
            
            #line default
            #line hidden
, 4230), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"index_data fl\"");

WriteLiteral(">\r\n                            <p><b>");

            
            #line 109 "..\..\Views\Home\Index.cshtml"
                             Write(item.PublishDate.ToString("MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</b> ");

            
            #line 109 "..\..\Views\Home\Index.cshtml"
                                                                     Write(item.PublishDate.ToString("yyyy"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"index_cons fr\"");

WriteLiteral(">\r\n                            <h2>");

            
            #line 112 "..\..\Views\Home\Index.cshtml"
                           Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                            <p>");

            
            #line 113 "..\..\Views\Home\Index.cshtml"
                          Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 117 "..\..\Views\Home\Index.cshtml"
            }
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 122 "..\..\Views\Home\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div><!--/index_fl-->\r\n    <div");

WriteLiteral(" class=\"index_fl fr\"");

WriteLiteral(">\r\n        <h1><i></i>协会活动</h1>\r\n");

            
            #line 126 "..\..\Views\Home\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 126 "..\..\Views\Home\Index.cshtml"
         if (Model.AssociationList != null && Model.AssociationList.Count > 0)
            {
                foreach (var item in Model.AssociationList)
                {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"index_hy_box\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5190), Tuple.Create("\"", 5287)
            
            #line 131 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 5197), Tuple.Create<System.Object, System.Int32>(Url.Action("association", new { qtype = QSType.detail, id=item.Id,fctype=item.Category })
            
            #line default
            #line hidden
, 5197), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"index_data fl\"");

WriteLiteral(">\r\n                            <p><b>");

            
            #line 133 "..\..\Views\Home\Index.cshtml"
                             Write(item.PublishDate.ToString("MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</b> ");

            
            #line 133 "..\..\Views\Home\Index.cshtml"
                                                                     Write(item.PublishDate.ToString("yyyy"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"index_cons fr\"");

WriteLiteral(">\r\n                            <h2>");

            
            #line 136 "..\..\Views\Home\Index.cshtml"
                           Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                            <p>");

            
            #line 137 "..\..\Views\Home\Index.cshtml"
                          Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                    </a>\r\n                <" +
"/div>\r\n");

            
            #line 141 "..\..\Views\Home\Index.cshtml"
            }
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 146 "..\..\Views\Home\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div><!--/index_fl-->\r\n</div><!--/cont_box-->\r\n\r\n<div");

WriteLiteral(" class=\"box social-box\"");

WriteLiteral(" style=\"padding-top:5px\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"cont_box\"");

WriteLiteral(">\r\n        <h3><i></i>社会公益</h3>\r\n");

            
            #line 153 "..\..\Views\Home\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 153 "..\..\Views\Home\Index.cshtml"
         if (Model.SocialList != null && Model.SocialList.Count > 0)
        {
            foreach (var item in Model.SocialList)
            {

            
            #line default
            #line hidden
WriteLiteral("                <dl>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6188), Tuple.Create("\"", 6280)
            
            #line 158 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 6195), Tuple.Create<System.Object, System.Int32>(Url.Action("social", new { qtype = QSType.detail, id=item.Id,fctype=item.Category })
            
            #line default
            #line hidden
, 6195), false)
);

WriteLiteral(">\r\n                        <dt><img");

WriteAttribute("src", Tuple.Create(" src=\"", 6316), Tuple.Create("\"", 6335)
            
            #line 159 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 6322), Tuple.Create<System.Object, System.Int32>(item.HeadImg
            
            #line default
            #line hidden
, 6322), false)
);

WriteLiteral(" onerror=\"nofind()\"");

WriteLiteral(" /></dt>\r\n                        <dd");

WriteLiteral(" class=\"title\"");

WriteLiteral(">");

            
            #line 160 "..\..\Views\Home\Index.cshtml"
                                     Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n                        <dd>");

            
            #line 161 "..\..\Views\Home\Index.cshtml"
                       Write(item.Synopsis);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n                    </a>\r\n                </dl>\r\n");

            
            #line 164 "..\..\Views\Home\Index.cshtml"
            }

        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(" style=\"margin:3% auto;\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 170 "..\..\Views\Home\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 6679), Tuple.Create("\"", 6730)
, Tuple.Create(Tuple.Create("", 6687), Tuple.Create("box", 6687), true)
            
            #line 174 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create(" ", 6690), Tuple.Create<System.Object, System.Int32>(Model.LogoList!=null?"":"box-height"
            
            #line default
            #line hidden
, 6691), false)
);

WriteLiteral(">\r\n");

            
            #line 175 "..\..\Views\Home\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 175 "..\..\Views\Home\Index.cshtml"
     if (Model.LogoList != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"cont_box\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"owl-carousel\"");

WriteLiteral(">\r\n\r\n");

            
            #line 180 "..\..\Views\Home\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 180 "..\..\Views\Home\Index.cshtml"
                 foreach (RotationChart secItem in Model.LogoList)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("href", Tuple.Create(" href=\"", 6974), Tuple.Create("\"", 6997)
            
            #line 182 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 6981), Tuple.Create<System.Object, System.Int32>(secItem.WebLink
            
            #line default
            #line hidden
, 6981), false)
);

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 7003), Tuple.Create("\"", 7024)
            
            #line 182 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 7009), Tuple.Create<System.Object, System.Int32>(secItem.ImgSrc
            
            #line default
            #line hidden
, 7009), false)
);

WriteLiteral(" onerror=\"nofind()\"");

WriteLiteral(" /></a>\r\n");

            
            #line 183 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");

            
            #line 187 "..\..\Views\Home\Index.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 191 "..\..\Views\Home\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            var owl = $('.owl-carousel');
            owl.owlCarousel({
                margin: 0,
                nav: true,
                loop: true,
                lazyLoad: true,
                merge: true,
                //autoplay: 2500,
                responsive: {
                    0: {
                        items: 2
                    },
                    600: {
                        items: 2
                    },
                    1000: {
                        items: 5
                    }
                }
            });//1
        })

        //banner
        var swiper = new Swiper('.swiper-container', {
            pagination: '.swiper-pagination',
            nextButton: '.swiper-button-next',
            prevButton: '.swiper-button-prev',
            paginationClickable: true,
            spaceBetween: 30,
            loop: true,
            centeredSlides: true,
            autoplay: 3500,
            autoplayDisableOnInteraction: false
        });

    </script>
");

});

        }
    }
}
#pragma warning restore 1591