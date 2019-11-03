namespace Apothex.Contracts.Offline
{
    public abstract class OfflineProvider : IOffline
    {
        public abstract void SyncBranch();
    }
}
