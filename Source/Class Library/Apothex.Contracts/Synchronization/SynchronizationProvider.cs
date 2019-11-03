using System;
using Apothex.DataType;

namespace Apothex.Contracts.Synchronization
{
    public abstract class SynchronizationProvider : ISynchronization
    {
        public abstract DS_Synchronization.SP_GetSyncBranchDataTable GetSyncBranch(int branchID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncUserDataTable GetSyncUser(int userID, int branchID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncUserPermissionDataTable GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncMyCompanyDataTable GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncCurrencyDataTable GetSyncCurrency(string currencyCode, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncPaymentMethodDataTable GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.SP_GetSyncProductLocationDataTable GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, int action);
        public abstract DS_Synchronization.DD_CardUnitRateDataTable GetSyncCardUnitRate();
        public abstract DS_Synchronization.DD_CardDiscountSchemaDataTable GetSyncCardDiscountSchema();
        public abstract DS_Synchronization.DD_OperationTypeDataTable GetOperationType();

        public abstract DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail(byte[] b);

        public abstract DateTime GetDate(int objectID, bool isOnline);

        public abstract int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b);
    }
}
