using System;
using Apothex.Contracts.Synchronization;
using Apothex.DataType;
using System.Data;
using Zek.Data.Serialization;

namespace Apothex.WSDataAccess.Synchronization
{
    public sealed class WSSynchronizationProvider : SynchronizationProvider
    {
        private static T Convert<T>(byte[] bytes) where T : DataTable
        {
            return SerializationHelper.DeserializeXml<T>(bytes, true);
        }

        public override DS_Synchronization.SP_GetSyncBranchDataTable GetSyncBranch(int branchID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncBranchDataTable>(proxy.GetSyncBranch(branchID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncUserDataTable GetSyncUser(int userID, int branchID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncUserDataTable>(proxy.GetSyncUser(userID, branchID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncUserPermissionDataTable GetSyncUserPermission(int userID, int branchID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncUserPermissionDataTable>(proxy.GetSyncUserPermission(userID, branchID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncMyCompanyDataTable GetSyncMyCompany(int myCompanyID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncMyCompanyDataTable>(proxy.GetSyncMyCompany(myCompanyID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncCurrencyDataTable GetSyncCurrency(string currencyCode, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncCurrencyDataTable>(proxy.GetSyncCurrency(currencyCode, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncPaymentMethodDataTable GetSyncPaymentMethod(int paymentMethodID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncPaymentMethodDataTable>(proxy.GetSyncPaymentMethod(paymentMethodID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.SP_GetSyncProductLocationDataTable GetSyncProductLocation(int productLocationID, int productID, int branchID, DateTime modifiedDate, int action)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.SP_GetSyncProductLocationDataTable>(proxy.GetSyncProductLocation(productLocationID, productID, branchID, modifiedDate, action));
            }
        }

        public override DS_Synchronization.DD_CardUnitRateDataTable GetSyncCardUnitRate()
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.DD_CardUnitRateDataTable>(proxy.GetSyncCardUnitRate());
            }
        }

        public override DS_Synchronization.DD_CardDiscountSchemaDataTable GetSyncCardDiscountSchema()
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.DD_CardDiscountSchemaDataTable>(proxy.GetSyncCardDiscountSchema());
            }
        }

        public override DS_Synchronization.DD_OperationTypeDataTable GetOperationType()
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_Synchronization.DD_OperationTypeDataTable>(proxy.GetOperationType());
            }
        }

        public override DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable GetInvalidSalesOrderDetail(byte[] b)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return Convert<DS_SyncSalesOrderDetail.T_SalesOrderDetail_InvalidDataTable>(proxy.GetInvalidSalesOrderDetail(b));
            }
        }

        public override DateTime GetDate(int objectID, bool isOnline)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return proxy.GetDate(objectID, isOnline);
            }
        }

        public override int Synchronize(int objectID, int modifiedUserID, DateTime modifiedDate, int action, bool isOnline, byte[] b)
        {
            using (var proxy = SynchronizationServiceFactory.CreateProxy())
            {
                return proxy.Synchronize(objectID, modifiedUserID, modifiedDate, action, isOnline, b);
            }
        }
    }
}
