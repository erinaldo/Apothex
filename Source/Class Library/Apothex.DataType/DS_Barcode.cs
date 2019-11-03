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
namespace Apothex.DataType.DS_BarcodeTableAdapters
{
    public partial class SP_GetBarcodeTableAdapter
    {
        public static SP_GetBarcodeTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetBarcodeTableAdapter();
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

    public partial class SP_IsValidBarcodeTableAdapter
    {
        public static SP_IsValidBarcodeTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_IsValidBarcodeTableAdapter();
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
}
