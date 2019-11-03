using System;
using Apothex.Contracts.Purchasing;
using Apothex.DataType;
using Apothex.DataType.DS_PurchasingTableAdapters;
using Zek.Data;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.Purchasing
{
    public sealed class SqlPurchasingProvider : PurchasingProvider
    {
        public override DS_Purchasing.SP_GetPurchaseOrderHeaderDataTable GetPurchaseOrderHeader(int purchaseOrderID)
        {
            using (var adapter = SP_GetPurchaseOrderHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(purchaseOrderID);
            }
        }
        public override DS_Purchasing.SP_GetPurchaseOrderDetailDataTable GetPurchaseOrderDetail(int purchaseOrderID)
        {
            using (var adapter = SP_GetPurchaseOrderDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(purchaseOrderID);
            }
        }

        public override int AddOrEditPurchaseOrder(int purchaseOrderID, int branchID, DateTime orderDate, string overheadNumber, int vendorID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, decimal currencyRate1, decimal currencyRate2, int paymentMethodID, int revisionNumber, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, int action, byte[] b)
        {
            using (var adapter = PurchasingQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditPurchaseOrder(purchaseOrderID, branchID, orderDate, overheadNumber, vendorID, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRate1, currencyRate2, paymentMethodID, revisionNumber, comment, status, modifiedUserID, modifiedDate, approverUserID, rowguid, action, b.GetXmlData());
            }
        }
    }
}
