using Zek.Data;

namespace Apothex.DataType.DS_CardPointTransferTableAdapters
{
    partial class VW_PointTransferDetailTableAdapter
    {
        public static VW_PointTransferDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_PointTransferDetailTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class T_PointTransferHeaderTableAdapter
    {
        public static T_PointTransferHeaderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_PointTransferHeaderTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }


    public partial class CardPointTransferQueriesAdapter
    {
        public static CardPointTransferQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new CardPointTransferQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}

namespace Apothex.DataType {
    
    
    public partial class DS_CardPointTransfer {
    }
}
