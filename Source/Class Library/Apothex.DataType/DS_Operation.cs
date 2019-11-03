using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_OperationTableAdapters
{
    partial class OperationQueriesAdapter
    {
        public static OperationQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new OperationQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class T_OperationTableAdapter
    {
        public static T_OperationTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_OperationTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }


}