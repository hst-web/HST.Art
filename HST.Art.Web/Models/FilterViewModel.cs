using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HST.Art.Web
{
    /// <summary>
    /// 筛选条件类
    /// </summary>
    public class FilterViewModel
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public FilterViewModel()
        {
            PageIndex = 1;
            PageSize = 10;
            Where = "";
        }

        /// <summary>
        /// where条件
        /// </summary>
        public string Where { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize { get; set; }

    }
}
