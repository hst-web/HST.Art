/*----------------------------------------------------------------
// 文件名：CategoryDictionary.cs
// 功能描述：类别字典
// 创建者：sysmenu
// 创建时间：2019-4-14
//----------------------------------------------------------------*/
using System;
namespace HST.Art.Core
{
    /// <summary>
    /// CategoryDictionary
    /// </summary>
    [Serializable]
    public partial class CategoryDictionary
    {
        public CategoryDictionary()
        { }
        #region Model
        private int _id;
        private int _userid;
        private int _parent;
        private string _name;
        private int _state;
        private DateTime _createdate = DateTime.Now;
        private bool _isdeleted = false;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Parent
        {
            set { _parent = value; }
            get { return _parent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 0:下架
        /// 1:上架
        /// </summary>
        public int State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDeleted
        {
            set { _isdeleted = value; }
            get { return _isdeleted; }
        }

        /// <summary>
        /// 类别类型
        /// </summary>
        private CategoryType Type { get; set; }
        #endregion Model

    }
}

