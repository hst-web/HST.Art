﻿using HST.Art.Core;
using System;
using System.Collections.Generic;
/*----------------------------------------------------------------
// 文件名：MemberUnitService.cs
// 功能描述：会员单位服务
// 创建者：sysmenu
// 创建时间：2019-4-18
//----------------------------------------------------------------*/
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HST.Art.Data;

namespace HST.Art.Service
{
    public class MemberUnitService : ServiceBase, IMemberUnitService
    {
        MemberUnitProvider _memberUnitProvider = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public MemberUnitService(MemberUnitProvider memberUnitProvider)
        {
            _memberUnitProvider = memberUnitProvider;
            AddDisposableObject(memberUnitProvider);
        }

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
            //获取数据
            List<MemberUnit> memberUnitList = _memberUnitProvider.GetPage(filterModel, out totalNum);

            return memberUnitList;
        }

        public bool Add(MemberUnit MemberUnitInfo)
        {
            //参数验证
            if (MemberUnitInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Add(MemberUnitInfo);
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

        public bool Update(MemberUnit MemberUnitInfo)
        {
            //参数验证
            if (MemberUnitInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _memberUnitProvider.Update(MemberUnitInfo);
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
                keyValueList = new List<KeyValueObj>() { new KeyValueObj() { Key = "Number", Value = number, TbAsName = Constant.MEMBER_UNIT_AS_NAME } }
            };

            List<MemberUnit> memberUnitList = _memberUnitProvider.GetAll(filterModel);
            if (memberUnitList!=null&&memberUnitList.Count>0)
            {
                return memberUnitList.FirstOrDefault();
            }

            return null;
        }
    }
}