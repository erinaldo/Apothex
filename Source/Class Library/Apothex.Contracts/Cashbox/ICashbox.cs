using System;
using Apothex.DataType;

namespace Apothex.Contracts.Cashbox
{
    interface ICashbox
    {
        DS_Cashbox.T_CashboxOrderDataTable Get(int? id);
        int Save(int? id, int? actID, DateTime? date, int? branchID, string subAccount, string analyticalAccountingCode, decimal? amount, byte? currencyID, string specialPurposeCode, int? issuedPersonID, byte? basisID, string enclosure, string warrantNumber, int? modifierID);
    }
}
