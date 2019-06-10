using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HST.Art.Core;


namespace HST.Art.Web
{
    public class HomeViewModel
    {
        public List<RotationChart> BannerList { get; set; }

        public List<RotationChart> LogoList { get; set; }
        /// <summary>
        /// 协会活动集合
        /// </summary>
        public List<Article> AssociationList { get; set; }
        /// <summary>
        /// 行业资讯集合
        /// </summary>
        public List<Article> IndustryList { get; set; }
        /// <summary>
        /// 社会公益集合
        /// </summary>
        public List<Article> SocialList { get; set; }
        /// <summary>
        /// 协会公告最新集合
        /// </summary>
        public List<Article> NewestList { get; set; }
    }
}