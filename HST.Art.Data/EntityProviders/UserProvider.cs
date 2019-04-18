/*----------------------------------------------------------------
// 文件名：UserProvider.cs
// 功能描述： 会员数据提供者
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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using System.Data;
using HST.Art.Core.Models;

namespace HST.Art.Data
{
    /// <summary>
    /// 会员数据提供者
    /// </summary>
    public class UserProvider : EntityProviderBase
    {
        #region 查询会员
        /// <summary>
        /// 根据ID获取会员信息
        /// </summary>
        /// <param name="id">会员ID</param>
        /// <returns>员工信息</returns>
        public User Get(string id)
        {
            User userInfo = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"SELECT Id, UserName, Password, Salt, Name, Email, Telephone, HeadImg, IsAdmin, State, CreateDate  from user where id=@Id and IsDeleted=0";
            string strRole = "select * from UserRole where UserId=@UserId";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@Id", id));
            parametersList.Add(new SqlParameter("@UserId", id));

            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parametersList))
            {
                while (reader.Read())
                {
                    userInfo = GetUserFromReader(reader);
                }
            }

            if (userInfo != null)
            {
                DataTable dtRole = dbHelper.ExecuteDataTable(strRole, parametersList);
                if (dtRole != null && dtRole.Rows != null && dtRole.Rows.Count > 0)
                {
                    userInfo.RoleList = new List<int>();
                    foreach (DataRow item in dtRole.Rows)
                    {
                        userInfo.RoleList.Add(Convert.ToInt32(item["RoleId"]));
                    }
                }
            }

            return userInfo;
        }

        /// <summary>
        /// 根据员工手机号码获取员工信息(待删除)
        /// </summary>
        /// <param name="phone">员工手机号</param>
        /// <returns>员工信息</returns>
        public User GetByQuery(UserQuery userQuery)
        {
            User userInfo = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("SELECT Id, UserName, Password, Salt, Name, Email, Telephone, HeadImg, IsAdmin, State, CreateDate  from user where IsDeleted=0 ");

            List<DbParameter> parametersList = new List<DbParameter>();
            switch (userQuery.Key)
            {
                case LoginType.UserName:
                    sBuilder.Append(" and UserName=@UserName");
                    parametersList.Add(new SqlParameter("@UserName", userQuery.Value));
                    break;
                case LoginType.Telephone:
                    sBuilder.Append(" and Telephone=@Telephone");
                    parametersList.Add(new SqlParameter("@Telephone", userQuery.Value));
                    break;
                case LoginType.Email:
                    sBuilder.Append(" and Email=@Email");
                    parametersList.Add(new SqlParameter("@Email", userQuery.Value));
                    break;
            }

            using (DbDataReader reader = dbHelper.ExecuteReader(sBuilder.ToString(), parametersList))
            {
                while (reader.Read())
                {
                    userInfo = GetUserFromReader(reader);                   
                }
            }

            return userInfo;
        }

        /// <summary>
        /// 获取所有员工信息(待删除)
        /// </summary>
        /// <param name="organizationID">组织id</param>
        /// <param name="condition">筛选条件</param>
        /// <param name="totalNum">总条数</param>
        /// <returns>员工集合</returns>
        public List<DataEntity> GetAll(string organizationID, Condition condition)
        {
            string sort = string.IsNullOrEmpty(condition.Sort) ? "CreateTime asc" : condition.Sort + " " + condition.Direction;
            string where = GetWhereStaffStr(condition.Where);

            List<DataEntity> staffs = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);

            string strSql = @"SELECT s.[ID]
                                    ,s.[UserName]
                                    ,s.[Password]
                                    ,s.[OrganizationID]
                                    ,o.[Name] OrganizationName
                                    ,s.[IsAdmin]
                                    ,s.[Name]
                                    ,s.[Gender]
                                    ,s.[Speciality]
                                    ,s.[Titile]
                                    ,s.[WeChat]
                                    ,s.[Telephone]
                                    ,s.[Email]
                                    ,s.[HeadImg]
                                    ,s.[Description]
                                    ,s.[Profile]
                                    ,s.[CreateTime]
                                    ,s.[TelUpdateTime]
                                    ,s.[IsPushVoice]
                                    ,s.[IsReceivePush]
                            FROM [Staff] s Left join Organization o on s.OrganizationID=o.ID  where s.OrganizationID=@OrganizationID and s.OrganizationID<>'' " + where + " order by s." + sort;

            IList<DbParameter> parameList = new List<DbParameter>();
            parameList.Add(new SqlParameter("@OrganizationID", organizationID));
            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parameList))
            {
                staffs = new List<DataEntity>();
                DataEntity staff = null;
                while (reader.Read())
                {
                    staff = GetStaffFromReader(reader);
                    staffs.Add(staff);
                }
                return staffs;

            }
        }

        /// <summary>
        /// 获取所有员工信息(待删除)
        /// </summary>
        /// <param name="organizationID">组织id</param>
        /// <param name="condition">筛选条件</param>
        /// <param name="totalNum">总条数</param>
        /// <returns>员工集合</returns>
        public List<DataEntity> GetPage(string organizationID, Condition condition, out int totalNum)
        {
            totalNum = 0;
            string sort = string.IsNullOrEmpty(condition.Sort) ? "CreateTime asc" : condition.Sort + " " + condition.Direction;
            string where = GetWhereStaffStr(condition.Where);

            List<DataEntity> staffs = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSqlQuery = @"select count(s.ID) from [Staff] s Left join Organization o on s.OrganizationID=o.ID  where s.OrganizationID='" + organizationID + "'  " + where;//查询有多少条记录
            totalNum = Convert.ToInt32(dbHelper.ExecuteScalar(strSqlQuery, null));

            string strSql = @"SELECT [ID]
                                    ,[UserName]
                                    ,[Password]
                                    ,[OrganizationID]
                                    ,[OrganizationName]
                                    ,[IsAdmin]
                                    ,[Name]
                                    ,[Gender]
                                    ,[Speciality]
                                    ,[Titile]
                                    ,[WeChat]
                                    ,[Telephone]
                                    ,[Email]
                                    ,[HeadImg]
                                    ,[Description]
                                    ,[Profile]
                                    ,[CreateTime]
                                    ,[TelUpdateTime]
                            FROM (select top (@pageSize*@pageIndex)  s.[ID]
                                    ,s.[UserName]
                                    ,s.[Password]
                                    ,s.[OrganizationID]
                                    ,o.[Name] OrganizationName
                                    ,s.[IsAdmin]
                                    ,s.[Name]
                                    ,s.[Gender]
                                    ,s.[Speciality]
                                    ,s.[Titile]
                                    ,s.[WeChat]
                                    ,s.[Telephone]
                                    ,s.[Email]
                                    ,s.[HeadImg]
                                    ,s.[Description]
                                    ,s.[Profile]
                                    ,s.[CreateTime]
                                    ,s.[TelUpdateTime]
                                    ,ROW_NUMBER() over(order by s." + sort + ") as num  from [Staff] s Left join Organization o on s.OrganizationID=o.ID  where s.OrganizationID<>'' and s.OrganizationID='" + organizationID + "' " + where + ") as t where num between(@pageIndex - 1) * @pageSize + 1  and @pageIndex*@pageSize order by " + sort;

            IList<DbParameter> parameList = new List<DbParameter>();
            parameList.Add(new SqlParameter("@pageSize", condition.PageSize));
            parameList.Add(new SqlParameter("@pageIndex", condition.PageIndex));

            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parameList))
            {
                staffs = new List<DataEntity>();
                DataEntity staff = null;
                while (reader.Read())
                {
                    staff = GetStaffFromReader(reader);
                    staffs.Add(staff);
                }
                return staffs;

            }
        }

        /// <summary>
        /// 根据组织id获取所有员工信息(待删除)
        /// </summary>
        /// <param name="organizationID">组织id</param>
        /// <returns>员工集合</returns>
        public List<DataEntity> GetAll(string organizationID)
        {
            DataEntity staff = null;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"SELECT [ID]
                                    ,[UserName]
                                    ,[Password]
                                    ,[OrganizationID]
                                    ,[IsAdmin]
                                    ,[Name]
                                    ,[Gender]
                                    ,[Speciality]
                                    ,[Titile]
                                    ,[WeChat]
                                    ,[Telephone]
                                    ,[Email]
                                    ,[HeadImg]
                                    ,[Description]
                                    ,[Profile]
                                    ,[CreateTime]
                                    ,[TelUpdateTime]
                                    ,[IsPushVoice]
                                    ,[IsReceivePush]
                            FROM [Staff]
                            Where [OrganizationID]=@OrganizationID ";
            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@OrganizationID", organizationID));
            List<DataEntity> staffs = null;
            using (DbDataReader reader = dbHelper.ExecuteReader(strSql, parametersList))
            {
                staffs = new List<DataEntity>();
                while (reader.Read())
                {
                    staff = GetStaffFromReader(reader);
                    staffs.Add(staff);
                }
            }
            return staffs;
        }

        /// <summary>
        /// 获取where条件语句(待删除)
        /// </summary>
        /// <param name="jsonStr">json字符串</param>
        /// <returns></returns>
        private string GetWhereStaffStr(string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
                return string.Empty;
            StringBuilder whereBuilder = new StringBuilder();
            JObject job = (JObject)JsonConvert.DeserializeObject(jsonStr);

            if (job != null && job.Count > 0)
            {
                //员工姓名
                if (job["name"] != null && !string.IsNullOrEmpty(job["name"].ToString()))
                {
                    whereBuilder.Append(string.Format(" and (s.name like '%{0}%' or dbo.f_GetPy(s.[name]) like '{0}%')", job["name"].ToString()));
                }

                //创建时间
                if (job["startdate"] != null && !string.IsNullOrEmpty(job["startdate"].ToString()))
                {
                    whereBuilder.Append(" and CONVERT(varchar(10), s.createtime, 120)>='" + job["startdate"].ToString() + "'");
                }
                if (job["enddate"] != null && !string.IsNullOrEmpty(job["enddate"].ToString()))
                {
                    whereBuilder.Append(" and CONVERT(varchar(10), s.createtime, 120)<='" + job["enddate"].ToString() + "'");
                }

                //所属组织
                if (job["organizationId"] != null && !string.IsNullOrEmpty(job["organizationId"].ToString()))
                {
                    whereBuilder.Append(" and s.organizationId ='" + job["organizationId"].ToString() + "'");
                }
            }

            return whereBuilder.ToString();
        }

        /// <summary>
        /// 从游标中读取数据(待删除)
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private User GetUserFromReader(DbDataReader reader)
        {
            User userInfo = new User();
            userInfo.Id = Convert.ToInt32(reader["Id"]);
            userInfo.UserName = reader["UserName"].ToString();

            if (ReaderExists(reader, "Password") && DBNull.Value != reader["Password"])
            {
                userInfo.Password = reader["Password"].ToString();
            }

            if (ReaderExists(reader, "Salt") && DBNull.Value != reader["Salt"])
            {
                userInfo.Salt = Convert.ToInt32(reader["Salt"]);
            }

            if (ReaderExists(reader, "HeadImg") && DBNull.Value != reader["HeadImg"])
            {
                userInfo.HeadImg = reader["HeadImg"].ToString();
            }

            userInfo.Name = reader["Name"].ToString();
            userInfo.Email = reader["Email"].ToString();
            userInfo.Telephone = reader["Telephone"].ToString();           
            userInfo.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
            userInfo.State = Convert.ToInt32(reader["State"]) < 1 ? PublishState.Lower : PublishState.Upper;
            userInfo.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

            return userInfo;
        }

        #endregion

        #region 编辑员工

        /// <summary>
        /// 添加员工(待删除)
        /// </summary>
        /// <param name="staff">员工信息</param>
        /// <returns>添加成功标识</returns>
        public bool Add(DataEntity staff)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"if exists(select Id from staff where userName=@UserName)
                                begin
                                    update staff set OrganizationID=@OrganizationID,Password=@Password,IsAdmin=@IsAdmin,Email=@Email,Name=@Name where userName=@UserName 
                                end
                                else
                                begin
                                Insert Into Staff([ID],[UserName],[Password],[OrganizationID],[IsAdmin],[Name],[Telephone],[Email],[Description]) 
                                   Values(@ID,@UserName,@Password,@OrganizationID,@IsAdmin,@Name,@Telephone,@Email,@Description) 
                                end ";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", staff["ID"].Value));
            parametersList.Add(new SqlParameter("@UserName", staff["UserName"].Value));
            parametersList.Add(new SqlParameter("@Password", staff["Password"].Value));
            parametersList.Add(new SqlParameter("@OrganizationID", staff["OrganizationID"].Value));
            parametersList.Add(new SqlParameter("@IsAdmin", staff["IsAdmin"].Value));
            parametersList.Add(new SqlParameter("@Name", staff["Name"].Value));
            parametersList.Add(new SqlParameter("@Telephone", staff["Telephone"].Value));
            parametersList.Add(new SqlParameter("@Email", staff["Email"].Value));
            parametersList.Add(new SqlParameter("@Description", staff["Description"].Value));
            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 修改员工(待删除)
        /// </summary>
        /// <param name="staff">员工信息</param>
        /// <returns>修改成功标识</returns>
        public bool Update(DataEntity staff)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Staff
                              Set [UserName]=@UserName
                                  ,[Password]=@Password
                                  ,[OrganizationID]=@OrganizationID
                                  ,[IsAdmin]=@IsAdmin
                                  ,[Name]=@Name
                                  ,[Gender]=@Gender
                                  ,[Speciality]=@Speciality
                                  ,[Titile]=@Titile
                                  ,[WeChat]=@WeChat
                                  ,[Telephone]=@Telephone
                                  ,[Email]=@Email
                                  ,[HeadImg]=@HeadImg                                            
                                  ,[Description]=@Description
                                  ,[Profile]=@Profile
                                  ,[TelUpdateTime]=@TelUpdateTime 
                                  Where ID=@ID";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", staff["ID"].Value));
            parametersList.Add(new SqlParameter("@UserName", staff["UserName"].Value));
            parametersList.Add(new SqlParameter("@Password", staff["Password"].Value));
            parametersList.Add(new SqlParameter("@OrganizationID", staff["OrganizationID"].Value));
            parametersList.Add(new SqlParameter("@IsAdmin", staff["IsAdmin"].Value));
            parametersList.Add(new SqlParameter("@Name", staff["Name"].Value));
            parametersList.Add(new SqlParameter("@Gender", staff["Gender"].Value));
            parametersList.Add(new SqlParameter("@Speciality", staff["Speciality"].Value));
            parametersList.Add(new SqlParameter("@Titile", staff["Titile"].Value));
            parametersList.Add(new SqlParameter("@WeChat", staff["WeChat"].Value));
            parametersList.Add(new SqlParameter("@Telephone", staff["Telephone"].Value));
            parametersList.Add(new SqlParameter("@Email", staff["Email"].Value));
            parametersList.Add(new SqlParameter("@HeadImg", staff["HeadImg"].Value));
            parametersList.Add(new SqlParameter("@Description", staff["Description"].Value));
            parametersList.Add(new SqlParameter("@Profile", staff["Profile"].Value));
            parametersList.Add(new SqlParameter("@TelUpdateTime", staff["TelUpdateTime"].Value));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 删除员工(待删除)
        /// </summary>
        /// <param name="ids">员工id集合</param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            bool isSuccess = false;
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string delServicePersonRole = "delete ServicePersonRole where ServicePersonID in (select ID from ServicePerson Where StaffID =@id)";
            string delServicePerson = "delete ServicePerson Where StaffID=@id";
            string delStaff = @"Update Staff Set [OrganizationID]='' Where ID=@id";
            string delMessage = "delete BussinessMessage where UserID=@id";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("id", id));


            dbHelper.BeginTrans();//开启事务
            dbHelper.ExecuteNonQueryInTrans(delServicePersonRole, parametersList);
            dbHelper.ExecuteNonQueryInTrans(delServicePerson, parametersList);
            dbHelper.ExecuteNonQueryInTrans(delMessage, parametersList);
            isSuccess = dbHelper.ExecuteNonQueryInTrans(delStaff, parametersList) > 0;

            if (isSuccess)
            {
                dbHelper.CommitTrans();//事务提交
            }
            else
            {

                dbHelper.RollBack();//事务回滚
            }

            return isSuccess;
        }

        /// <summary>
        /// 更新推送状态(待删除)
        /// </summary>
        /// <param name="id">人员id</param>
        /// <param name="isPushVoice">是否推送语音</param>
        /// <returns></returns>
        public bool UpdatePushState(string id, bool isPushVoice)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Staff
                              Set  [IsPushVoice]=@IsPushVoice 
                                  Where ID=@ID";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", id));
            parametersList.Add(new SqlParameter("@IsPushVoice", isPushVoice));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 更改推送信息(待删除)
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="isReceivePush">是否推送信息</param>
        /// <returns></returns>
        public bool UpdatePushReceive(string id, bool isReceivePush)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            string strSql = @"Update Staff
                              Set  [IsReceivePush]=@IsReceivePush 
                                  Where ID=@ID";

            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@ID", id));
            parametersList.Add(new SqlParameter("@IsReceivePush", isReceivePush));

            return dbHelper.ExecuteNonQuery(strSql, parametersList) > 0;
        }

        /// <summary>
        /// 设置管理员(待删除)
        /// </summary>
        /// <param name="organizaionId">组织id</param>
        /// <param name="adminId">管理员id</param>
        /// <returns></returns>
        public bool UpdateAdmin(string organizaionId, string adminId)
        {
            DBHelper dbHelper = new DBHelper(ConnectionString, DbProviderType.SqlServer);
            dbHelper.BeginTrans();
            string strSql = "Update [Staff] set IsAdmin=1 where OrganizationID=@OrganizationID and ID=@ID";
            List<DbParameter> parametersList = new List<DbParameter>();
            parametersList.Add(new SqlParameter("@OrganizationID", organizaionId));
            parametersList.Add(new SqlParameter("@ID", adminId));
            bool isSuccessed = dbHelper.ExecuteNonQueryInTrans(strSql, parametersList) > 0;
            if (isSuccessed)
            {
                string strSqls = "Update [Staff] set IsAdmin=0 where OrganizationID=@OrganizationID and ID<>@ID";
                isSuccessed = dbHelper.ExecuteNonQueryInTrans(strSqls, parametersList) > 0;
            }
            if (isSuccessed)
            {
                dbHelper.CommitTrans();
            }
            else
            {
                dbHelper.RollBack();
            }
            return isSuccessed;
        }

        #endregion
    }
}
