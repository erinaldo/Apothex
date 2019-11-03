using System;
using Apothex.Configuration;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace Apothex.Xpo
{
    public static class XpoHelper
    {
        #region Fiels
        public static string ConnectionString
        {
            get
            {
                return (ConfigurationManagerEx.UserName.Length > 0 ? MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.ServerName, ConfigurationManagerEx.UserName, ConfigurationManagerEx.Password, ConfigurationManagerEx.DatabaseName) : MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.ServerName, ConfigurationManagerEx.DatabaseName));
            }
        }
        #endregion

        public static void InitXpo(bool isOnline)
        {
            XpoDefault.DataLayer = GetDataLayer(isOnline);
            XpoDefault.Session = null;
        }

        public static IDataLayer GetDataLayer(bool isOnline)
        {
            return XpoDefault.GetDataLayer(GetConnectionString(isOnline), AutoCreateOption.None);
        }

        public static string GetConnectionString(bool isOnline)
        {
            if (isOnline)
                return (ConfigurationManagerEx.UserName.Length > 0 ? MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.ServerName, ConfigurationManagerEx.UserName, ConfigurationManagerEx.Password, ConfigurationManagerEx.DatabaseName) : MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.ServerName, ConfigurationManagerEx.DatabaseName));
            else
                return (ConfigurationManagerEx.OfflineUserName.Length > 0 ? MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.OfflineServerName, ConfigurationManagerEx.OfflineUserName, ConfigurationManagerEx.OfflinePassword, ConfigurationManagerEx.OfflineDatabaseName) : MSSqlConnectionProvider.GetConnectionString(ConfigurationManagerEx.OfflineServerName, ConfigurationManagerEx.OfflineDatabaseName));
        }

        public static void Fill(ref Session session, Type classType, ref XPServerCollectionSource xpServerCollectionSource, string fixedFilterString)
        {
            Fill(ref session, classType, ref xpServerCollectionSource, fixedFilterString, true);
        }
        public static void Fill(ref Session session, Type classType, ref XPServerCollectionSource xpServerCollectionSource, string fixedFilterString, bool isOnline)
        {
            //InitXpo(isOnline);

            if (session == null)
            {
                // Create a Session object.
                session = new Session(GetDataLayer(isOnline));

                // Create an XPClassInfo object corresponding to the Person_Contact class.
                var classInfo = session.GetClassInfo(classType);


                // Create an XPServerCollectionSource object.
                xpServerCollectionSource = new XPServerCollectionSource(session, classInfo);
                xpServerCollectionSource.FixedFilterString = fixedFilterString;

                //session.DropCache();
                //xpServerCollectionSource.Reload();
            }
            else
            {
                xpServerCollectionSource.FixedFilterString = fixedFilterString;
                xpServerCollectionSource.Reload();
            }
        }
    }
}
