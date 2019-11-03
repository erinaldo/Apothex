using System;
using Apothex.DataType;
using Apothex.DataType.DS_UserTableAdapters;
using Apothex.Contracts.User;
using Zek.Data;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.User
{
    public sealed class SqlUserProvider : UserProvider
    {
        public override DS_User.SP_LogInDataTable LogIn(string username, string passwordHash)
        {
            using (var adapter = SP_LogInTableAdapter.CreateInstance(ConfigurationManagerEx.DynamicConnectionString, ConfigurationManagerEx.DynamicCommandTimeout))
            {
                return adapter.GetData(username, passwordHash);
            }
        }
        public override DS_User.SP_GetUserDataTable GetUser(int? id)
        {
            using (var adapter = SP_GetUserTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override bool IsValidUserName(int? id, string userName)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_T_Users_IsValidUserName(id, userName);
            }
        }
        public override int Save(int? id, int? branchID, string userName, string passwordHash, int? personID, int? modifierID)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_T_Users_Save(id, branchID, userName, passwordHash, personID, modifierID);
            }
        }

        public override DS_User.SP_GetUserGroupDataTable GetUserGroup(int? userGroupID)
        {
            using (var adapter = SP_GetUserGroupTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(userGroupID);
            }
        }
        public override bool IsValidUserGroupName(int? userGroupID, string name)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidUserGroupName(userGroupID, name);
            }
        }
        public override int AddOrEditUserGroup(int? userGroupID, string name, int? status, int? modifiedUserID, DateTime modifiedDate, int? approverUserID, int? action)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditUserGroup(userGroupID, name, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_User.SP_GetUserInGroupDataTable GetUserInGroup(int? userID, int? userGroupID)
        {
            using (var adapter = SP_GetUserInGroupTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(userID, userGroupID);
            }
        }
        public override int AddOrEditUserInGroup(int? userID, int? userGroupID, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditUserInGroup(userID, userGroupID, modifiedUserID, modifiedDate, action, b.GetXmlData());
            }
        }

        public override DS_User.SP_GetUserGroupPermissionDataTable GetUserGroupPermission(int? userGroupID)
        {
            using (var adapter = SP_GetUserGroupPermissionTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(userGroupID);
            }
        }
        public override int AddOrEditUserGroupPermission(int? userGroupID, int? objectID, int? logical, int? modifiedUserID, DateTime modifiedDate, int? action, byte[] b)
        {
            using (var adapter = UserQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditUserGroupPermission(userGroupID, objectID, logical, modifiedUserID, modifiedDate, action, b.GetXmlData());
            }
        }

        public override DS_User.SP_GetUserPermissionDataTable GetUserPermission(int? userID)
        {
            using (var adapter = SP_GetUserPermissionTableAdapter.CreateInstance(ConfigurationManagerEx.DynamicConnectionString, ConfigurationManagerEx.DynamicCommandTimeout))
            {
                return adapter.GetData(userID);
            }
        }
    }
}
