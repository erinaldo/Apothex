using Apothex.DataType;
using Apothex.Configuration;
using Apothex.DataType.DS_BranchTableAdapters;
using Apothex.Contracts.Branch;

namespace Apothex.SqlDataAccess.Branch
{
    public sealed class SqlBranchProvider : BranchProvider
    {
        public override DS_Branch.DD_BranchDataTable Get(int? id)
        {
            using (var adapter = DD_BranchTableAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return adapter.GetData(id);
            }
        }
        public override int Save(int? id, string code, string name, string address, string phone, string fax, string actFormat, int? companyID, int? modifierID)
        {
            using (var adapter = BranchQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (int)adapter.SP_DD_Branch_Save(id, code, name, address, phone, fax, actFormat, companyID, modifierID);
            }
        }
        public override bool IsValidCode(int? id, string code)
        {
            using (var adapter = BranchQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (bool)adapter.SP_DD_Branch_IsValidCode(id, code);
            }
        }
    }
}
