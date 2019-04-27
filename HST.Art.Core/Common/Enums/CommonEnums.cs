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
        //女
        Female = 0,

        //男
        Male = 1
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
        [Description("Telephone1")]
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


    public enum SectionType
    {
        UnKnown,
        /// <summary>
        /// 行业资讯
        /// </summary>
        [Description("行业资讯")]
        Industry,
        /// <summary>
        /// 协会活动
        /// </summary>
        [Description("协会活动")]
        Association,
        /// <summary>
        /// 考级中心
        /// </summary>
        [Description("考级中心")]
        Examination,
        /// <summary>
        /// 社会公益
        /// </summary>
        [Description("社会公益")]
        Social
    }

    /// <summary>
    /// 证书类型
    /// </summary>
    public enum CertificateType
    {
        /// <summary>
        /// 未知
        /// </summary>
        UnKnown,
        /// <summary>
        /// 获奖
        /// </summary>
        [Description("获奖证书")]
        Prize,
        /// <summary>
        /// 培训
        /// </summary>
        [Description("培训证书")]
        Train
    }
}
