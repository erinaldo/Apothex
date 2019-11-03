using System.Data.SqlClient;

namespace Apothex.DataType
{


    public partial class DS_Medicament
    {
    }
}

namespace Apothex.DataType.DS_MedicamentTableAdapters
{


    public partial class SP_GetMedicamentTableAdapter
    {
        public static SP_GetMedicamentTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetMedicamentTableAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (var cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }

    public partial class MedicamentQueriesAdapter
    {
        public static MedicamentQueriesAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new MedicamentQueriesAdapter();
            if (string.IsNullOrEmpty(connectionString)) return adapter;
            foreach (SqlCommand cmd in adapter.CommandCollection)
            {
                cmd.Connection.ConnectionString = connectionString;
                cmd.CommandTimeout = commandTimeout;
            }

            return adapter;
        }
    }
}
