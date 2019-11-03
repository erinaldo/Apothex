using Zek.Data;

namespace Apothex.DataType
{
    public partial class DS_Configuration
    {
    }
}

namespace Apothex.DataType.DS_ConfigurationTableAdapters
{
    public partial class ConfigurationQueriesAdapter
    {
        public static ConfigurationQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new ConfigurationQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}
