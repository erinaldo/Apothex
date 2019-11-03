using System;
using Apothex.DataType;

namespace Apothex.Contracts.User
{
    interface IUser
    {
        DS_User.SP_LogInDataTable LogIn(string username, string passwordHash);
        DS_User.SP_GetUserDataTable GetUser(int? userID);
        bool IsValidUserName(int? id, string userName);
        int Save(int? id, int? branchID, string userName, string passwordHash, int? personID, int? modifierID);

        DS_User.SP_GetUserGroupDataTable GetUserGroup(int? userGroupID);
        bool IsValidUserGroupName(int? userGroupID, string name);
        int AddOrEditUserGroup(int? userGroupID, string name, int? status, int? modifiedUserID, DateTime modifiedDate, int? approverUserID, int? action);

        DS_User.SP_GetUserInGroupDataTable GetUserInGroup(int? userID, int? userGroupID);
        int AddOrEditUserInGroup(int? userID, int? userGroupID, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b);

        DS_User.SP_GetUserGroupPermissionDataTable GetUserGroupPermission(int? userGroupID);
        int AddOrEditUserGroupPermission(int? userGroupID, int? objectID, int? logical, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b);

        DS_User.SP_GetUserPermissionDataTable GetUserPermission(int? userID);
    }
}
