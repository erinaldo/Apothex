namespace Apothex.Contracts.Accounting
{
    public abstract class AccountingProvider : IAccounting
    {
        public abstract string GetAutoNumber(string name, int? year, int? branchID);
    }
}
