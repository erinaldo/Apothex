using System;
using Apothex.DataType;

namespace Apothex.Contracts.User
{
    public abstract class UserProvider : IUser
    {
        public abstract DS_User.SP_LogInDataTable LogIn(string username, string passwordHash);
        public abstract DS_User.SP_GetUserDataTable GetUser(int? userID);
        public abstract bool IsValidUserName(int? id, string userName);
        public abstract int Save(int? id, int? branchID, string userName, string passwordHash, int? personID, int? modifierID);


        public abstract DS_User.SP_GetUserGroupDataTable GetUserGroup(int? userGroupID);
        public abstract bool IsValidUserGroupName(int? userGroupID, string name);
        public abstract int AddOrEditUserGroup(int? userGroupID, string name, int? status, int? modifiedUserID, DateTime modifiedDate, int? approverUserID, int? action);

        public abstract DS_User.SP_GetUserInGroupDataTable GetUserInGroup(int? userID, int? userGroupID);
        public abstract int AddOrEditUserInGroup(int? userID, int? userGroupID, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b);

        public abstract DS_User.SP_GetUserGroupPermissionDataTable GetUserGroupPermission(int? userGroupID);
        public abstract int AddOrEditUserGroupPermission(int? userGroupID, int? objectID, int? logical, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b);
        
        public abstract DS_User.SP_GetUserPermissionDataTable GetUserPermission(int? userID);
    }
}
