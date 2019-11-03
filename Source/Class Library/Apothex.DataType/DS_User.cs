using System.ComponentModel;
using System.Data.SqlClient;

namespace Apothex.DataType.DS_UserTableAdapters
{
}
namespace Apothex.DataType.DS_UserTableAdapters
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_UserTableAdapters
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_UserTableAdapters
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_UserTableAdapters
{
    public partial class SP_LogInTableAdapter : Component
    {
        public static SP_LogInTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_LogInTableAdapter();

            var adapter = new SP_LogInTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class SP_GetUserTableAdapter : Component
    {
        public static SP_GetUserTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetUserTableAdapter();

            var adapter = new SP_GetUserTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class UserQueriesAdapter : Component
    {
        public static UserQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new UserQueriesAdapter();

            var adapter = new UserQueriesAdapter();
            foreach (SqlCommand cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetUserGroupTableAdapter : Component
    {
        public static SP_GetUserGroupTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetUserGroupTableAdapter();

            var adapter = new SP_GetUserGroupTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetUserInGroupTableAdapter : Component
    {
        public static SP_GetUserInGroupTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetUserInGroupTableAdapter();

            var adapter = new SP_GetUserInGroupTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class SP_GetUserGroupPermissionTableAdapter : Component
    {
        public static SP_GetUserGroupPermissionTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetUserGroupPermissionTableAdapter();

            var adapter = new SP_GetUserGroupPermissionTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetUserPermissionTableAdapter : Component
    {
        public static SP_GetUserPermissionTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetUserPermissionTableAdapter();

            var adapter = new SP_GetUserPermissionTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

}
namespace Apothex.DataType {
    
    
    public partial class DS_User {
    }
}
