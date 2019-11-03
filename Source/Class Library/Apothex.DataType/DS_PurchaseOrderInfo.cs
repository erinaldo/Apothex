using Zek.Data;

namespace Apothex.DataType
{
    public partial class DS_PurchaseOrderInfo
    {
    }
}

namespace Apothex.DataType.DS_PurchaseOrderInfoTableAdapters
{
    public partial class SP_GetPurchaseOrderInfoTableAdapter
    {
        public static SP_GetPurchaseOrderInfoTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetPurchaseOrderInfoTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
