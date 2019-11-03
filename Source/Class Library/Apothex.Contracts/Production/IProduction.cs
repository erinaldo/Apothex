using System;
using Apothex.DataType;

namespace Apothex.Contracts.Production
{
    interface IProduction
    {
        DS_ProductDistribution.SP_GetProductDistributionHeaderDataTable GetProductDistributionHeader(int productDistributionID);
        DS_ProductDistribution.SP_GetProductDistributionDetailDataTable GetProductDistributionDetail(int productDistributionID);
        int AddOrEditProductDistribution(int productDistributionID, int fromBranchID, int toBranchID, DateTime startDate, DateTime endDate, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, string comment, int revisionNumber, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action, byte[] b);
        void UpdateProductDistributionStatus(int? id, int? statusID, int? modifierID);

        DS_Product.SP_GetProductDataTable GetProduct(int productID);
        int AddOrEditProduct(int productID, Guid purchaseOrderDetailID, int medicamentID, decimal quantity, decimal standardCost, decimal listPrice, decimal dealerPrice, string productCurrencyCode, decimal discountPct, decimal taxRate, DateTime validDate, string countryCode, int brandID, string serie, int modifiedUserID, DateTime modifiedDate, int action, byte[] b);



        DS_Barcode.SP_GetBarcodeDataTable GetBarcode(string barcode, int productID);
        DS_Barcode.SP_IsValidBarcodeDataTable IsValidBarcode(string barcode, int productID, byte[] b);

        DS_RealIncomeExpence.SP_GetRealIncomeExpenceDataTable GetRealIncomeExpence(DateTime fromDate, DateTime toDate, string currencyCode, bool addVatAmt, int sumByCustomerID);

        DS_PurchaseOrderInfo.SP_GetPurchaseOrderInfoDataTable GetPurchaseOrderInfo(int productID, string currencyCode, byte[] b);

        DS_WarehouseDescription.SP_GetWarehouseDescriptionHeaderDataTable GetWarehouseDescriptionHeader(int warehouseDescriptionID);
        DS_WarehouseDescription.SP_GetWarehouseDescriptionDetailDataTable GetWarehouseDescriptionDetail(int warehouseDescriptionID);
        int AddOrEditWarehouseDescription(int warehouseDescriptionID, int branchID, DateTime date, int productCount, decimal productQty, decimal descrQty, decimal productTotalDue, decimal descrTotalDue, string currencyCode, byte[] b, int status, DateTime createDate, int creatorID, DateTime modifiedDate, int modifierID, int approverID, int action);

        int ChangeProductCurrencyCode(string productCurrencyCode, bool changePriceFlag, byte[] b, DateTime modifiedDate, int modifierID);
    }
}
