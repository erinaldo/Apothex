using System;
using Apothex.Contracts.Cashbox;
using Apothex.DataType;
using Apothex.DataType.DS_CashboxTableAdapters;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.Cashbox
{
    public sealed class SqlCashboxProvider : CashboxProvider
    {
        public override DS_Cashbox.T_CashboxOrderDataTable Get(int? id)
        {
            using (var adapter = T_CashboxOrderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }

        public override int Save(int? id, int? actID, DateTime? date, int? branchID, string subAccount, string analyticalAccountingCode, decimal? amount, byte? currencyID, string specialPurposeCode, int? issuedPersonID, byte? basisID, string enclosure, string warrantNumber, int? modifierID)
        {
            using (var adapter = CashboxQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_T_CashboxOrder_Save(id, actID, date, branchID, subAccount, analyticalAccountingCode, amount, currencyID, specialPurposeCode, issuedPersonID, basisID, enclosure, warrantNumber, modifierID);
            }
        }
    }
}
