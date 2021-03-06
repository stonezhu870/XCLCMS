﻿using XCLCMS.Data.WebAPIEntity;

namespace XCLCMS.Lib.WebAPI
{
    /// <summary>
    /// 个人中心 API
    /// </summary>
    public static class UserCenterAPI
    {
        /// <summary>
        /// 修改用户基本信息
        /// </summary>
        public static APIResponseEntity<bool> UpdateUserInfo(APIRequestEntity<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.UserBaseInfoEntity> request)
        {
            return Library.Request<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.UserBaseInfoEntity, bool>(request, "UserCenter/UpdateUserInfo", false);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        public static APIResponseEntity<bool> UpdatePassword(APIRequestEntity<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.PasswordEntity> request)
        {
            return Library.Request<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.PasswordEntity, bool>(request, "UserCenter/UpdatePassword", false);
        }

        /// <summary>
        /// 修改商户资料
        /// </summary>
        public static APIResponseEntity<bool> UpdateMerchantInfo(APIRequestEntity<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.MerchantInfoEntity> request)
        {
            return Library.Request<XCLCMS.Data.WebAPIEntity.RequestEntity.UserCenter.MerchantInfoEntity, bool>(request, "UserCenter/UpdateMerchantInfo", false);
        }
    }
}