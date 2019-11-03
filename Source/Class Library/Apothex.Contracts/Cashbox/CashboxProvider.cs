using System;
using Apothex.DataType;

namespace Apothex.Contracts.Cashbox
{
    public abstract class CashboxProvider : ICashbox
    {
        public abstract DS_Cashbox.T_CashboxOrderDataTable Get(int? id);
        public abstract int Save(int? id, int? actID, DateTime? date, int? branchID, string subAccount, string analyticalAccountingCode, decimal? amount, byte? currencyID, string specialPurposeCode, int? issuedPersonID, byte? basisID, string enclosure, string warrantNumber, int? modifierID);
    }
}
