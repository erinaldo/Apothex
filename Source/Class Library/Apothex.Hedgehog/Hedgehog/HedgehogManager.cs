using System;
using Apothex.Configuration;
using Apothex.DataType;
using Zek.Data;
using Apothex.Contracts.Hedgehog;
using Apothex.SqlDataAccess.Hedgehog;

namespace Apothex.DataManagment.Hedgehog
{
    public static class HedgehogManager
    {
        #region Instance
        private static object _lock = new object();
        private static HedgehogProvider _instance;
        private static HedgehogProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.HedgehogProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                case "OleDataBase":
                                default: //SqlDataBase
                                    _instance = new OleDbHedgehogProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static DS_Hedgehog.SP_GetSalesHedgehogDataTable GetSalesHedgehog(int salesOrderID)
        {
            return Instance.GetSalesHedgehog(salesOrderID);
        }
        public static void AddOrEditHedgehog(int salesOrderID, decimal totalDue, DateTime orderDate, DatabaseAction action)
        {
            Instance.AddOrEditHedgehog(salesOrderID, totalDue, orderDate, (int)action);
        }
        public static void DeleteHedgehog(int salesOrderID)
        {
            Instance.DeleteHedgehog(salesOrderID);
        }
    }
}
