using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HST.Art.Core
{
    public class FilterEntityModel
    {
        private FilterType _filterType;
        private string _where = "";
        private string _orderBy = "";
        private int _pageIndex = 1;
        private int _pageSize = 10;
        private Dictionary<string, object> _sqlParList = new Dictionary<string, object>();
        public List<KeyValueObj> keyValueList { get; set; }
        public KeyValuePair<string, SortType> SortDict { get; set; }
        public KeyValuePair<string, SortType> ThenDict { get; set; }

        /// <summary>
        /// 筛选器
        /// </summary>
        public FilterType FilterType
        {
            get
            {
                return _filterType;
            }

            set
            {
                _filterType = value;
            }
        }
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex
        {
            get
            {
                return _pageIndex;
            }

            set
            {
                _pageIndex = value;
            }
        }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize
        {
            get
            {
                return _pageSize;
            }

            set
            {
                _pageSize = value;
            }
        }
        public Dictionary<string, object> SqlParList
        {
            get
            {
                return _sqlParList;
            }
        }
        /// <summary>
        /// Where 条件
        /// </summary>
        public string Where
        {
            get
            {
                if (keyValueList != null && keyValueList.Count > 0)
                {
                    StringBuilder sBuilder = new StringBuilder();

                    foreach (KeyValueObj item in keyValueList)
                    {
                        ConvertKeyValueObj(item);
                        sBuilder.Append(GetWhereItemStr(item));
                    }

                    return sBuilder.ToString();
                }

                return _where;
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        public string OrderBy
        {
            get
            {
                if (!string.IsNullOrEmpty(SortDict.Key))
                {
                    _orderBy = string.Format(" order by {0} {1}", SortDict.Key, SortDict.Value.ToString());
                    if (!string.IsNullOrEmpty(ThenDict.Key))
                    {
                        _orderBy += string.Format(" ,{0} {1}", ThenDict.Key, ThenDict.Value.ToString());
                    }
                }
                else
                {
                    _orderBy = " order by Id asc";
                }

                return _orderBy;
            }

        }

        private void ConvertKeyValueObj(KeyValueObj item)
        {
            if (item == null) return;
            if (item.IsList && _filterType != FilterType.In)
                throw new Exception("In-filter type is required when a object value is a collection");

            if (item.IsList && item.FieldType == FieldType.String)
            {
                List<string> objList = item.Value as List<string>;
                item.Value = objList.Select(g => g = string.Format("'{0}'", g)).ToList();
            }
        }

        private string GetWhereItemStr(KeyValueObj item)
        {
            StringBuilder sBuilder = new StringBuilder();

            switch (_filterType)
            {
                case FilterType.And:
                    sBuilder.Append(string.Format(" and {2}{0}=@{1} ", item.Key, item.Key, item.TbAsName));
                    _sqlParList.Add(string.Format("@{0}", item.Key), item.Value);
                    break;
                case FilterType.Or:
                    sBuilder.Append(string.Format(" or {2}{0}=@{1} ", item.Key, item.Key, item.TbAsName));
                    _sqlParList.Add(string.Format("@{0}", item.Key), item.Value);
                    break;
                case FilterType.In:
                    if (item.IsList)
                    {
                        sBuilder.Append(string.Format(" and {2}{0} in ({1}) ", item.Key, string.Join(",", (List<string>)item.Value), item.TbAsName));
                    }
                    else
                    {
                        sBuilder.Append(string.Format(" and {2}{0}=@{1} ", item.Key, item.Key, item.TbAsName));
                        _sqlParList.Add(string.Format("@{0}", item.Key), item.Value);
                    }
                    break;
                case FilterType.Like:
                    sBuilder.Append(string.Format(" and {2}{0} like '%{1}%' ", item.Key, item.Value.ToString(), item.TbAsName));
                    break;
                case FilterType.Neq:
                    sBuilder.Append(string.Format(" and {2}{0} <> @{1} ", item.Key, item.Key, item.TbAsName));
                    _sqlParList.Add(string.Format("@{0}", item.Key), item.Value);
                    break;
                default:
                    break;
            }

            return sBuilder.ToString();
        }








    }
}
