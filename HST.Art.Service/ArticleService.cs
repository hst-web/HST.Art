using HST.Art.Core;
using System;
using System.Collections.Generic;
/*----------------------------------------------------------------
// 文件名：ArticleService.cs
// 功能描述：文章服务
// 创建者：sysmenu
// 创建时间：2019-4-18
//----------------------------------------------------------------*/
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HST.Art.Data;

namespace HST.Art.Service
{
    public class ArticleService : ServiceBase, IArticleService
    {
        ArticleProvider _ArticleProvider = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public ArticleService(ArticleProvider ArticleProvider)
        {
            _ArticleProvider = ArticleProvider;
            AddDisposableObject(ArticleProvider);
        }

        public Article Get(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            Article ArticleInfo = _ArticleProvider.Get(id);
            return ArticleInfo;
        }

        public List<Article> GetAll(FilterEntityModel filterModel = null)
        {
            List<Article> ArticleList = _ArticleProvider.GetAll(filterModel);
            return ArticleList;
        }

        public List<Article> GetPage(FilterEntityModel filterModel, out int totalNum)
        {
            totalNum = 0;
            //参数验证
            if (filterModel == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }
            //获取数据
            List<Article> ArticleList = _ArticleProvider.GetPage(filterModel, out totalNum);

            return ArticleList;
        }

        public bool Add(Article ArticleInfo)
        {
            //参数验证
            if (ArticleInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Add(ArticleInfo);
        }

        public bool Delete(int id)
        {
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Delete(id);
        }

        public bool LogicDelete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "IsDeleted",
                Value = 1,
                TableName = "Article"
            });
        }

        public bool Publish(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Upper,
                TableName = "Article"
            });
        }

        public bool Recovery(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Lower,
                TableName = "Article"
            });
        }

        public bool Update(Article ArticleInfo)
        {
            //参数验证
            if (ArticleInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _ArticleProvider.Update(ArticleInfo);
        }

        public List<ArticleStatistic> GetStatistics()
        {
            return _ArticleProvider.GetStatisticArticles();
        }
    }
}
