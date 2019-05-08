/*----------------------------------------------------------------
// 文件名：AccountService.cs
// 功能描述：账户服务
// 创建者：sysmenu
// 创建时间：2019-5-8
//----------------------------------------------------------------*/
using System.Collections.Generic;
using HST.Art.Core;
using HST.Utillity;
using HST.Art.Data;

namespace HST.Art.Service
{
    public class AccountService : ServiceBase
    {
        UserProvider _userProvider = new UserProvider();
        /// <summary>
        /// 获取根据条件获取所有会员集合
        /// </summary>
        /// <param name="filterModel">条件</param>
        /// <returns>会员集合</returns>
        public Account GetSingleMember(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                ErrorMsg = ErrorCode.ParameterNull;
                return null;
            }

            //数据获取
            User userInfo = _userProvider.GetByQuery(new UserQuery() { Key = GetLoginType(userName), Value = userName });


            if (userInfo == null) return null;
            string valPassword = EncryptHelper.Encode(password, userInfo.Salt);
            if (userInfo.Password.Equals(valPassword))
            {
                return new Account()
                {
                    Id = userInfo.Id,
                    UserName = userInfo.UserName,
                    IsAdmin = userInfo.IsAdmin
                };
            }

            return null;
        }

        private LoginType GetLoginType(string userName)
        {
            if (ValidateHelper.IsMobile(userName))
            {
                return LoginType.Telephone;
            }

            if (ValidateHelper.IsEmail(userName))
            {
                return LoginType.Email;
            }

            return LoginType.UserName;
        }

    }
}
