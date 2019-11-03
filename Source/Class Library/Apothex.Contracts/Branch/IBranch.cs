using Apothex.DataType;


namespace Apothex.Contracts.Branch
{
    interface IBranch
    {
        DS_Branch.DD_BranchDataTable Get(int? id);
        int Save(int? id, string code, string name, string address, string phone, string fax, string actFormat, int? companyID, int? modifierID);
        bool IsValidCode(int? id, string code);
    }
}
