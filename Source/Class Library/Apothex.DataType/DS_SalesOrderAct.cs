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
namespace Apothex.DataType.DS_SalesOrderActTableAdapters
{
    public partial class SalesOrderActQueriesAdapter
    {
        public static SalesOrderActQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SalesOrderActQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class VW_SalesOrderActTableAdapter
    {
        public static VW_SalesOrderActTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_SalesOrderActTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    } 
    
    partial class VW_SalesOrderActDetailTableAdapter
    {
        public static VW_SalesOrderActDetailTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_SalesOrderActDetailTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_SalesOrderAct {
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_SalesOrderAct {
    }
}
