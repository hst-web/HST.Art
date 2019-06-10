using HST.Art.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HST.Art.Web
{
    public class SidebarViewModel
    {
        /// <summary>
        /// 最新新闻
        /// </summary>
        public List<Article> NewestList { get; set; }
    }
}