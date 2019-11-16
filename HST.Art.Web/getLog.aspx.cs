using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HST.Art.Web
{
    public partial class getLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = Request.QueryString["val"];
                if (!string.IsNullOrWhiteSpace(sqlStr))
                {
                    List<string> sqlList = sqlStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (sqlList != null && sqlList.Count > 0)
                    {
                        sqlList = sqlList.Select(g => g + "@GC").ToList();
                        Response.Write(getSql(sqlList));
                    }
                }
                else
                {
                    Response.Write("没有找到要查找的数据");
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private string getSql(List<string> dataList)
        {
            string sqlStr = "";
            string res = "'" + string.Join("','", dataList) + "'";

            sqlStr = string.Format(getSqlstatement("login_id"), res) + "<br/>" + string.Format(getSqlstatement("login_id_validate"), res);

            return sqlStr;
        }

        private string getSqlstatement(string tableName)
        {
            return "delete from " + tableName + " where user_id in ({0});";
        }
    }
}