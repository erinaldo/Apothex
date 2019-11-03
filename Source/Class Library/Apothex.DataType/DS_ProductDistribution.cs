using System.Data.SqlClient;

namespace Apothex.DataType.DS_ProductDistributionTableAdapters
{
    public partial class SP_GetProductDistributionHeaderTableAdapter
    {
        public static SP_GetProductDistributionHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetProductDistributionHeaderTableAdapter();
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

    public partial class SP_GetProductDistributionDetailTableAdapter
    {
        public static SP_GetProductDistributionDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetProductDistributionDetailTableAdapter();
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

    public partial class ProductDistributionQueriesAdapter
    {
        public static ProductDistributionQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new ProductDistributionQueriesAdapter();
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
    
    
    public partial class DS_ProductDistribution {
    }
}
