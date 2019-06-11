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

    public class DetailViewModel
    {
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }

    public class WebContentViewModel
    {
      
        public DetailViewModel DetailModel { get; set; }
        public PageListViewModel<object> PageListModel { get; set; }
        public PageViewModel PageFilter { get; set; }
        public QSType QType { get; set; }
    }

    public class PageViewModel
    {
        public PageViewModel()
        {
            PageIndex = 1;
            PageSize = 10;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Category { get; set; }
    }

    public class QueryViewModel
    {
        public int Id { get; set; }
        public QSType QType { get; set; }
        public string FCType { get; set; }
    }

    public enum QSType
    {
        Synopsis,
        Frame,
        List,
        Detail
    }
}