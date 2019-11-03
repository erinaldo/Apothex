using Apothex.DataType;
using Apothex.DataType.DS_OperationTableAdapters;
using Apothex.Configuration;
using Apothex.Contracts.Operation;
using Zek.Data;

namespace Apothex.SqlDataAccess.Operation
{
    public sealed class SqlOperationProvider : OperationProvider
    {
        public override DS_Operation.T_OperationDataTable Get(string objectName, int? id)
        {
            using (var adapter = T_OperationTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(objectName, id);
            }
        }
        public override int Save(string objectName, int? id, byte[] b)
        {
            using (var adapter = OperationQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_T_Operation_Save(objectName, id, b.GetXmlData());
            }
        }
    }
}
