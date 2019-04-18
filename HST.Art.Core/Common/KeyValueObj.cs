/*----------------------------------------------------------------
// 文件名：KeyValueObj.cs
// 功能描述： 键值对类
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/

using System.Collections.Generic;
using System.Data;

namespace HST.Art.Core
{
    /// <summary>
    /// key-value对象
    /// </summary>
    public class KeyValueObj
    {
        private string _key = "";
        public string Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }

        private object _value = "";
        public object Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        private List<string> _objList = new List<string>();
        public List<string> ObjList
        {
            get
            {
                return _objList;
            }

            set
            {
                _objList = value;
            }
        }

        /// <summary>
        /// 例外字段
        /// </summary>
        public bool Exception { set; get; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public SqlDbType FieldType { get; set; }
    }
}
