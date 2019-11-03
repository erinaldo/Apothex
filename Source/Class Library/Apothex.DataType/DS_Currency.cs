namespace Apothex.DataType
{
    public partial class DS_Currency
    {
    }
}

namespace Apothex.DataType.DS_CurrencyTableAdapters
{

    public partial class SP_GetCurrencyTableAdapter
    {
        public static SP_GetCurrencyTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetCurrencyTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}
