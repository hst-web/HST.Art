using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HST.Art.Web
{
    public class ResAdminViewModel
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "用户名")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "用户名不能为空")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "用户名不能包含空字符")]
        [Remote("CheckUserName", "ResAdmin", AdditionalFields = "Id", ErrorMessage = "用户名称已存在")]
        public string UserName { get; set; } // user_name (length: 100)

        [Display(Name = "手机号")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "手机号不能为空")]
        [RegularExpression(@"^1[34578]\d{9}$", ErrorMessage = "手机号格式不正确")]
        [Remote("CheckPhone", "ResAdmin", AdditionalFields = "Id", ErrorMessage = "手机号已存在")]
        public string Phone { get; set; } // phone

        [Display(Name = "邮箱")]
        [RegularExpression(@"^[A-Za-z0-9\u4e00-\u9fa5]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$", ErrorMessage = "邮箱格式不正确")]
        public string Email { get; set; } // email (length: 100)

        [StringLength(20, MinimumLength = 6, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "密码不能为空")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "密码不能包含空字符")]
        [Display(Name = "密码")]
        public string Password { get; set; } // password (length: 50)

        [Display(Name = "加盐")]
        public int SaltPassword { get; set; } // salt_password

        [Display(Name = "是否启用")]
        public int State { get; set; } // state


        [Display(Name = "角色ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "角色不能为空")]
        public string RoleId { get; set; }


        [Display(Name = "备注")]
        public string Remark { get; set; } // remark (length: 500)


        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [Display(Name = "角色集合")]
        //public List<ResourceRole> RoleList { get; set; }

        public bool IsSupAdmin { get; set; }
    }
}