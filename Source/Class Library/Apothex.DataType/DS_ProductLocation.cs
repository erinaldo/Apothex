using Zek.Data;

namespace Apothex.DataType
{
}
namespace Apothex.DataType.DS_ProductLocationTableAdapters
{

    partial class VW_ProductLocationTableAdapter
    {
        public static VW_ProductLocationTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new VW_ProductLocationTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

    partial class SP_GetProductLocationQuantityTableAdapter
    {
        public static SP_GetProductLocationQuantityTableAdapter CreateInstance(string connectionString, int commandTimeout)
        {
            var adapter = new SP_GetProductLocationQuantityTableAdapter();
            TableAdapterHelper.CreateInstance(adapter.CommandCollection, connectionString, commandTimeout);
            return adapter;
        }
    }

}namespace Apothex.DataType {
    
    
    public partial class DS_ProductLocation {
    }
}
namespace Apothex.DataType {
    
    
    public partial class DS_ProductLocation {
    }
}
