using System;
using Apothex.Configuration;
using Apothex.Contracts.ProductLocation;
using Apothex.DataType;
using Apothex.SqlDataAccess.ProductLocation;

namespace Apothex.DataManagment.ProductLocation
{
    public static class ProductLocationManager
    {
        #region Instance
        private static object sync = new object();
        private static ProductLocationProvider _Instance;
        private static ProductLocationProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            switch (ConfigurationManagerEx.PersonProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _Instance = new SqlProductLocationProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion

        public static DS_ProductLocation.VW_ProductLocationDataTable GetVWByBranchAndDate(int? branchID, DateTime? date)
        {
            return GetVW(null, null, branchID, null, null, date, true);
        }
        public static DS_ProductLocation.VW_ProductLocationDataTable GetVWByIDAndBranch(int? productLocationID, int? branchID, bool isOnline)
        {
            return GetVW(productLocationID, null, branchID, null, null, null, isOnline);
        }
        public static DS_ProductLocation.VW_ProductLocationDataTable GetVWByPurchaseOrderID(int? purchaseOrderID)
        {
            return GetVW(null, purchaseOrderID, null, null, null, null, true);
        }
        public static DS_ProductLocation.VW_ProductLocationDataTable GetVWByBarCode(int? branchID, int? productID, string barcode)
        {
            return GetVW(null, null, branchID, productID, barcode, null, true);
        }
        
        private static DS_ProductLocation.VW_ProductLocationDataTable GetVW(int? id, int? purchaseOrderID, int? branchID, int? productID, string barcode, DateTime? date, bool isOnline)
        {
            return Instance.GetVW(id, purchaseOrderID, branchID, productID, barcode, date, isOnline);
        }


        public static DS_ProductLocation.SP_GetProductLocationQuantityDataTable GetProductLocationQuantity(int? productLocationID, ObjectNames tableName, bool isOnline, byte[] b)
        {
            return Instance.GetProductLocationQuantity(productLocationID, (int)tableName, isOnline, b);
        }

        public static DS_ProductLocationPurchaseOrderHeader.SP_GetProductLocationPurchaseOrderHeaderDataTable GetProductLocationPurchaseOrderHeader(int? productID, int? productLocationID)
        {
            return Instance.GetProductLocationPurchaseOrderHeader(productID, productLocationID);
        }

    }
}
