using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_SynchronizationTableAdapters
{

    public partial class SP_GetSyncBranchTableAdapter
    {
        public static SP_GetSyncBranchTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncBranchTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncUserTableAdapter
    {
        public static SP_GetSyncUserTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncUserTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncUserPermissionTableAdapter
    {
        public static SP_GetSyncUserPermissionTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncUserPermissionTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncMyCompanyTableAdapter
    {
        public static SP_GetSyncMyCompanyTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncMyCompanyTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncCurrencyTableAdapter
    {
        public static SP_GetSyncCurrencyTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncCurrencyTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncPaymentMethodTableAdapter
    {
        public static SP_GetSyncPaymentMethodTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncPaymentMethodTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SP_GetSyncProductLocationTableAdapter
    {
        public static SP_GetSyncProductLocationTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetSyncProductLocationTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class SynchronizationQueriesAdapter
    {
        public static string GetConnectionString()
        {
            var adapter = new SynchronizationQueriesAdapter();
            return adapter.CommandCollection[0].Connection.ConnectionString;
        }

        public static SynchronizationQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SynchronizationQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class DD_CardDiscountSchemaTableAdapter
    {
        public static DD_CardDiscountSchemaTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_CardDiscountSchemaTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class DD_CardUnitRateTableAdapter
    {
        public static DD_CardUnitRateTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_CardUnitRateTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    public partial class DD_OperationTypeTableAdapter
    {
        public static DD_OperationTypeTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_OperationTypeTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}