using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HST.Art.Core;
using HST.Utillity;

namespace HST.Art.Web
{
    public class AcadeViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "教师名不能为空")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "教师名不能包含空字符")]
        public string TeacherName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "证书编号不能为空")]
        [Remote("CheckTeaNumber", "Teacher", AdditionalFields = "Id", ErrorMessage = "证书编号已存在")]

        public string HeadImg { get; set; }

        public string AcadeName { get; set; }

        public int Province { get; set; }

        public int City { get; set; }
        public string Area { get; set; }

        public string AcadeNumber { get; set; }

        public int AcadeStar { get; set; }

        public int Category { get; set; }

        public string CategoryName
        {
            get; set;
        }

        public string AcadeIntro { get; set; }

        public int State { get; set; }



    }
}