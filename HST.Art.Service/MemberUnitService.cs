/*----------------------------------------------------------------
// 文件名：MemberUnitService.cs
// 功能描述：会员单位服务
// 创建者：sysmenu
// 创建时间：2019-4-18
//----------------------------------------------------------------*/
using HST.Art.Core;
using System.Collections.Generic;
using System.Linq;
using HST.Art.Data;
using System;
using System.Text.RegularExpressions;

namespace HST.Art.Service
{
    public class MemberUnitService : ServiceBase, IMemberUnitService
    {
        MemberUnitProvider _memberUnitProvider = new MemberUnitProvider();

        public MemberUnit Get(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            MemberUnit memberUnitInfo = _memberUnitProvider.Get(id);
            return memberUnitInfo;
        }

        public List<MemberUnit> GetAll(FilterEntityModel filterModel = null)
        {
            if (filterModel != null) filterModel.FillWhereTbAsName(Constant.MEMBER_UNIT_AS_NAME);//筛选器添加表别名
            List<MemberUnit> memberUnitList = _memberUnitProvider.GetAll(filterModel);
            return memberUnitList;
        }

        public List<MemberUnit> GetPage(FilterEntityModel filterModel, out int totalNum)
        {
            totalNum = 0;
            //参数验证
            if (filterModel == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            filterModel.FillWhereTbAsName(Constant.MEMBER_UNIT_AS_NAME);//筛选器添加表别名
            //获取数据
            List<MemberUnit> memberUnitList = _memberUnitProvider.GetPage(filterModel, out totalNum);

            return memberUnitList;
        }

        public bool Add(MemberUnit memberUnitInfo)
        {
            //参数验证
            if (memberUnitInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }
            DisposeMember(memberUnitInfo);
            return _memberUnitProvider.Add(memberUnitInfo);
        }

        public bool Delete(int id)
        {
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Delete(id);
        }

        public bool LogicDelete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "IsDeleted",
                Value = 1,
                TableName = "MemberUnit"
            });
        }

        public bool Publish(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Upper,
                TableName = "MemberUnit"
            });
        }

        public bool Recovery(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Lower,
                TableName = "MemberUnit"
            });
        }

        public bool Update(MemberUnit memberUnitInfo)
        {
            //参数验证
            if (memberUnitInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }
            DisposeMember(memberUnitInfo);
            return _memberUnitProvider.Update(memberUnitInfo);
        }

        public MemberUnit GetByNumber(string number)
        {
            //参数验证
            if (string.IsNullOrEmpty(number))
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            FilterEntityModel filterModel = new FilterEntityModel()
            {
                KeyValueList = new List<KeyValueObj>() { new KeyValueObj() { Key = "Number", Value = number, TbAsName = Constant.MEMBER_UNIT_AS_NAME } }
            };

            List<MemberUnit> memberUnitList = _memberUnitProvider.GetAll(filterModel);
            if (memberUnitList != null && memberUnitList.Count > 0)
            {
                return memberUnitList.FirstOrDefault();
            }

            return null;
        }

        public bool Add(List<MemberUnit> memberUnitInfos, out List<MemberUnit> failList)
        {
            if (memberUnitInfos == null || memberUnitInfos.Count <= 0)
            {
                failList = null;
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Add(memberUnitInfos, out failList);
        }

        /// <summary>
        /// 处理（简介）
        /// </summary>
        private void DisposeMember(MemberUnit  unitModel)
        {
            if (unitModel == null) return;
            if (string.IsNullOrWhiteSpace(unitModel.Description)) return;
            if (!string.IsNullOrWhiteSpace(unitModel.Synopsis)) return;
            unitModel.Synopsis = GetLength(Regex.Replace(unitModel.Description, "<[^>]+>", "", RegexOptions.Singleline), 40);
        }

        /// <summary>
        /// 获取设定长度的字符串
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="length">截取长度</param>
        /// <returns></returns>
        private string GetLength(string str, int length)
        {
            if (string.IsNullOrWhiteSpace(str)) return string.Empty;
            string strR = str;
            if (str.Length > length)
            {
                strR = str.Substring(0, length).TrimEnd(',');
            }
            return strR;
        }
    }
}
