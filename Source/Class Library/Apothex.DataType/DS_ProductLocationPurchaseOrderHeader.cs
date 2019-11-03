using Zek.Data;

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
namespace Apothex.DataType.DS_ProductLocationPurchaseOrderHeaderTableAdapters
{

    public partial class SP_GetProductLocationPurchaseOrderHeaderTableAdapter
    {
        public static SP_GetProductLocationPurchaseOrderHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetProductLocationPurchaseOrderHeaderTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
