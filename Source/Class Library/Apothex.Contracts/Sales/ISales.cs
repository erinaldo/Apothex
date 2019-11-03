using System;
using Apothex.DataType;
using System.Data;

namespace Apothex.Contracts.Sales
{
    interface ISales
    {
        DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(int salesOrderID, DateTime orderDate, bool isOnline);
        DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(int salesOrderID, DateTime orderDate, bool isOnline);
        //DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetailByPurchaseOrderID(int purchaseOrderID);
        DS_Sales.SP_GetRptSalesOrderHeaderDataTable GetRptSalesOrderHeader(int salesOrderID);

        DateTime GetOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline);
        bool IsValidOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline);
        int AddOrEditSalesOrder(int salesOrderID, int branchID, DateTime orderDate, string overheadNumber, int customerID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, int paymentMethodID, int revisionNumber, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, int action, bool isOnline, byte[] b);
        int FindSalesOrderID(Guid? rowguid);

        DS_CloseDay.SP_GetCloseDayDataTable GetCloseDay(int closeDayID);
        bool IsValidCloseDate(int closeDayID, int branchID, DateTime closeDate);
        int AddOrEditCloseDay(int closeDayID, int branchID, DateTime closeDate, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action);

        DS_SalesOrderAct.VW_SalesOrderActDataTable GetActVW(int? id);
        DS_SalesOrderAct.VW_SalesOrderActDetailDataTable GetActDetailVW(int? id);
        string SaveAct(int? id, string actNumber, int? modifierID);

        decimal GetTotal(int? branchID, DateTime? date1, DateTime? date2);
        DataTable GetNomination(DateTime? date1, DateTime? date2);
    }
}
