using System;
using Apothex.Configuration;
using Apothex.Contracts.Production;
using Apothex.DataType;
using Apothex.SqlDataAccess.Production;
using Zek.Data;

namespace Apothex.DataManagment.Production
{
    public static class ProductionManager
    {
        #region Instance
        private static object sync = new object();
        private static ProductionProvider _Instance;
        private static ProductionProvider Instance
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
                                    _Instance = new SqlProductionProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }
        #endregion


        public static string QtyToString(decimal quantity, short unitsInStock)
        {
            //return ((int)quantity).ToString("f0") + "მთ. " + ((quantity % Math.Max((int)quantity, 1)) * unitsInStock).ToString("n00") + "ც.";
            if (quantity >= 1m)
                return ((int)quantity).ToString("f0") + "მთ. " + ((quantity % (int)quantity) * unitsInStock).ToString("f0") + "ც.";
            else
                return "0მთ. " + (quantity * unitsInStock).ToString("f0") + "ც.";
        }


        public static DS_Product.SP_GetProductDataTable GetProduct(int productID)
        {
            return Instance.GetProduct(productID);
        }
        public static int AddOrEditProducts(int modifiedUserID, DateTime modifiedDate, DatabaseAction action, byte[] b)
        {
            return AddOrEditProduct(0, Guid.Empty, 0, 0m, 0m, 0m, 0m, string.Empty, 0m, 0m, DateTime.Now, string.Empty, 0, string.Empty, modifiedUserID, modifiedDate, action, b);
        }
        public static int AddOrEditProduct(int productID, Guid purchaseOrderDetailID, int medicamentID, decimal quantity, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, DateTime validDate, string countryCode, int brandID, string serie, int modifiedUserID, DateTime modifiedDate, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditProduct(productID, purchaseOrderDetailID, medicamentID, quantity, standardCost, listPrice, dealerPrice, productCurrencyCode, discountPct, taxRate, validDate, countryCode, brandID, serie, modifiedUserID, modifiedDate, (int)action, b);
        }

        public static DS_ProductDistribution.SP_GetProductDistributionHeaderDataTable GetProductDistributionHeader(int productDistributionID)
        {
            return Instance.GetProductDistributionHeader(productDistributionID);
        }
        public static DS_ProductDistribution.SP_GetProductDistributionDetailDataTable GetProductDistributionDetail(int productDistributionID)
        {
            return Instance.GetProductDistributionDetail(productDistributionID);
        }
        public static int AddOrEditProductDistribution(int productDistributionID, int fromBranchID, int toBranchID, DateTime startDate, DateTime endDate, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, string comment, int revisionNumber, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action, byte[] b)
        {
            return Instance.AddOrEditProductDistribution(productDistributionID, fromBranchID, toBranchID, startDate, endDate, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRateID, comment, revisionNumber, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action, b);
        }
        public static void UpdateProductDistributionStatus(int? id, int? statusID, int? modifierID)
        {
            Instance.UpdateProductDistributionStatus(id, statusID, modifierID);
        }

        public static DS_Barcode.SP_GetBarcodeDataTable GetBarcode(string barcode, int productID)
        {
            return Instance.GetBarcode(barcode, productID);
        }
        public static DS_Barcode.SP_IsValidBarcodeDataTable IsValidBarcode(string barcode, int productID, byte[] b)
        {
            return Instance.IsValidBarcode(barcode, productID, b);
        }



        public static DS_RealIncomeExpence.SP_GetRealIncomeExpenceDataTable GetRealIncomeExpence(DateTime fromDate, DateTime toDate, string currencyCode, bool addVatAmt, int sumByCustomerID)
        {
            return Instance.GetRealIncomeExpence(fromDate, toDate, currencyCode, addVatAmt, sumByCustomerID);
        }

        /// <summary>
        /// თვითღირებულების ინფორმაციის ამოღება.
        /// </summary>
        /// <param name="productID">პროდუქტიც ID.</param>
        /// <param name="currencyCode">რა ვალუტაშიც ვყიდით იმის კოდი.</param>
        /// <param name="b">ბაიტების მასივი</param>
        /// <returns></returns>
        public static DS_PurchaseOrderInfo.SP_GetPurchaseOrderInfoDataTable GetPurchaseOrderInfo(int productID, string currencyCode, byte[] b)
        {
            return Instance.GetPurchaseOrderInfo(productID, currencyCode, b);
        }
        /// <summary>
        /// თვითღირებულების ამოღება.
        /// </summary>
        /// <param name="productID">პროდუქტის ID.</param>
        /// <param name="currencyCode">რა ვალუტაშიც ვყიდით იმის კოდი.</param>
        /// <returns>თვითღირებულებას რა ვალუტაშიც ვყიდით.</returns>
        public static decimal GetPurchaseUnitPrice(int productID, string currencyCode)
        {
            var table = GetPurchaseOrderInfo(productID, currencyCode, null);
            return GetPurchaseUnitPrice(table[0].UnitPrice, table[0].AverageRate1, table[0].AverageRate2);
        }
        public static decimal GetPurchaseUnitPrice(decimal unitPrice, decimal rate1, decimal rate2)
        {
            return unitPrice * rate1 / rate2;
        }


        public static DS_WarehouseDescription.SP_GetWarehouseDescriptionHeaderDataTable GetWarehouseDescriptionHeader(int warehouseDescriptionID)
        {
            return Instance.GetWarehouseDescriptionHeader(warehouseDescriptionID);
        }
        public static DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailDataTable GetWarehouseDescriptionDetail(int warehouseDescriptionID)
        {
            return Instance.GetWarehouseDescriptionDetail(warehouseDescriptionID);
        }
        public static int AddOrEditWarehouseDescription(int warehouseDescriptionID, int branchID, DateTime date, int productCount, decimal productQty, decimal descrQty, decimal productTotalDue, decimal descrTotalDue, string currencyCode, byte[] b, DatabaseStatus status, DateTime createDate, int creatorID, DateTime modifiedDate, int modifierID, int approverID, DatabaseAction action)
        {
            return Instance.AddOrEditWarehouseDescription(warehouseDescriptionID, branchID, date, productCount, productQty, descrQty, productTotalDue, descrTotalDue, currencyCode, b, (int)status, createDate, creatorID, modifiedDate, modifierID, approverID, (int)action);
        }

        public static int ChangeProductCurrencyCode(string productCurrencyCode, bool changePriceFlag, byte[] b, DateTime modifiedDate, int modifierID)
        {
            return Instance.ChangeProductCurrencyCode(productCurrencyCode, changePriceFlag, b, modifiedDate, modifierID);
        }
    }
}
