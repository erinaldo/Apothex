using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_CashboxTableAdapters
{
    partial class CashboxQueriesAdapter
    {
        public static CashboxQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new CashboxQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class T_CashboxOrderTableAdapter
    {
        public static T_CashboxOrderTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_CashboxOrderTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}namespace Apothex.DataType {
    
    
    public partial class DS_Cashbox {
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_Cashbox {
    }
}
