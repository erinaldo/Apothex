namespace Apothex.DataType
{
    public partial class DS_RealIncomeExpence
    {
    }
}

namespace Apothex.DataType.DS_RealIncomeExpenceTableAdapters
{
    public partial class SP_GetRealIncomeExpenceTableAdapter
    {
        public static SP_GetRealIncomeExpenceTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetRealIncomeExpenceTableAdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (var cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }
}
