using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HST.Art.Core;
using HST.Utillity;

namespace HST.Art.Web
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0}长度{2}-{1}个字符")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "教师名不能为空")]
        [RegularExpression(@"^[^\s]+$", ErrorMessage = "教师名不能包含空字符")]

        public SectionType Section { get; set; }
        public int Category { get; set; }

        public string HeadImg { get; set; }
        public string Title { get; set; }

        public string Synopsis { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

        public string CreateDate { get; set; }

        
        public int State { get; set; }

       public string CategoryName { get; set; }

        public string SectionName
        {

            get
            {
                return Section.GetDescription();
            }
        }

    }
}