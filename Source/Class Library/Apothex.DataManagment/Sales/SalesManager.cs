using System;
using Apothex.DataType;
using Zek.Data;
using Apothex.Contracts.Sales;
using Apothex.Configuration;
using Zek.Core;
using Apothex.SqlDataAccess.Sales;
using System.Data;

namespace Apothex.DataManagment.Sales
{
    public static class SalesManager
    {
        #region Instance
        private static object _lock = new object();
        private static SalesProvider _instance;
        private static SalesProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.SalesProvider)
                            {
                                case "WS":
                                case "SQL":
                                default:
                                    _instance = new SqlSalesProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }

        private static SalesProvider SqlSalesProvider()
        {
            throw new NotImplementedException();
        }
        #endregion

        public static DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(int salesOrderID, bool isOnline)
        {
            return GetSalesOrderHeader(salesOrderID, DateTimeHelper.MinDate, isOnline);
        }
        public static DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(DateTime orderDate, bool isOnline)
        {
            return GetSalesOrderHeader(0, orderDate, isOnline);
        }
        private static DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(int salesOrderID, DateTime orderDate, bool isOnline)
        {
            return Instance.GetSalesOrderHeader(salesOrderID, orderDate, isOnline);
        }
        public static DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(int salesOrderID, bool isOnline)
        {
            return GetSalesOrderDetail(salesOrderID, DateTimeHelper.MinDate, isOnline);
        }
        public static DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(DateTime orderDate, bool isOnline)
        {
            return GetSalesOrderDetail(0, orderDate, isOnline);
        }
        private static DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(int salesOrderID, DateTime orderDate, bool isOnline)
        {
            return Instance.GetSalesOrderDetail(salesOrderID, orderDate, isOnline);
        }

        //public static DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetailByPurchaseOrderID(int purchaseOrderID)
        //{
        //    return Instance.GetSalesOrderDetailByPurchaseOrderID(purchaseOrderID);
        //}
        public static DS_Sales.SP_GetRptSalesOrderHeaderDataTable GetRptSalesOrderHeader(int salesOrderID)
        {
            return Instance.GetRptSalesOrderHeader(salesOrderID);
        }


        public static DateTime GetOrderDate(ObjectNames tableName, int orderID, int branchID, DateTime date, bool isOnline)
        {
            return Instance.GetOrderDate((int)tableName, orderID, branchID, date, isOnline);
        }
        public static bool IsValidOrderDate(ObjectNames tableName, int orderID, int branchID, DateTime date, bool isOnline)
        {
            return Instance.IsValidOrderDate((int)tableName, orderID, branchID, date, isOnline);
        }
        public static int AddOrEditSalesOrder(int salesOrderID, int branchID, DateTime orderDate, string overheadNumber, int customerID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, int paymentMethodID, int revisionNumber, string comment, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, DatabaseAction action, bool isOnline, byte[] b)
        {
            return Instance.AddOrEditSalesOrder(salesOrderID, branchID, orderDate, overheadNumber, customerID, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRateID, paymentMethodID, revisionNumber, comment, (int)status, modifiedUserID, modifiedDate, approverUserID, rowguid, (int)action, isOnline, b);
        }
        public static int FindSalesOrderID(Guid? rowguid)
        {
            return Instance.FindSalesOrderID(rowguid);
        }

        public static DS_CloseDay.SP_GetCloseDayDataTable GetCloseDay(int closeDayID)
        {
            return Instance.GetCloseDay(closeDayID);
        }
        public static bool IsValidCloseDate(int closeDayID, int branchID, DateTime closeDate)
        {
            return Instance.IsValidCloseDate(closeDayID, branchID, closeDate);
        }
        public static int AddOrEditCloseDay(int closeDayID, int branchID, DateTime closeDate, string comment, DatabaseStatus status, int modifiedUserID, DateTime modifiedDate, int approverUserID, DatabaseAction action)
        {
            return Instance.AddOrEditCloseDay(closeDayID, branchID, closeDate, comment, (int)status, modifiedUserID, modifiedDate, approverUserID, (int)action);
        }


        public static DS_SalesOrderAct.VW_SalesOrderActDataTable GetActVW(int? id)
        {
            return Instance.GetActVW(id);
        }
        public static DS_SalesOrderAct.VW_SalesOrderActDetailDataTable GetActDetailVW(int? id)
        {
            return Instance.GetActDetailVW(id);
        }
        public static string SaveAct(int? id)
        {
            return SaveAct(id, null, null);
        }
        private static string SaveAct(int? id, string actNumber, int? modifierID)
        {
            return Instance.SaveAct(id, actNumber, modifierID);
        }

        public static decimal GetTotal(int? branchID, DateTime? date1, DateTime? date2)
        {
            return Instance.GetTotal(branchID, date1, date2);
        }



        public static DataTable GetNomination(DateTime? date1, DateTime? date2)
        {
            return Instance.GetNomination(date1, date2);
        }
    }
}
