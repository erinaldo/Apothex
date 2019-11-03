using Apothex.DataType;

namespace Apothex.Contracts.Branch
{
    public abstract class BranchProvider : IBranch
    {
        public abstract DS_Branch.DD_BranchDataTable Get(int? id);
        public abstract int Save(int? id, string code, string name, string address, string phone, string fax, string actFormat, int? companyID, int? modifierID);
        public abstract bool IsValidCode(int? id, string code);
    }
}
