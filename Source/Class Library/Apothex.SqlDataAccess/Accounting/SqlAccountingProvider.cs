using Apothex.Contracts.Accounting;
using Apothex.DataType.DS_AccountingTableAdapters;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.Accounting
{
    public sealed class SqlAccountingProvider : AccountingProvider
    {
        public override string GetAutoNumber(string name, int? year, int? branchID)
        {
            using (var adapter = AccountingQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (string)adapter.SP_T_AutoNumber_Get(name, year, branchID, false);
            }
        }
    }
}
