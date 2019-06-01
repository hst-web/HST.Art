/*----------------------------------------------------------------
// 文件名：IntegratedProvider.cs
// 功能描述： 综合数据提供者
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
    public class IntegratedProvider : EntityProviderBase
    {
        #region 查询设置
        /// <summary>
        /// 根据ID获取设置信息
        /// </summary>
        /// <param name="id">设置ID</param>
        /// <returns>设置信息</returns>
        public Setting GetSetting(SettingType setType)
        {
            Setting settingInfo = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"SELECT Id, Type, Val, CreateDate  from Setting where IsEnabled=1 and Type=@Type ";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@Type", (int)setType));

            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parametersList))
            {
                while (reader.Read())
                {
                    settingInfo = GetSettingFromReader(reader);
                }
            }

            return settingInfo;
        }

        /// <summary>
        /// 从游标中读取数据
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Setting GetSettingFromReader(DbDataReader reader)
        {
            Setting settingInfo = new Setting();
            settingInfo.Id = Convert.ToInt32(reader["Id"]);
            settingInfo.Val = reader["Val"].ToString();
            settingInfo.Type = (SettingType)reader["Type"];
            settingInfo.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

            return settingInfo;
        }
        #endregion

        #region 编辑
        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="setInfo">设置信息</param>
        /// <returns>修改成功标识</returns>
        public bool UpdateSetting(Setting setInfo)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Setting
                              Set [Type]=@Type
                                  ,[Val]=@Val
                                  ,[IsEnabled]=@IsEnabled
                                  Where ID=@ID";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", setInfo.Id));
            parametersList.Add(new SqlParameter("@IsEnabled", Convert.ToInt32(setInfo.IsEnabled)));
            parametersList.Add(new SqlParameter("@Val", setInfo.Val));
            parametersList.Add(new SqlParameter("@Type", (int)setInfo.Type));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 修改设置
        /// </summary>
        /// <param name="setInfo">设置信息</param>
        /// <returns>修改成功标识</returns>
        public bool UpdateSettingByType(Setting setInfo)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Setting Set [Val]=@Val  Where [Type]=@Type";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@Val", setInfo.Val));
            parametersList.Add(new SqlParameter("@Type", (int)setInfo.Type));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 删除设置
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public bool DeleteSetting(int id)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = "delete Setting where id =@id";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@id", id));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }
        #endregion
    }
}
