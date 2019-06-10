using HST.Art.Core;
using HST.Art.Service;
using System;
using System.Web.Mvc;
using HST.Utillity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;

namespace HST.Art.Web.Controllers
{
    public class HomeController : ApplicationBase
    {
        ArticleService _articleService = new ArticleService();
        RotationChartService _rotationChartService = new RotationChartService();

        // GET: Home
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            int totalNum = 0;
            FilterEntityModel fillter = new FilterEntityModel();
            fillter.PageSize = 5;
            fillter.SortDict = new KeyValuePair<string, SortType>("createDate", SortType.Desc);
            fillter.KeyValueList = new List<KeyValueObj>();
            fillter.KeyValueList.Add(new KeyValueObj() { Key = "State", Value = (int)PublishState.Upper });

            FilterEntityModel associationFillter = new FilterEntityModel() { KeyValueList = new List<KeyValueObj>() { new KeyValueObj() { Key = "State", Value = (int)PublishState.Upper } }, KeyValueReserve = new KeyValueObj() { Key = "Section", Value = (int)SectionType.Association }, PageSize = 5, SortDict = new KeyValuePair<string, SortType>("createDate", SortType.Desc) };
            FilterEntityModel industryFillter = new FilterEntityModel() { KeyValueList = new List<KeyValueObj>() { new KeyValueObj() { Key = "State", Value = (int)PublishState.Upper } }, KeyValueReserve = new KeyValueObj() { Key = "Section", Value = (int)SectionType.Industry }, PageSize = 5, SortDict = new KeyValuePair<string, SortType>("createDate", SortType.Desc) };
            FilterEntityModel socialFillter = new FilterEntityModel() { KeyValueList = new List<KeyValueObj>() { new KeyValueObj() { Key = "State", Value = (int)PublishState.Upper } }, KeyValueReserve = new KeyValueObj() { Key = "Section", Value = (int)SectionType.Social }, PageSize = 3, SortDict = new KeyValuePair<string, SortType>("createDate", SortType.Desc) };

            List<RotationChart> bannerList = _rotationChartService.GetAll(RotationType.Banner);
            List<RotationChart> logoList = _rotationChartService.GetAll(RotationType.Logo);

            model.NewestList = _articleService.GetPage(fillter, out totalNum);
            model.AssociationList = _articleService.GetPage(associationFillter, out totalNum);
            model.IndustryList = _articleService.GetPage(industryFillter, out totalNum);
            model.SocialList = _articleService.GetPage(socialFillter, out totalNum);

            if (model.IndustryList != null)
            {
                model.IndustryList.ForEach(g => g.SmallImg = GetThumb(g.HeadImg));
            }

            model.BannerList = bannerList != null ? bannerList.FindAll(g => g.State == PublishState.Upper) : null;
            model.LogoList = logoList != null ? logoList.FindAll(g => g.State == PublishState.Upper) : null;

            //if (logoList != null)
            //{
            //    List<List<RotationChart>> listGroup = new List<List<RotationChart>>();
            //    int j = 6;
            //    for (int i = 0; i < logoList.Count; i += 6)
            //    {
            //        List<RotationChart> cList = new List<RotationChart>();
            //        cList = logoList.Take(j).Skip(i).ToList();
            //        j += 6;
            //        listGroup.Add(cList);
            //    }

            //    model.LogoList = listGroup;
            //}   

            return View(model);
        }
    }
}