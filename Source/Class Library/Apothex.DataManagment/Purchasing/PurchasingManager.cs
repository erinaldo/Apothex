using System;
using Apothex.DataType;
using Zek.Data;
using Apothex.Contracts.Purchasing;
using Apothex.SqlDataAccess.Purchasing;
using Apothex.Configuration;

namespace Apothex.DataManagment.Purchasing
{
    public static class PurchasingManager
    {
        #region Fields
        private static object sync = new object();
        private static PurchasingProvider _Instance;
        private static PurchasingProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            switch (ConfigurationManagerEx.PurchasingProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _Instance = new SqlPurchasingProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable GetPurchaseOrderHeader(int purchaseOrderID)
        {
            return Instance.GetPurchaseOrderHeader(purchaseOrderID);
        }
        public static DS_Purchasing.SP_GetPurchaseOrderDetailDataTable GetPurchaseOrderDetail(int purchaseOrderID)
        {
            return Instance.GetPurchaseOrderDetail(purchaseOrderID);
        }

        public static int AddOrEditPurchaseOrder(int purchaseOrderID, int branchID, DateTime orderDate, string overheadNumber, int vendorID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, decimal currencyRate1, decimal currencyRate2, int paymentMethodID, int revisionNumber, string comment, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditPurchaseOrder(purchaseOrderID, branchID, orderDate, overheadNumber, vendorID, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRate1, currencyRate2, paymentMethodID, revisionNumber, comment, (int)status, modifiedUserID, modifiedDate, approverUserID, rowguid, (int)action, b);
        }
    }
}
