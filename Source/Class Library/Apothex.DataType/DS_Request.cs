using System.Data.SqlClient;

namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_RequestTableAdapters
{
    public partial class SP_GetRequestHeaderTableAdapter
    {
        public static SP_GetRequestHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetRequestHeaderTableAdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (var cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }

    public partial class SP_GetRequestDetailTableAdapter
    {
        public static SP_GetRequestDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetRequestDetailTableAdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (var cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }

    public partial class RequestQueriesAdapter
    {
        public static RequestQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new RequestQueriesAdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (SqlCommand cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }
}namespace Apothex.DataType {
    
    
    public partial class DS_Request {
    }
}
