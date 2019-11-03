using System;
using Apothex.DataType;


namespace Apothex.Contracts.Purchasing
{
    interface IPurchasing
    {
        DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable GetPurchaseOrderHeader(int purchaseOrderID);
        DS_Purchasing.SP_GetPurchaseOrderDetailDataTable GetPurchaseOrderDetail(int purchaseOrderID);
        int AddOrEditPurchaseOrder(int purchaseOrderID, int branchID, DateTime orderDate, string overheadNumber, int vendorID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, decimal currencyRate1, decimal currencyRate2, int paymentMethodID, int revisionNumber, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, int action, byte[] b);
    }
}
