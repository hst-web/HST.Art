/*----------------------------------------------------------------
// 文件名：ArticleProvider.cs
// 功能描述： 文章数据提供者
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using HST.Art.Core;
using HST.Utillity;
using System.Text;
using System.Linq;
using System.Data;

namespace HST.Art.Data
{
    public class ArticleProvider : EntityProviderBase
    {
        #region 查询文章
        /// <summary>
        /// 根据ID获取文章信息
        /// </summary>
        /// <param name="id">文章ID</param>
        /// <returns>文章信息</returns>
        public Article Get(int id)
        {
            Article ArticleInfo = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"SELECT a.Id, a.UserId, a.Title, a.HeadImg, a.Content, a.Author, a.Section, a.State, a.ParCategory, a.Category,cd.Name as CategoryName,u.userName as UserName,pcd.Name as ParCategoryName, a.UpdateDate, a.CreateDate, a.IsDeleted  from Article a  inner join CategoryDictionary cd on a.category=cd.id left join CategoryDictionary pcd on a.ParCategory=pcd.id left join [User] u on a.userid=u.id where  a.IsDeleted=0 and a.id=@Id ";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@Id", id));

            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parametersList))
            {
                while (reader.Read())
                {
                    ArticleInfo = GetArticleFromReader(reader);
                }
            }

            return ArticleInfo;
        }

        /// <summary>
        /// 获取所有文章信息
        /// </summary>
        /// <param name="condition">筛选条件</param>
        /// <returns>文章集合</returns>
        public List<Article> GetAll(FilterEntityModel condition)
        {
            string whereSort = string.Empty;

            if (condition != null)
            {
                condition.DefaultSort = SortType.Desc;
                whereSort = condition.Where + condition.OrderBy;
            }

            List<Article> ArticleList = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);

            string strSql = @"SELECT a.Id, a.UserId, a.Title, a.HeadImg, a.Content, a.Author, a.Section, a.State, a.ParCategory, a.Category,cd.Name as CategoryName,u.userName as UserName,pcd.Name as ParCategoryName, a.UpdateDate, a.CreateDate, a.IsDeleted  from Article a  inner join CategoryDictionary cd on a.category=cd.id left join CategoryDictionary pcd on a.ParCategory=pcd.id left join [User] u on a.userid=u.id where  a.IsDeleted=0 " + whereSort;

            IList<DbParameter> parameList = null;
            if (condition != null && condition.SqlParList.Count > 0)
            {
                parameList = new List<DbParameter>();
                foreach (var item in condition.SqlParList)
                {
                    parameList.Add(new SqlParameter(item.Key, item.Value));
                }
            }

            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parameList))
            {
                ArticleList = new List<Article>();
                Article ArticleInfo = null;
                while (reader.Read())
                {
                    ArticleInfo = GetArticleFromReader(reader);
                    ArticleList.Add(ArticleInfo);
                }
            }

            return ArticleList;
        }

        /// <summary>
        /// 获取文章分页信息
        /// </summary>
        /// <param name="condition">筛选条件</param>
        /// <param name="totalNum">总条数</param>
        /// <returns>文章集合</returns>
        public List<Article> GetPage(FilterEntityModel condition, out int totalNum)
        {
            totalNum = 0;
            condition.DefaultSort = SortType.Desc;
            string sort = condition.OrderBy;
            string asSort = condition.AsOrderBy;
            string where = condition.Where;

            List<Article> ArticleList = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSqlQuery = @"select count(a.ID) from [Article] a inner join CategoryDictionary cd on a.Category=cd.id where  a.IsDeleted=0 " + where;//查询有多少条记录
            IList<DbParameter> parameList = new List<DbParameter>();
            parameList.Add(new SqlParameter("@pageSize", condition.PageSize));
            parameList.Add(new SqlParameter("@pageIndex", condition.PageIndex));

            if (condition.SqlParList.Count > 0)
            {
                foreach (var item in condition.SqlParList)
                {
                    parameList.Add(new SqlParameter(item.Key, item.Value));
                }
            }

            totalNum = Convert.ToInt32(dbHelper.ExecuteScalar(strSqlQuery, parameList));

            string strSql = @"SELECT [ID]
                                  ,[UserId]
                                  ,[Title]
                                  ,[HeadImg]
                                  ,[Author]
                                  ,[Section]
                                  ,[State]
                                  ,[ParCategory]
                                  ,[Category]
                                  ,[UpdateDate]
                                  ,[CreateDate]
                                  ,[UserName]
                                  ,[CategoryName]
                                  ,[ParCategoryName]
                            FROM (select top (@pageSize*@pageIndex)  a.[ID]
                                  ,a.[UserId]
                                  ,a.[Title]
                                  ,a.[HeadImg]
                                  ,a.[Author]
                                  ,a.[Section]
                                  ,a.[State]
                                  ,a.[ParCategory]
                                  ,a.[Category]
                                  ,a.[UpdateDate]
                                  ,a.[CreateDate]
                                  ,u.[UserName] as UserName
                                  ,cd.Name as [CategoryName]
                                  ,pcd.Name as [ParCategoryName]
                                    ,ROW_NUMBER() over(" + asSort + ") as num  from [Article] a  inner join CategoryDictionary cd on a.category=cd.id left join CategoryDictionary pcd on a.ParCategory=pcd.id left join [User] u on a.userid=u.id  where  a.IsDeleted=0 " + where + ") as t where num between (@pageIndex - 1) * @pageSize + 1  and @pageIndex*@pageSize " + sort;
            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parameList))
            {
                ArticleList = new List<Article>();
                Article ArticleInfo = null;
                while (reader.Read())
                {
                    ArticleInfo = GetArticleFromReader(reader);
                    ArticleList.Add(ArticleInfo);
                }
            }

            return ArticleList;
        }

        /// <summary>
        /// 从游标中读取数据
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Article GetArticleFromReader(DbDataReader reader)
        {
            Article ArticleInfo = new Article();
            ArticleInfo.Id = Convert.ToInt32(reader["Id"]);
            ArticleInfo.UserId = Convert.ToInt32(reader["UserId"]);
            ArticleInfo.Title = reader["Title"].ToString();
            ArticleInfo.Author = reader["Author"].ToString();
            ArticleInfo.Section = (SectionType)reader["Section"];
            ArticleInfo.State = Convert.ToInt32(reader["State"]) < 1 ? PublishState.Lower : PublishState.Upper;
            ArticleInfo.Category = Convert.ToInt32(reader["Category"]);
            ArticleInfo.ParCategory = Convert.ToInt32(reader["ParCategory"]);   
            ArticleInfo.CreateDate = Convert.ToDateTime(reader["CreateDate"]);
           
            if (ReaderExists(reader, "CategoryName") && DBNull.Value != reader["CategoryName"])
            {
                ArticleInfo.CategoryName = reader["CategoryName"].ToString();
            }
            if (ReaderExists(reader, "ParCategoryName") && DBNull.Value != reader["ParCategoryName"])
            {
                ArticleInfo.ParCategoryName = reader["ParCategoryName"].ToString();
            }
            if (ReaderExists(reader, "UserName") && DBNull.Value != reader["UserName"])
            {
                ArticleInfo.UserName = reader["UserName"].ToString();
            }
            if (ReaderExists(reader, "HeadImg") && DBNull.Value != reader["HeadImg"])
            {
                ArticleInfo.HeadImg = reader["HeadImg"].ToString();
            }
            if (ReaderExists(reader, "Content") && DBNull.Value != reader["Content"])
            {
                ArticleInfo.Content = reader["Content"].ToString();
            }
            if (ReaderExists(reader, "UpdateDate") && DBNull.Value != reader["UpdateDate"])
            {
                ArticleInfo.UpdateDate = Convert.ToDateTime(reader["UpdateDate"]);
            }

            return ArticleInfo;
        }

        #endregion

        #region 编辑文章

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="ArticleInfo">文章信息</param>
        /// <returns>添加成功标识</returns>
        public bool Add(Article ArticleInfo)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"if exists(select Id from Article where Number=@Number)
                                begin
                                    update Article set Name=@Name,HeadImg=@HeadImg,Star=@Star,State=@State,Category=@Category,Description=@Description,Province=@Province,City=@City,County=@County,CreateDate=getdate(),IsDeleted=0 where Number=@Number 
                                end
                                else
                                begin
                                Insert Into Article(Name, HeadImg, Star, Number, State, Category, Description, Province, City, County) 
                                   Values(@Name, @HeadImg, @Star, @Number, @State, @Category, @Description, @Province, @City, @County) 
                                end ";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@Name", ArticleInfo.Name));
            parametersList.Add(new SqlParameter("@HeadImg", ArticleInfo.HeadImg));
            parametersList.Add(new SqlParameter("@Star", ArticleInfo.Star));
            parametersList.Add(new SqlParameter("@Number", ArticleInfo.Number));
            parametersList.Add(new SqlParameter("@State", (int)ArticleInfo.State));
            parametersList.Add(new SqlParameter("@Category", ArticleInfo.Category));
            parametersList.Add(new SqlParameter("@Description", ArticleInfo.Description));
            parametersList.Add(new SqlParameter("@Province", ArticleInfo.Province));
            parametersList.Add(new SqlParameter("@City", ArticleInfo.City));
            parametersList.Add(new SqlParameter("@County", ArticleInfo.County));
            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="ArticleInfo">文章信息</param>
        /// <returns>修改成功标识</returns>
        public bool Update(Article ArticleInfo)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Article
                              Set [Name]=@Name
                                  ,[HeadImg]=@HeadImg 
                                  ,[Star]=@Star
                                  ,[Number]=@Number
                                  ,[State]=@State
                                  ,[Category]=@Category
                                  ,[Description]=@Description
                                  ,[Province]=@Province
                                  ,[City]=@City
                                  ,[County]=@County
                                  Where ID=@ID";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", ArticleInfo.Id));
            parametersList.Add(new SqlParameter("@Name", ArticleInfo.Name));
            parametersList.Add(new SqlParameter("@HeadImg", ArticleInfo.HeadImg));
            parametersList.Add(new SqlParameter("@Star", ArticleInfo.Star));
            parametersList.Add(new SqlParameter("@Number", ArticleInfo.Number));
            parametersList.Add(new SqlParameter("@State", (int)ArticleInfo.State));
            parametersList.Add(new SqlParameter("@Category", ArticleInfo.Category));
            parametersList.Add(new SqlParameter("@Description", ArticleInfo.Description));
            parametersList.Add(new SqlParameter("@Province", ArticleInfo.Province));
            parametersList.Add(new SqlParameter("@City", ArticleInfo.City));
            parametersList.Add(new SqlParameter("@County", ArticleInfo.County));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = "delete Article where id =@id";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@id", id));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }
        #endregion
    }
}
