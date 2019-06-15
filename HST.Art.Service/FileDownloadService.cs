/*----------------------------------------------------------------
// 文件名：FileDownloadService.cs
// 功能描述：文件下载服务
// 创建者：sysmenu
// 创建时间：2019-4-18
//----------------------------------------------------------------*/
using HST.Art.Core;
using System.Collections.Generic;
using System.Linq;
using HST.Art.Data;
using System.Text.RegularExpressions;

namespace HST.Art.Service
{
    public class FileDownloadService : ServiceBase, IFileDownloadService
    {
        FileDownloadProvider _fileDownloadProvider = new FileDownloadProvider();

        public FileDownload Get(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            FileDownload fileDownloadInfo = _fileDownloadProvider.Get(id);
            return fileDownloadInfo;
        }

        public List<FileDownload> GetAll(FilterEntityModel filterModel = null)
        {
            if (filterModel != null) filterModel.FillWhereTbAsName(Constant.FILE_DOWNLOAD_AS_NAME);//筛选器添加表别名
            List<FileDownload> fileDownloadList = _fileDownloadProvider.GetAll(filterModel);
            return fileDownloadList;
        }

        public List<FileDownload> GetPage(FilterEntityModel filterModel, out int totalNum)
        {
            totalNum = 0;
            //参数验证
            if (filterModel == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            filterModel.FillWhereTbAsName(Constant.FILE_DOWNLOAD_AS_NAME);//筛选器添加表别名
            //获取数据
            List<FileDownload> fileDownloadList = _fileDownloadProvider.GetPage(filterModel, out totalNum);

            return fileDownloadList;
        }

        public bool Add(FileDownload fileDownloadInfo)
        {
            //参数验证
            if (fileDownloadInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }
            DisposeMember(fileDownloadInfo);
            return _fileDownloadProvider.Add(fileDownloadInfo);
        }

        public bool Delete(int id)
        {
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _fileDownloadProvider.Delete(id);
        }

        public bool LogicDelete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _fileDownloadProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "IsDeleted",
                Value = 1,
                TableName = "FileDownload"
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

            return _fileDownloadProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Upper,
                TableName = "FileDownload"
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

            return _fileDownloadProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = (int)PublishState.Lower,
                TableName = "FileDownload"
            });
        }

        public bool Update(FileDownload fileDownloadInfo)
        {
            //参数验证
            if (fileDownloadInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }
            DisposeMember(fileDownloadInfo);
            return _fileDownloadProvider.Update(fileDownloadInfo);
        }

        /// <summary>
        /// 处理（简介）
        /// </summary>
        private void DisposeMember(FileDownload fileModel)
        {
            if (fileModel == null) return;
            if (string.IsNullOrWhiteSpace(fileModel.Description)) return;
            if (!string.IsNullOrWhiteSpace(fileModel.Synopsis)) return;
            fileModel.Synopsis = GetLength(Regex.Replace(fileModel.Description, "<[^>]+>", "", RegexOptions.Singleline), 40);
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
