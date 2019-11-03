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
namespace Apothex.DataType
{
}
namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_CardTableAdapters
{


    partial class DD_CardTypeTableAdapter
    {
        public static DD_CardTypeTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_CardTypeTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class DD_CardDiscountSchemaTableAdapter
    {
        public static DD_CardDiscountSchemaTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_CardDiscountSchemaTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class DD_CardUnitRateTableAdapter
    {
        public static DD_CardUnitRateTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DD_CardUnitRateTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class T_CardTableAdapter
    {
        public static T_CardTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_CardTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class CardQueriesAdapter
    {
        public static CardQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new CardQueriesAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class VW_CardInfoTableAdapter
    {
        public static VW_CardInfoTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_CardInfoTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class T_CardHandleTableAdapter
    {
        public static T_CardHandleTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_CardHandleTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class VW_CardHandleTableAdapter
    {
        public static VW_CardHandleTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_CardHandleTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class T_BonusAccumulationTableAdapter
    {
        public static T_BonusAccumulationTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new T_BonusAccumulationTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class VW_BonusAccumulationTableAdapter
    {
        public static VW_BonusAccumulationTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_BonusAccumulationTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }
}