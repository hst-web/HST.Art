using System.ComponentModel;

namespace HST.Art.Core
{
    public class CommonEnums
    {
    }

    /// <summary>
    /// 错误码
    /// </summary>
    public enum ErrorCode
    {
        //未知
        UnKnown = 0,

        //不允许修改
        NotUpdate = 1,

        //错误的请求
        ErrorReqrest = 400,

        //未授权
        Unauthorized = 401,

        //文件不存在
        NoFile = 404,

        //服务器错误
        ServerError = 500,

        //参数为空
        ParameterNull = 501
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum Gender
    {
        //未知
        UnKnown = 0,

        //男
        Male = 1,

        //女
        Female = 2
    }

    /// <summary>
    /// 文件类型
    /// </summary>
    public enum FileType
    {
        //未知
        UnKnown = 0,
        //文件夹
        Folder = 1,
        //文档
        Document = 2,
        //图片
        Picture = 3
    }

    /// <summary>
    /// 统计类型
    /// </summary>
    public enum StatisticType
    {
        //未知
        UnKnown = 0,
        //按日期
        Date = 1,
        //按周
        Week = 2,
        //按月
        Month = 3,
        //按年
        Year = 4,
        //按小时
        Hour = 5,
        //按分钟
        Minute = 6
    }

    public enum PublishState
    {
        /// <summary>
        /// 下架
        /// </summary>
        Lower,
        /// <summary>
        /// 上架
        /// </summary>
        Upper
    }

    public enum LoginType
    {
        [Description("UserName")]
        UserName,
        [Description("Telephone")]
        Telephone,
        [Description("Email")]
        Email
    }

    public enum FieldType
    {
        String,
        Int
    }

    public enum FilterType
    {
        And,
        Or,
        In,
        Like,
        Neq
    }

    public enum SortType
    {
        Asc,
        Desc
    }
}
