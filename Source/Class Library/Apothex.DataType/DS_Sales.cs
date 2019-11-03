using System.Data.SqlClient;

namespace Apothex.DataType.DS_SalesTableAdapters
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_SalesTableAdapters
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_SalesTableAdapters
{
    public partial class SP_GetSalesOrderHeaderTableAdapter
    {
        public static SP_GetSalesOrderHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSalesOrderHeaderTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetSalesOrderDetailTableAdapter
    {
        public static SP_GetSalesOrderDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSalesOrderDetailTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetRptSalesOrderHeaderTableAdapter
    {
        public static SP_GetRptSalesOrderHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetRptSalesOrderHeaderTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SalesQueriesAdapter
    {
        public static SalesQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SalesQueriesAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (SqlCommand cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}namespace Apothex.DataType {
    
    
    public partial class DS_Sales {
    }
}
