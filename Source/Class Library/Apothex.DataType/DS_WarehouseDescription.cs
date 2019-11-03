
using System.Data.SqlClient;

namespace Apothex.DataType.DS_WarehouseDescriptionTableAdapters
{
    partial class SP_GetWarehouseDescriptionDetailTableAdapter
    {
        public static SP_GetWarehouseDescriptionDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetWarehouseDescriptionDetailTableAdapter();
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
    public partial class SP_GetWarehouseDescriptionHeaderTableAdapter
    {
        public static SP_GetWarehouseDescriptionHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetWarehouseDescriptionHeaderTableAdapter();
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

    public partial class WarehouseDescriptionQueriesAdapter
    {
        public static WarehouseDescriptionQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new WarehouseDescriptionQueriesAdapter();
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
}
namespace Apothex.DataType {
    
    
    public partial class DS_WarehouseDescription {
    }
}
