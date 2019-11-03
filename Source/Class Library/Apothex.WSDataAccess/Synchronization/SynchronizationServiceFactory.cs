using Apothex.Configuration;
using System.Net;
using Zek.Configuration;

namespace Apothex.WSDataAccess.Synchronization
{
    public static class SynchronizationServiceFactory
    {
        public static WSSynchronization CreateProxy()
        {
            var proxy = new WSSynchronization();
            proxy.Url = ConfigurationManagerEx.WSSynchronizationUrl;
            if (AppConfigHelper.GetString("WSUserName").Length > 0)
                proxy.Credentials = new NetworkCredential(AppConfigHelper.GetString("WSUserName"), AppConfigHelper.GetString("WSPassword"), AppConfigHelper.GetString("WSDomain"));
            else
                proxy.Credentials = new NetworkCredential("WSApothexUser", "WSApothexPassword1!2@", string.Empty);
            return proxy;
        }
    }
}
