using System.Data.SqlClient;

namespace Apothex.DataType.DS_CloseDayTableAdapters
{

    public partial class SP_GetCloseDayTableAdapter
    {
        public static SP_GetCloseDayTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetCloseDayTableAdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (var cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }

    public partial class CloseDayQueriesdapter
    {
        public static CloseDayQueriesdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new CloseDayQueriesdapter();
            if (!string.IsNullOrEmpty(connectionString))
            {
                foreach (SqlCommand cmd in adapter.CommandCollection)
                {
                    cmd.Connection.ConnectionString = connectionString;
                    cmd.CommandTimeout = commandTimeout;
                }
            }

            return adapter;
        }
    }
}

namespace Apothex.DataType {
    
    
    public partial class DS_CloseDay {
    }
}
