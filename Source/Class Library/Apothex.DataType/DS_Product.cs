using System.Data.SqlClient;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_ProductTableAdapters
{
    public partial class SP_GetProductTableAdapter
    {
        public static SP_GetProductTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetProductTableAdapter();
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


    public partial class ProductQueriesAdapter
    {
        public static ProductQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new ProductQueriesAdapter();
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
    
    
    public partial class DS_Product {
    }
}
