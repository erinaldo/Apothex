using Apothex.Contracts.Accounting;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Accounting;
using Apothex.DataType;

namespace Apothex.DataManagment.Accounting
{
    public static class AccountingManager
    {
        #region Instance
        private static object sync = new object();
        private static AccountingProvider _instance;
        private static AccountingProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.AccountingProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlAccountingProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion


        //public static string GetAutoNumber(string name, int? year)
        //{
        //    return GetAutoNumber(name, year, null);
        //}
        public static string GetAutoNumber(ObjectNames name, int? year, int? branchID)
        {
            return GetAutoNumber(name.ToString(), year, branchID);
        }
        public static string GetAutoNumber(string name, int? year, int? branchID)
        {
            return Instance.GetAutoNumber(name, year, branchID);
        }
    }
}
