using System;
using Apothex.Contracts.Cashbox;
using Apothex.SqlDataAccess.Cashbox;
using Apothex.Configuration;
using Apothex.DataType;

namespace Apothex.DataManagment.Cashbox
{
    public static class CashboxManager
    {
        #region Fields
        private static object sync = new object();
        private static CashboxProvider _Instance;
        private static CashboxProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            switch (ConfigurationManagerEx.CashboxProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _Instance = new SqlCashboxProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DS_Cashbox.T_CashboxOrderDataTable Get(int? id)
        {
            return Instance.Get(id);
        }

        public static int Save(int? id, int? actID, DateTime? date, int? branchID, string subAccount, string analyticalAccountingCode, decimal? amount, byte? currencyID, string specialPurposeCode, int? issuedPersonID, byte? basisID, string enclosure, string warrantNumber, int? modifierID)
        {
            return Instance.Save(id, actID, date, branchID, subAccount, analyticalAccountingCode, amount, currencyID, specialPurposeCode, issuedPersonID, basisID, enclosure, warrantNumber, modifierID);
        }
    }
}
