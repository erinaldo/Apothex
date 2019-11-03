using Zek.Data;

namespace Apothex.DataType.DS_BranchTableAdapters
{
    public partial class BranchQueriesAdapter
    {
        public static BranchQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new BranchQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class DD_BranchTableAdapter
    {
        public static DD_BranchTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_BranchTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_Branch {
        partial class DD_BranchDataTable
        {
        }
    }
}
