/*----------------------------------------------------------------
// 文件名：CustomerService.cs
// 功能描述：客户服务
// 创建者：sysmenu
// 创建时间：2019-3-18
//----------------------------------------------------------------*/
using System.Collections.Generic;
using System.Linq;
using HST.Art.Core;
using System;
using HST.Utillity;
using HST.Art.Data;

namespace HST.Art.Service
{
    /// <summary>
    /// 客户服务
    /// </summary>
    public class UserService : ServiceBase, IUserService
    {
        UserProvider _userProvider = null;
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserService(UserProvider userProvider)
        {
            _userProvider = userProvider;
            AddDisposableObject(userProvider);
        }

        /// <summary>
        /// 获取根据条件获取所有会员集合
        /// </summary>
        /// <param name="filterModel">条件</param>
        /// <returns>客户集合</returns>
        public List<User> GetAll(FilterEntityModel filterModel = null)
        {
            List<User> userList = _userProvider.GetAll(filterModel);
            return userList;
        }

        /// <summary>
        /// 获取根据条件分页获取会员集合
        /// </summary>
        /// <param name="filterModel">条件</param>
        /// <param name="totalNum">总记录数</param>
        /// <returns>客户集合</returns>
        public List<User> GetPage(FilterEntityModel filterModel, out int totalNum)
        {
            totalNum = 0;
            //参数验证
            if (filterModel == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }
            //获取数据
            List<User> userList = _userProvider.GetPage(filterModel, out totalNum);

            return userList;
        }

        /// <summary>
        /// 根据手机号获取会员信息
        /// </summary>
        /// <param name="phoneNum">手机号</param>
        /// <returns>客户信息</returns>
        public User GetByPhone(string phoneNum)
        {
            //参数验证
            if (string.IsNullOrEmpty(phoneNum))
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            User userInfo = _userProvider.GetByQuery(new UserQuery() { Key = LoginType.Telephone, Value = phoneNum });
            return userInfo;
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public User Get(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            User userInfo = _userProvider.Get(id);
            return userInfo;
        }

        /// <summary>
        /// 通过用户名获取会员
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public User GetByUserName(string userName)
        {
            //参数验证
            if (string.IsNullOrEmpty(userName))
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            User userInfo = _userProvider.GetByQuery(new UserQuery() { Key = LoginType.UserName, Value = userName });
            return userInfo;
        }

        /// <summary>
        /// 通过邮箱获取会员
        /// </summary>
        /// <param name="Email">邮箱</param>
        /// <returns></returns>
        public User GetByEmail(string Email)
        {
            //参数验证
            if (string.IsNullOrEmpty(Email))
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            User userInfo = _userProvider.GetByQuery(new UserQuery() { Key = LoginType.Email, Value = Email });
            return userInfo;
        }

        /// <summary>
        /// 更新会员信息
        /// </summary>
        /// <param name="userInfo">会员实体</param>
        /// <returns></returns>
        public bool Update(User userInfo)
        {
            //参数验证
            if (userInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _userProvider.Update(userInfo);
        }

        /// <summary>
        /// 添加会员信息
        /// </summary>
        /// <param name="userInfo">会员实体</param>
        /// <returns></returns>
        public bool Add(User userInfo)
        {
            //参数验证
            if (userInfo == null)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _userProvider.Add(userInfo);
        }

        public bool UpdatePassword(int id, string password = "")
        {
            if (id < 0)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            User userInfo = _userProvider.Get(id);
            if (userInfo == null)
            {
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                string salt = RandomHelper.GetRandomString(8);
                password = string.IsNullOrEmpty(userInfo.Telephone) ? Constant.INIT_PASSWORD : userInfo.Telephone.Substring(userInfo.Telephone.Length - 6, 6);
                userInfo.Salt = salt;
            }

            userInfo.Password = DesHelper.Encrypt(password, userInfo.Salt);

            return _userProvider.Update(userInfo);
        }

        /// <summary>
        /// 删除会员信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _userProvider.Delete(id);
        }

        public bool Publish(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _userProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = 1,
                TableName = "User"
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

            return _userProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "State",
                Value = 0,
                TableName = "User"
            });
        }

        public bool LogicDelete(int id)
        {
            //参数验证
            if (id < 1)
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return false;
            }

            return _userProvider.Update(new FlagUpdHandle()
            {
                FieldType = FieldType.Int,
                Id = id,
                Key = "IsDeleted",
                Value = 1,
                TableName = "User"
            });
        }
    }
}