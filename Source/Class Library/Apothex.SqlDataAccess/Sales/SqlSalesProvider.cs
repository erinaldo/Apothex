using System;
using System.Data;
using Apothex.Contracts.Sales;
using Apothex.DataType.DS_SalesTableAdapters;
using Apothex.DataType;
using Apothex.Configuration;
using Apothex.DataType.DS_CloseDayTableAdapters;
using Zek.Data;
using Apothex.DataType.DS_SalesOrderActTableAdapters;
using Zek.Extensions;

namespace Apothex.SqlDataAccess.Sales
{
    public sealed class SqlSalesProvider : SalesProvider
    {
        public override DS_Sales.SP_GetSalesOrderHeaderDataTable GetSalesOrderHeader(int salesOrderID, DateTime orderDate, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetSalesOrderHeaderTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(salesOrderID, orderDate);
            }
        }
        public override DS_Sales.SP_GetSalesOrderDetailDataTable GetSalesOrderDetail(int salesOrderID, DateTime orderDate, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SP_GetSalesOrderDetailTableAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return adapter.GetData(salesOrderID, orderDate);
            }
        }

        public override DS_Sales.SP_GetRptSalesOrderHeaderDataTable GetRptSalesOrderHeader(int salesOrderID)
        {
            using (var adapter = SP_GetRptSalesOrderHeaderTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(salesOrderID);
            }
        }

        public override DateTime GetOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SalesQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (DateTime)adapter.SP_GetOrderDate(tableID, orderID, branchID, date);
            }
        }
        public override bool IsValidOrderDate(int tableID, int orderID, int branchID, DateTime date, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SalesQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (bool)adapter.SP_IsValidOrderDate(tableID, orderID, branchID, date);
            }
        }
        public override int AddOrEditSalesOrder(int salesOrderID, int branchID, DateTime orderDate, string overheadNumber, int customerID, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, string currencyCode, int currencyRateID, int paymentMethodID, int revisionNumber, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, Guid rowguid, int action, bool isOnline, byte[] b)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SalesQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (int)adapter.SP_AddOrEditSalesOrder(salesOrderID, branchID, orderDate, overheadNumber, customerID, subTotal, taxAmt, freight, totalDue, currencyCode, currencyRateID, paymentMethodID, revisionNumber, comment, status, modifiedUserID, modifiedDate, approverUserID, rowguid, action, b.GetXmlData());
            }
        }
        public override int FindSalesOrderID(Guid? rowguid)
        {
            using (var adapter = SalesQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_FindSalesOrderID(rowguid);
            }
        }

        public override DS_CloseDay.SP_GetCloseDayDataTable GetCloseDay(int closeDayID)
        {
            using (var adapter = SP_GetCloseDayTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(closeDayID);
            }
        }
        public override bool IsValidCloseDate(int closeDayID, int branchID, DateTime closeDate)
        {
            using (var adapter = CloseDayQueriesdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_IsValidCloseDate(closeDayID, branchID, closeDate);
            }
        }
        public override int AddOrEditCloseDay(int closeDayID, int branchID, DateTime closeDate, string comment, int status, int modifiedUserID, DateTime modifiedDate, int approverUserID, int action)
        {
            using (var adapter = CloseDayQueriesdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_AddOrEditCloseDay(closeDayID, branchID, closeDate, comment, status, modifiedUserID, modifiedDate, approverUserID, action);
            }
        }

        public override DS_SalesOrderAct.VW_SalesOrderActDataTable GetActVW(int? id)
        {
            using (var adapter = VW_SalesOrderActTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override DS_SalesOrderAct.VW_SalesOrderActDetailDataTable GetActDetailVW(int? id)
        {
            using (var adapter = VW_SalesOrderActDetailTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override string SaveAct(int? id, string actNumber, int? modifierID)
        {
            using (var adapter = SalesOrderActQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (string)adapter.SP_T_SalesOrderAct_Save(id, actNumber, modifierID);
            }
        }

        public override decimal GetTotal(int? branchID, DateTime? date1, DateTime? date2)
        {
            using (var adapter = SalesQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (decimal)adapter.SP_T_SalesOrderHeader_GetTotal(branchID, date1, date2);
            }
        }
        public override DataTable GetNomination(DateTime? date1, DateTime? date2)
        {
            return SqlHelper.ExecuteDataTable(ConfigurationManagerEx.ConnectionString, CommandType.Text, string.Format("EXEC Sales.SP_T_SalesOrder_GetNomination {0}, {1}", date1.ToSQLValue(), date2.ToSQLValue()));
        }
    }
}
