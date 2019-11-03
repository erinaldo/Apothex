using System;
using Apothex.DataType;

namespace Apothex.Contracts.Synchronization
{
    interface ISynchronization
    {
        DS_Synchronization.SP_GetSyncBranchDataTable GetSyncBranch(int branchID, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncUserDataTable GetSyncUser(int userID, int branchID, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncUserPermissionDataTable GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncMyCompanyDataTable GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncCurrencyDataTable GetSyncCurrency(string currencyCode, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncPaymentMethodDataTable GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, int action);
        DS_Synchronization.SP_GetSyncProductLocationDataTable GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, int action);
        DS_Synchronization.DD_CardUnitRateDataTable GetSyncCardUnitRate();
        DS_Synchronization.DD_CardDiscountSchemaDataTable GetSyncCardDiscountSchema();
        DS_Synchronization.DD_OperationTypeDataTable GetOperationType();

        DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail(byte[] b);

        DateTime GetDate(int objectID, bool isOnline);

        int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b);
    }
}
