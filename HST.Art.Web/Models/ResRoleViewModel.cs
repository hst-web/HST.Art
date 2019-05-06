using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HST.Art.Web
{
    public class ResRoleViewModel
    {
        [Display(Name = "角色ID")]
        public int Id { get; set; }
        [Display(Name = "角色名称")]
        [StringLength(20, ErrorMessage = "角色名称长度不能超过40个字符")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "角色名不能包含空字符")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "角色名称不能为空")]
        [Remote("CheckRoleName", "ResRole", AdditionalFields = "Id", ErrorMessage = "角色名称已存在")]
        public string RoleName { get; set; } // user_name (length: 100)
        [Display(Name = "角色状态")]
        public int RoleStatus { get; set; } // user_name (length: 100)
        [Display(Name = "创建角色时间")]
        public DateTime RoleCtime { get; set; } // user_name (length: 100)
        [Display(Name = "菜单列表")]
        public List<string> menuList { get; set; }

    }
}