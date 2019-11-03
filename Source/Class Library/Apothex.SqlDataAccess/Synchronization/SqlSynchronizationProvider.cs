using System;
using Apothex.Contracts.Synchronization;
using Apothex.DataType.DS_SynchronizationTableAdapters;
using Apothex.DataType;
using Zek.Data;
using Apothex.Configuration;
using Apothex.DataType.DS_SyncSalesOrderDetailTableAdapters;

namespace Apothex.SqlDataAccess.Synchronization
{
    public sealed class SqlSynchronizationProvider : SynchronizationProvider
    {
        public override DS_Synchronization.SP_GetSyncBranchDataTable GetSyncBranch(int branchID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncBranchTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(branchID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncUserDataTable GetSyncUser(int userID, int branchID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncUserTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(userID, branchID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncUserPermissionDataTable GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncUserPermissionTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(userID, branchID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncMyCompanyDataTable GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncMyCompanyTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(myCompanyID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncCurrencyDataTable GetSyncCurrency(string currencyCode, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncCurrencyTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(currencyCode, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncPaymentMethodDataTable GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncPaymentMethodTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(paymentMethodID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.SP_GetSyncProductLocationDataTable GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, int action)
        {
            using (var adapter = SP_GetSyncProductLocationTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(productLocationID, productID, branchID, modifiedDate, action);
            }
        }
        public override DS_Synchronization.DD_CardUnitRateDataTable GetSyncCardUnitRate()
        {
            using (var adapter = DD_CardUnitRateTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData();
            }
        }
        public override DS_Synchronization.DD_CardDiscountSchemaDataTable GetSyncCardDiscountSchema()
        {
            using (var adapter = DD_CardDiscountSchemaTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData();
            }
        }
        public override DS_Synchronization.DD_OperationTypeDataTable GetOperationType()
        {
            using (var adapter = DD_OperationTypeTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData();
            }
        }

        public override DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail(byte[] b)
        {
            using (var adapter = T_SalesOrderDetail_InvalidTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(b.GetXmlData());
            }
        }

        public override DateTime GetDate(int objectID, bool isOnline)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SynchronizationQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (DateTime)adapter.SP_GetDate(objectID);
            }
        }

        public override int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b)
        {
            var connectionString = (isOnline ? ConfigurationManagerEx.ConnectionString : ConfigurationManagerEx.OfflineConnectionString);
            var commandTimeout = (isOnline ? ConfigurationManagerEx.CommandTimeout : ConfigurationManagerEx.OfflineCommandTimeout);

            using (var adapter = SynchronizationQueriesAdapter.CreateInstance(connectionString, commandTimeout))
            {
                return (int)adapter.SP_Synchronize(objectID, modifiedUserID, modifiedDate, action, b.GetXmlData());
            }
        }
    }
}
