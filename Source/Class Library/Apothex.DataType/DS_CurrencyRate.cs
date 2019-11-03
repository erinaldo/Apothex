namespace Apothex.DataType {
    
    
    public partial class DS_CurrencyRate {
    }
}

namespace Apothex.DataType.DS_CurrencyRateTableAdapters {

    public partial class SP_GetCurrencyRateTableAdapter
    {
        public static SP_GetCurrencyRateTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetCurrencyRateTableAdapter();
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
