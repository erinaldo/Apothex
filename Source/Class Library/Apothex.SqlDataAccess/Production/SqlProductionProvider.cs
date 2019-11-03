using System;
using Apothex.Contracts.Production;
using Apothex.DataType;
using Apothex.DataType.DS_ProductDistributionTableAdapters;
using Apothex.DataType.DS_ProductTableAdapters;
using Apothex.DataType.DS_BarcodeTableAdapters;
using Zek.Data;
using Apothex.DataType.DS_RealIncomeExpenceTableAdapters;
using Apothex.DataType.DS_PurchaseOrderInfoTableAdapters;
using Apothex.Configuration;
using Apothex.DataType.DS_WarehouseDescriptionTableAdapters;

namespace Apothex.SqlDataAccess.Production
{
    public sealed class SqlProductionProvider : ProductionProvider
    {
        public override DS_Product.SP_GetProductDataTable GetProduct(int productID)
        {
            using (var adapter = SP_GetProductTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productID);
            }
        }
        public override int AddOrEditProduct(int productID, Guid purchaseOrderDetailID, int medicamentID, decimal quantity, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, DateTime validDate, string countryCode, int brandID, string serie, int modifiedUserID, DateTime modifiedDate, int action, byte[] b)
        {
            using (var adapter = ProductQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditProduct(productID, purchaseOrderDetailID, medicamentID, quantity, standardCost, listPrice, dealerPrice, productCurrencyCode, discountPct, taxRate, validDate, countryCode, brandID, serie, modifiedUserID, modifiedDate, action, b.GetXmlData());
            }
        }

        public override DS_ProductDistribution.SP_GetProductDistributionHeaderDataTable GetProductDistributionHeader(int productDistributionID)
        {
            using (var adapter = SP_GetProductDistributionHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productDistributionID);
            }
        }
        public override DS_ProductDistribution.SP_GetProductDistributionDetailDataTable GetProductDistributionDetail(int productDistributionID)
        {
            using (var adapter = SP_GetProductDistributionDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productDistributionID);
            }
        }
        public override int AddOrEditProductDistribution(int productDistributionID, int fromBranchID, int toBranchID, DateTime startDate, DateTime endDate, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, string comment, int revisionNumber, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action, byte[] b)
        {
            using (var adapter = ProductDistributionQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditProductDistribution(productDistributionID, fromBranchID, toBranchID, startDate, endDate, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRateID, comment, revisionNumber, status, modifiedUserID, modifiedDate, approverUserID, action, b.GetXmlData());
            }
        }
        public override void UpdateProductDistributionStatus(int? id, int? statusID, int? modifierID)
        {
            using (var adapter = ProductDistributionQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                adapter.SP_T_ProductDistributionHeader_UpdateStatus(id, statusID, modifierID);
            }
        }

        public override DS_Barcode.SP_GetBarcodeDataTable GetBarcode(string barcode, int productID)
        {
            using (var adapter = SP_GetBarcodeTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(barcode, productID);
            }
        }
        public override DS_Barcode.SP_IsValidBarcodeDataTable IsValidBarcode(string barcode, int productID, byte[] b)
        {
            using (var adapter = SP_IsValidBarcodeTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(barcode, productID, b.GetXmlData());
            }
        }

        public override DS_RealIncomeExpence.SP_GetRealIncomeExpenceDataTable GetRealIncomeExpence(DateTime fromDate, DateTime toDate, string currencyCode, bool addVatAmt, int sumByCustomerID)
        {
            using (var adapter = SP_GetRealIncomeExpenceTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(fromDate, toDate, currencyCode, addVatAmt, sumByCustomerID);
            }
        }

        public override DS_PurchaseOrderInfo.SP_GetPurchaseOrderInfoDataTable GetPurchaseOrderInfo(int productID, string currencyCode, byte[] b)
        {
            using (var adapter = SP_GetPurchaseOrderInfoTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productID, currencyCode, b.GetXmlData());
            }
        }

        public override DS_WarehouseDescription.SP_GetWarehouseDescriptionHeaderDataTable GetWarehouseDescriptionHeader(int warehouseDescriptionID)
        {
            using (var adapter = SP_GetWarehouseDescriptionHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(warehouseDescriptionID);
            }
        }
        public override DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailDataTable GetWarehouseDescriptionDetail(int warehouseDescriptionID)
        {
            using (var adapter = SP_GetWarehouseDescriptionDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(warehouseDescriptionID);
            }
        }
        public override int AddOrEditWarehouseDescription(int warehouseDescriptionID, int branchID, DateTime date, int productCount, decimal productQty, decimal descrQty, decimal productTotalDue, decimal descrTotalDue, string currencyCode, byte[] b, int status, DateTime createDate, int creatorID, DateTime modifiedDate, int modifierID, int approverID, int action)
        {
            using (var adapter = WarehouseDescriptionQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditWarehouseDescription(warehouseDescriptionID, branchID, date, productCount, productQty, descrQty, productTotalDue, descrTotalDue, currencyCode, b.GetXmlData(), status, createDate, creatorID, modifiedDate, modifierID, approverID, action);
            }
        }

        public override int ChangeProductCurrencyCode(string productCurrencyCode, bool changePriceFlag, byte[] b, DateTime modifiedDate, int modifierID)
        {
            using (var adapter = ProductQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_ChangeProductCurrencyCode(productCurrencyCode, changePriceFlag, b.GetXmlData(), modifiedDate, modifierID);
            }
        }
    }
}
