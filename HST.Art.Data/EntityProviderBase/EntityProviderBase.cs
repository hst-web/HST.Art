/*----------------------------------------------------------------
// 文件名：EntityProviderBase.cs
// 功能描述：实体数据提供者基类
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/
using System;
using System.Configuration;
using HST.Utillity;
using System.Data.Common;

namespace HST.Art.Data
{
    /// <summary>
    /// 实体数据提供者基类
    /// </summary>
    public abstract class EntityProviderBase : IDisposable
    {
        private string _connectionString = "";
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public virtual string ConnectionString
        {
            get { return _connectionString; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public EntityProviderBase()
        {
            object conn = CacheHelper.Get("ConnectionStrings");
            if (conn == null)
            {
                _connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                CacheHelper.Set("ConnectionStrings", _connectionString);
            }
            else
            {
                _connectionString = conn.ToString();
            }
           
        }

        /// <summary>
        /// 实现IDisposable接口
        /// </summary>
        public void Dispose() { }

        /// <summary>
        /// 防止sql注入
        /// </summary>
        /// <param name="inputSQL">输入sql</param>
        /// <returns></returns>
        public string SafeSqlLiteral(string inputSQL)
        {
            inputSQL=inputSQL.Replace("'", "''");
            inputSQL = inputSQL.Replace("[", "[[]");
            inputSQL = inputSQL.Replace("%", "[%]");
            inputSQL = inputSQL.Replace("_", "[_]");
            return inputSQL;
        }

        /// <summary>
        /// 判断游标中是否存在指定列名
        /// </summary>
        /// <param name="dr">DbDataReader</param>
        /// <param name="columnName">列名</param>
        /// <returns></returns>
        public bool ReaderExists(DbDataReader dr, string columnName)
        {
            dr.GetSchemaTable().DefaultView.RowFilter = "ColumnName= '" +
            columnName + "'";
            return (dr.GetSchemaTable().DefaultView.Count > 0);
        }
    }
}
