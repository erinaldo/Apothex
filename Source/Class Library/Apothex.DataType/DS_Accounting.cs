using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_AccountingTableAdapters
{
    partial class AccountingQueriesAdapter
    {
        public static AccountingQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new AccountingQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
