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
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_PurchasingTableAdapters
{
    public partial class SP_GetPurchaseOrderHeaderTableAdapter
    {
        public static SP_GetPurchaseOrderHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetPurchaseOrderHeaderTableAdapter();

            var adapter = new SP_GetPurchaseOrderHeaderTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetPurchaseOrderDetailTableAdapter
    {
        public static SP_GetPurchaseOrderDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetPurchaseOrderDetailTableAdapter();

            var adapter = new SP_GetPurchaseOrderDetailTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class PurchasingQueriesAdapter
    {
        public static PurchasingQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new PurchasingQueriesAdapter();

            var adapter = new PurchasingQueriesAdapter();
            foreach (SqlCommand cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}namespace Apothex.DataType {
    
    
    public partial class DS_Purchasing {
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_Purchasing {
    }
}
