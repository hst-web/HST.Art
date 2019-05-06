using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HST.Art.Web
{
    public class MemberTypeViewModel
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        private List<int> _resPermissionIds = new List<int>();

        /// <summary>
        /// 权限id集合
        /// </summary>
        public List<int> ResPermissionIds
        {
            get
            {
                return _resPermissionIds;
            }

            set
            {
                _resPermissionIds = value;
            }
       }   
    }
}