using System.Data.SqlClient;

namespace Apothex.DataType.DS_DictionaryTableAdapters
{
}
namespace Apothex.DataType.DS_DictionaryTableAdapters
{
    public partial class SP_GetDictionaryTableAdapter
    {
        public static SP_GetDictionaryTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetDictionaryTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetDictionaryIntTableAdapter
    {
        public static SP_GetDictionaryIntTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetDictionaryIntTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class DictionaryQueriesAdapter
    {
        public static DictionaryQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new DictionaryQueriesAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (SqlCommand cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class SP_GetButtonBrowseTableAdapter
    {
        public static SP_GetButtonBrowseTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetButtonBrowseTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class SP_GetBankTableAdapter
    {
        public static SP_GetBankTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetBankTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetCountryTableAdapter
    {
        public static SP_GetCountryTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetCountryTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }






    public partial class SP_GetMedicamentCategoryTableAdapter
    {
        public static SP_GetMedicamentCategoryTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMedicamentCategoryTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetMedicamentSubcategoryTableAdapter
    {
        public static SP_GetMedicamentSubcategoryTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMedicamentSubcategoryTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetPaymentMethodTableAdapter
    {
        public static SP_GetPaymentMethodTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetPaymentMethodTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetUnitMeasureTableAdapter
    {
        public static SP_GetUnitMeasureTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetUnitMeasureTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetMedicamentsTableAdapter
    {
        public static SP_GetMedicamentsTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMedicamentsTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }


    public partial class SP_GetBrandTableAdapter
    {
        public static SP_GetBrandTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetBrandTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetMergeMedicamentTableAdapter
    {
        public static SP_GetMergeMedicamentTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMergeMedicamentTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class SP_GetGenericTableAdapter
    {
        public static SP_GetGenericTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetGenericTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}namespace Apothex.DataType {
    
    
    public partial class DS_Dictionary {
    }
}
