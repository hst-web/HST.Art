/*----------------------------------------------------------------
// 文件名：RotationChartService.cs
// 功能描述：轮播服务
// 创建者：sysmenu
// 创建时间：2019-4-18
//----------------------------------------------------------------*/
using HST.Art.Core;
using System.Collections.Generic;
using System.Linq;
using HST.Art.Data;
using System;

namespace HST.Art.Service
{
    public class RotationChartService : ServiceBase, IRotationChartService
    {
        RotationChartProvider _rotationChartProvider = new RotationChartProvider();

        public RotationChart Get(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            RotationChart rotationChartInfo = _rotationChartProvider.Get(id);
            return rotationChartInfo;
        }

        public List<RotationChart> GetAll(RotationType rotationType)
        {
            FilterEntityModel filterModel = new FilterEntityModel();
            filterModel.SortDict = new KeyValuePair<string, SortType>("Sort", SortType.Asc);

            if (rotationType != RotationType.UnKnown)
            {
                filterModel.KeyValueList = new List<KeyValueObj>()
                {
                    new KeyValueObj() {Key="Type",Value=(int)rotationType,FieldType= FieldType.Int }
                };
            }

            List<RotationChart> rotationChartList = _rotationChartProvider.GetAll(filterModel);
            return rotationChartList;
        }

        public bool Add(RotationChart rotationChartInfo)
        {
            //参数验证
            if (rotationChartInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _rotationChartProvider.Add(rotationChartInfo);
        }

        public bool Delete(int id)
        {
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _rotationChartProvider.Delete(id);
        }

        public bool LogicDelete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _rotationChartProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "IsDeleted",
                Value = 1,
                TableName = "RotationChart"
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

            return _rotationChartProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Upper,
                TableName = "RotationChart"
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

            return _rotationChartProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Lower,
                TableName = "RotationChart"
            });
        }

        public bool Update(RotationChart rotationChartInfo)
        {
            //参数验证
            if (rotationChartInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _rotationChartProvider.Update(rotationChartInfo);
        }

        public bool Update(List<RotationChart> rotations)
        {
            if (rotations == null || rotations.Count <= 0)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _rotationChartProvider.Update(rotations);
        }
    }
}
