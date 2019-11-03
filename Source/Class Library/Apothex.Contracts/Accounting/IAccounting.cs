namespace Apothex.Contracts.Accounting
{
    interface IAccounting
    {
        string GetAutoNumber(string name, int? year, int? branchID);
    }
}
