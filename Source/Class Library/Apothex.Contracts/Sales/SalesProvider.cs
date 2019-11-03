using System;
using Apothex.DataType;
using System.Data;

namespace Apothex.Contracts.Sales
{
    public abstract class SalesProvider : ISales
    {
        public abstract DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(int salesOrderID, DateTime orderDate, bool isOnline);
        public abstract DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(int salesOrderID, DateTime orderDate, bool isOnline);
        //public abstract DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetailByPurchaseOrderID(int purchaseOrderID);
        public abstract DS_Sales.SP_GetRptSalesOrderHeaderDataTable GetRptSalesOrderHeader(int salesOrderID);

        public abstract DateTime GetOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline);
        public abstract bool IsValidOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline);
        public abstract int AddOrEditSalesOrder(int salesOrderID, int branchID, DateTime orderDate, string overheadNumber, int customerID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, int paymentMethodID, int revisionNumber, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, int action, bool isOnline, byte[] b);
        public abstract int FindSalesOrderID(Guid? rowguid);

        public abstract DS_CloseDay.SP_GetCloseDayDataTable GetCloseDay(int closeDayID);
        public abstract bool IsValidCloseDate(int closeDayID, int branchID, DateTime closeDate);
        public abstract int AddOrEditCloseDay(int closeDayID, int branchID, DateTime closeDate, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);


        public abstract DS_SalesOrderAct.VW_SalesOrderActDataTable GetActVW(int? id);
        public abstract DS_SalesOrderAct.VW_SalesOrderActDetailDataTable GetActDetailVW(int? id);
        public abstract string SaveAct(int? id, string actNumber, int? modifierID);

        public abstract decimal GetTotal(int? branchID, DateTime? date1, DateTime? date2);
        public abstract DataTable GetNomination(DateTime? date1, DateTime? date2);
    }
}
