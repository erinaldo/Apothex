using System.ComponentModel;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_HedgehogTableAdapters
{
    public partial class SP_GetSalesHedgehogTableAdapter : Component
    {
        public static SP_GetSalesHedgehogTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            if (string.IsNullOrEmpty(connectionString)) return new SP_GetSalesHedgehogTableAdapter();

            var adapter = new SP_GetSalesHedgehogTableAdapter();
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}
