using System;
using Apothex.Contracts.Synchronization;
using Apothex.DataType;
using Zek.Core;
using Zek.Data;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Synchronization;
using Apothex.WSDataAccess.Synchronization;
using System.Data;
using Apothex.DataManagment.Card;
using Apothex.DataManagment.Sales;
using Apothex.DataManagment.Config;
using Zek.Configuration;

namespace Apothex.DataManagment.Synchronization
{
    public static class SynchronizationManager
    {
        #region Instance
        private static object sync = new object();
        private static SynchronizationProvider _Instance;
        private static SynchronizationProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (sync)
                    {
                        if (_Instance == null)
                        {
                            if (!AppConfigHelper.GetBool("IsWS"))
                            {
                                ConfigurationManagerEx.WSSynchronizationUrl = ConfigManager.GetString(ConfigName.WSSynchronizationUrl);
                                if (ConfigurationManagerEx.WSSynchronizationUrl.Length == 0)
                                    ConfigurationManagerEx.WSSynchronizationUrl = AppConfigHelper.GetString("WSSynchronizationUrl");

                                if (ConfigurationManagerEx.WSSynchronizationUrl.Length > 0)
                                    ConfigurationManagerEx.SynchronizationProvider = "WS";
                            }

                            switch (ConfigurationManagerEx.SynchronizationProvider)
                            {
                                case "WS":
                                    _Instance = new WSSynchronizationProvider();
                                    break;

                                case "SQL":
                                default:
                                    _Instance = new SqlSynchronizationProvider();
                                    break;
                            }
                        }
                    }
                }
                return _Instance;
            }
        }

        private static SynchronizationProvider _local = new SqlSynchronizationProvider();
        #endregion

        public static DS_Synchronization.SP_GetSyncBranchDataTable GetSyncBranch(int branchID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncBranch(branchID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncUserDataTable GetSyncUser(int userID, int branchID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncUser(userID, branchID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncUserPermissionDataTable GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncUserPermission(userID, branchID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncMyCompanyDataTable GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncMyCompany(myCompanyID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncCurrencyDataTable GetSyncCurrency(string currencyCode, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncCurrency(currencyCode, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncPaymentMethodDataTable GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncPaymentMethod(paymentMethodID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.SP_GetSyncProductLocationDataTable GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, DatabaseAction action)
        {
            return Instance.GetSyncProductLocation(productLocationID, productID, branchID, modifiedDate, (int)action);
        }
        public static DS_Synchronization.DD_CardUnitRateDataTable GetSyncCardUnitRate()
        {
            return Instance.GetSyncCardUnitRate();
        }
        public static DS_Synchronization.DD_CardDiscountSchemaDataTable GetSyncCardDiscountSchema()
        {
            return Instance.GetSyncCardDiscountSchema();
        }
        public static DS_Synchronization.DD_OperationTypeDataTable GetOperationType()
        {
            return Instance.GetOperationType();
        }

        public static DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail()
        {
            var serverDateTime = SynchronizationManager.GetDate(ObjectNames.None, true);
            using (var ds = new DataSet("root"))
            {
                var header = SalesManager.GetSalesOrderHeader(serverDateTime.Date, false);
                var detail = SalesManager.GetSalesOrderDetail(serverDateTime.Date, false);
                header.RemoveColumns(true,
                                        header.SalesOrderIDColumn,
                                        header.BranchIDColumn,
                                        header.OrderDateColumn,
                                        header.OverheadNumberColumn,
                                        header.CustomerIDColumn,
                                        header.SubTotalColumn,
                                        header.TaxAmtColumn,
                                        header.FreightColumn,
                                        header.CurrencyCodeColumn,
                                        header.CurrencyRateIDColumn,
                                        header.PaymentMethodIDColumn,
                                        header.RevisionNumberColumn,
                                        header.StatusColumn,
                                        header.ModifiedUserIDColumn,
                                        header.ModifiedDateColumn,
                                        header.ApproverUserIDColumn,
                                        header.rowguidColumn
                                        );

                detail.RemoveColumns(true, detail.SalesOrderDetailIDColumn,
                                        detail.SalesOrderIDColumn,
                                        detail.ProductLocationIDColumn,
                                        detail.SaleQtyColumn,
                                        detail.UnitPriceColumn,
                                        detail.UnitPriceDiscountColumn,
                                        detail.OrdinalNumberColumn,
                                        detail.ModifiedUserIDColumn,
                                        detail.ModifiedDateColumn,
                                        detail.ActionColumn
                                        );

                ds.Tables.Add(header);
                ds.Tables.Add(detail);
                ds.SetColumnMappingType();
                return GetInvalidSalesOrderDetail(ds.GetBytesData());
            }
        }
        public static DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail(byte[] b)
        {
            return Instance.GetInvalidSalesOrderDetail(b);
        }

        public static DateTime GetDate(ObjectNames objectName, bool isOnline)
        {
            return GetDate((int)objectName, isOnline);
        }
        public static DateTime GetDate(int objectID, bool isOnline)
        {
            if (isOnline)
                return Instance.GetDate(objectID, isOnline);
            else
                return _local.GetDate(objectID, isOnline);
        }


        public static void SynchronizeSalesOrder(int id)
        {
            SynchronizeSalesOrder(id, null, null);
        }
        public static void SynchronizeSalesOrder(int id, DataTable cardhandle, DataTable operation)
        {
            var serverDateTime = SynchronizationManager.GetDate(ObjectNames.None, true);
            var header = id == 0 ? SalesManager.GetSalesOrderHeader(serverDateTime.Date, false) : SalesManager.GetSalesOrderHeader(id, false);
            var detail = id == 0 ? SalesManager.GetSalesOrderDetail(serverDateTime.Date, false) : SalesManager.GetSalesOrderDetail(id, false);
            if (cardhandle == null) cardhandle = id == 0 ? CardManager.GetCardHandle(serverDateTime.Date, false) : CardManager.GetCardHandle(id, false);
            if (operation == null) operation = new DS_Operation.T_OperationDataTable();


            using (var ds = new DataSet("root"))
            {
                header.RemoveColumns(true,
                                        header.SalesOrderIDColumn,
                                        header.BranchIDColumn,
                                        header.OrderDateColumn,
                                        header.OverheadNumberColumn,
                                        header.CustomerIDColumn,
                                        header.SubTotalColumn,
                                        header.TaxAmtColumn,
                                        header.FreightColumn,
                                        header.CurrencyCodeColumn,
                                        header.CurrencyRateIDColumn,
                                        header.PaymentMethodIDColumn,
                                        header.RevisionNumberColumn,
                                        header.StatusColumn,
                                        header.ModifiedUserIDColumn,
                                        header.ModifiedDateColumn,
                                        header.ApproverUserIDColumn,
                                        header.rowguidColumn
                                        );

                detail.RemoveColumns( true, detail.SalesOrderDetailIDColumn,
                                        detail.SalesOrderIDColumn,
                                        detail.ProductLocationIDColumn,
                                        detail.SaleQtyColumn,
                                        detail.UnitPriceColumn,
                                        detail.UnitPriceDiscountColumn,
                                        detail.OrdinalNumberColumn,
                                        detail.ModifiedUserIDColumn,
                                        detail.ModifiedDateColumn,
                                        detail.ActionColumn
                                        );

                ds.Tables.Add(header);
                ds.Tables.Add(detail);
                ds.Tables.Add(cardhandle);
                ds.Tables.Add(operation);
                ds.SetColumnMappingType();
                Synchronize(ObjectNames.SalesOrderHeader, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Synchronize, true, ds.GetBytesData());


                ds.Tables.Remove(detail);
                ds.Tables.Remove(cardhandle);
                ds.Tables.Remove(operation);
                header.RemoveColumns(true, header.SalesOrderIDColumn);
                Synchronize(ObjectNames.SalesOrderHeader, BaseGlobalVariable.UserID, BaseGlobalVariable.ServerDateTime, DatabaseAction.Synchronize, false, ds.GetBytesData());
            }
        }

        public static int Synchronize(ObjectNames objectName, int modifiedUserID, DateTime modifiedDate, DatabaseAction action, bool isOnline, byte[] b)
        {
            return Synchronize((int)objectName, modifiedUserID, modifiedDate, (int)action, isOnline, b);
        }
        public static int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b)
        {
            if (isOnline)
                return Instance.Synchronize(objectID, modifiedUserID, modifiedDate, action, isOnline, b);
            else
                return _local.Synchronize(objectID, modifiedUserID, modifiedDate, action, isOnline, b);
        }
    }
}
