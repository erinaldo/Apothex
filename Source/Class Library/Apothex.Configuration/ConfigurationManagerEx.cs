using System.Drawing;
using System.Configuration;
using System.Globalization;
using Zek.Data;
using Zek.Security;
using Zek.Configuration;

namespace Apothex.Configuration
{
    public static class ConfigurationManagerEx
    {
        #region Security
        public const string Salt = "APOTHEX1";
        private const string Key = "ApothexKey!123?";
        private const string IV = "123!ApothexIV?";
        #endregion


        #region Database
        private static string _serverName = string.Empty;
        public static string ServerName
        {
            get { return _serverName; }
            set
            {
                if (value == null) value = string.Empty;
                _serverName = value;
            }
        }


        private static string _databaseName = string.Empty;
        public static string DatabaseName
        {
            get { return _databaseName; }
            set
            {
                if (value == null) value = string.Empty;
                _databaseName = value;
            }
        }


        private static string _userName = string.Empty;
        public static string UserName
        {
            get { return _userName; }
            set
            {
                if (value == null) value = string.Empty;
                _userName = value;
            }
        }


        private static string _password = string.Empty;
        public static string Password
        {
            get { return _password; }
            set
            {
                if (value == null) value = string.Empty;
                _password = value;
            }
        }


        private static int _connectionTimeout = 15;
        public static int ConnectionTimeout
        {
            get { return _connectionTimeout; }
            set
            {
                if (value <= 0) value = 15;
                _connectionTimeout = value;
            }
        }

        public static int CommandTimeout
        {
            get { return BaseAppConfig.OnlineCommandTimeout; }
            set { BaseAppConfig.OnlineCommandTimeout = value; }
        }

        public static string ConnectionString
        {
            get { return BaseAppConfig.OnlineConnectionString; }
            set { BaseAppConfig.OnlineConnectionString = value; }
        }
        #endregion


        #region OfflineMode
        private static string _offlineServerName = string.Empty;
        public static string OfflineServerName
        {
            get { return _offlineServerName; }
            set
            {
                if (value == null) value = string.Empty;
                _offlineServerName = value;
            }
        }


        private static string _offlineDatabaseName = string.Empty;
        public static string OfflineDatabaseName
        {
            get { return _offlineDatabaseName; }
            set
            {
                if (value == null) value = string.Empty;
                _offlineDatabaseName = value;
            }
        }


        private static string _offlineUserName = string.Empty;
        public static string OfflineUserName
        {
            get { return _offlineUserName; }
            set
            {
                if (value == null) value = string.Empty;
                _offlineUserName = value;
            }
        }


        private static string _offlinePassword = string.Empty;
        public static string OfflinePassword
        {
            get { return _offlinePassword; }
            set
            {
                if (value == null) value = string.Empty;
                _offlinePassword = value;
            }
        }


        private static int _offlineConnectionTimeout = 15;
        public static int OfflineConnectionTimeout
        {
            get { return _offlineConnectionTimeout; }
            set
            {
                if (value <= 0) value = 15;
                _offlineConnectionTimeout = value;
            }
        }


        public static int OfflineCommandTimeout
        {
            get { return BaseAppConfig.OfflineCommandTimeout; }
            set { BaseAppConfig.OfflineCommandTimeout = value; }
        }

        public static string OfflineConnectionString
        {
            get { return BaseAppConfig.OfflineConnectionString; }
            set { BaseAppConfig.OfflineConnectionString = value; }
        }
        #endregion


        #region Fields
        private static string _loginUserName = string.Empty;
        public static string LoginUserName
        {
            get { return _loginUserName; }
            set
            {
                if (value == null) value = string.Empty;
                _loginUserName = value;
            }
        }

        private static string _loginPassword = string.Empty;
        public static string LoginPassword
        {
            get { return _loginPassword; }
            set
            {
                if (value == null) value = string.Empty;
                _loginPassword = value;
            }
        }

        public static bool AutoNewRow { get; set; }
        public static bool OfflineMode { get; set; }

        private static bool _isOnline;
        public static bool IsOnline
        {
            get { return _isOnline || !OfflineMode; }
            set { _isOnline = value; }
        }
        public static string DynamicConnectionString
        {
            get { return (OfflineMode ? OfflineConnectionString : ConnectionString); }
        }
        public static int DynamicCommandTimeout
        {
            get { return (OfflineMode ? OfflineCommandTimeout : CommandTimeout); }
        }


        private static Font _defaultFont = new Font("BPG Glaho Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        public static Font DefaultFont
        {
            get { return _defaultFont; }
            set { _defaultFont = value; }
        }


        private static Font _labelDefaultFont = new Font("BPG Glaho Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        public static Font LabelDefaultFont
        {
            get { return _labelDefaultFont; }
            set { _labelDefaultFont = value; }
        }


        private static string _skinName = "Caramel";
        public static string SkinName
        {
            get { return _skinName; }
            set
            {
                if (value == null) value = "Caramel";
                _skinName = value;
            }
        }

        public static bool AllowFormSkins { get; set; }
        #endregion


        #region Hedgehog
        public static bool UseHedgehog { get; set; }


        private static string _hedgehogFile = string.Empty;
        public static string HedgehogFile
        {
            get { return _hedgehogFile; }
            set
            {
                if (value == null) value = string.Empty;
                _hedgehogFile = value;
            }
        }
        #endregion


        #region Methods
        public static void Load()
        {
            ServerName = GetStringValue("ServerName");
            DatabaseName = GetStringValue("DatabaseName");
            UserName = GetStringValue("UserName");
            ConnectionTimeout = GetIntValue("ConnectionTimeout");
            CommandTimeout = GetIntValue("CommandTimeout");

            var initCryptoFlag = false;
            if (GetStringValue("Password").Length > 0)
            {
                if (GetStringValue("Password") == "nOEilOowHR8=")
                {
                    initCryptoFlag = true;
                    Password = "123";
                }
                else
                    Password = SymCryptoHelper.TripleDESDecrypt(GetStringValue("Password"), Salt, Key, IV);
            }

            LoginUserName = GetStringValue("LoginUserName");
            LoginPassword = GetStringValue("LoginPassword");

            AutoNewRow = GetBoolValue("AutoNewRow");
            OfflineMode = GetBoolValue("OfflineMode");

            OfflineServerName = GetStringValue("OfflineServerName");
            OfflineDatabaseName = GetStringValue("OfflineDatabaseName");
            OfflineUserName = GetStringValue("OfflineUserName");
            OfflineConnectionTimeout = GetIntValue("OfflineConnectionTimeout");
            OfflineCommandTimeout = GetIntValue("OfflineCommandTimeout");
            if (GetStringValue("OfflinePassword").Length > 0)
            {
                if (GetStringValue("OfflinePassword") == "nOEilOowHR8=")
                {
                    initCryptoFlag = true;
                    OfflinePassword = "123";
                }
                else
                    OfflinePassword = SymCryptoHelper.TripleDESDecrypt(GetStringValue("OfflinePassword"), Salt, Key, IV);
            }


            SkinName = GetStringValue("SkinName");
            AllowFormSkins = GetBoolValue("AllowFormSkins");


            UseHedgehog = GetBoolValue("UseHedgehog");
            HedgehogFile = GetStringValue("HedgehogFile");

            if (initCryptoFlag)
                Save();

            BuilderConnectionStrings();
        }
        public static void Save()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            SetValue(config, "ServerName", ServerName);
            SetValue(config, "DatabaseName", DatabaseName);
            SetValue(config, "UserName", UserName);
            SetValue(config, "ConnectionTimeout", ConnectionTimeout.ToString(CultureInfo.InvariantCulture));
            SetValue(config, "CommandTimeout", CommandTimeout.ToString(CultureInfo.InvariantCulture));
            var value = (Password.Length > 0) ? SymCryptoHelper.TripleDESEncrypt(Password, Salt, Key, IV) : string.Empty;
            SetValue(config, "Password", value);

            SetValue(config, "LoginUserName", LoginUserName);
            SetValue(config, "LoginPassword", LoginPassword);

            SetValue(config, "AutoNewRow", AutoNewRow);
            SetValue(config, "OfflineMode", OfflineMode);

            SetValue(config, "OfflineServerName", OfflineServerName);
            SetValue(config, "OfflineDatabaseName", OfflineDatabaseName);
            SetValue(config, "OfflineUserName", OfflineUserName);
            SetValue(config, "OfflineConnectionTimeout", OfflineConnectionTimeout.ToString(CultureInfo.InvariantCulture));
            SetValue(config, "OfflineCommandTimeout", OfflineCommandTimeout.ToString(CultureInfo.InvariantCulture));
            value = (OfflinePassword.Length > 0) ? SymCryptoHelper.TripleDESEncrypt(OfflinePassword, Salt, Key, IV) : string.Empty;
            SetValue(config, "OfflinePassword", value);


            SetValue(config, "SynchronizationProvider", GetStringValue("SynchronizationProvider"));
            SetValue(config, "WSSynchronizationUrl", GetStringValue("WSSynchronizationUrl"));
            SetValue(config, "WSUserName", GetStringValue("WSUserName"));
            SetValue(config, "WSPassword", GetStringValue("WSPassword"));
            SetValue(config, "WSDomain", GetStringValue("WSDomain"));


            SetValue(config, "SkinName", SkinName);
            SetValue(config, "AllowFormSkins", AllowFormSkins);

            SetValue(config, "UseHedgehog", UseHedgehog);
            SetValue(config, "HedgehogFile", HedgehogFile);


            config.Save();
            BuilderConnectionStrings();
        }

        private static void BuilderConnectionStrings()
        {

            ConnectionString = SqlConnectionStringHelper.GetConnectionString(ServerName, DatabaseName, UserName, Password, "Apothex", true, ConnectionTimeout);
            OfflineConnectionString = SqlConnectionStringHelper.GetConnectionString(OfflineServerName, OfflineDatabaseName, OfflineUserName, OfflinePassword, "Apothex", true, OfflineConnectionTimeout);
        }

        private static bool GetBoolValue(string key)
        {
            return AppConfigHelper.GetBool(key);
        }
        private static int GetIntValue(string key)
        {
            return AppConfigHelper.GetInt32(key);
        }
        private static string GetStringValue(string key)
        {
            return AppConfigHelper.GetString(key);
        }

        private static void SetValue(System.Configuration.Configuration config, string key, string value)
        {
            AppConfigHelper.Set(config, key, value);
        }
        private static void SetValue(System.Configuration.Configuration config, string key, bool value)
        {
            AppConfigHelper.Set(config, key, value);
        }
        #endregion


        #region Synchronization
        private static string _synchronizationProvider;
        public static string SynchronizationProvider
        {
            get { return _synchronizationProvider; }
            set { _synchronizationProvider = value; }
        }
        public static string SynchronizationProviderType
        {
            get { return ConfigurationManager.AppSettings["SynchronizationProviderType"]; }
        }

        private static string _wsSynchronizationUrl;
        public static string WSSynchronizationUrl
        {
            get { return _wsSynchronizationUrl; }
            set { _wsSynchronizationUrl = value; }
        }

        //private static string _wsUserName;
        //public static string WSUserName
        //{
        //    get { return _wsUserName; }
        //    set { _wsUserName = value; }
        //}

        //private static string _wsPassword;
        //public static string WSPassword
        //{
        //    get { return _wsPassword; }
        //    set { _wsPassword = value; }
        //}

        //private static string _wsDomain;
        //public static string WSDomain
        //{
        //    get { return _wsDomain; }
        //    set { _wsDomain = value; }
        //}
        #endregion



        #region Providers
        public static string BranchProvider
        {
            get { return ConfigurationManager.AppSettings["BranchProvider"]; }
        }
        public static string BranchProviderType
        {
            get { return ConfigurationManager.AppSettings["BranchProviderType"]; }
        }

        public static string DataProvider
        {
            get { return ConfigurationManager.AppSettings["DataProvider"]; }
        }
        public static string DataProviderType
        {
            get { return ConfigurationManager.AppSettings["DataProviderType"]; }
        }

        public static string MedicamentProvider
        {
            get { return ConfigurationManager.AppSettings["MedicamentProvider"]; }
        }
        public static string MedicamentProviderType
        {
            get { return ConfigurationManager.AppSettings["MedicamentProviderType"]; }
        }

        public static string OrderProvider
        {
            get { return ConfigurationManager.AppSettings["OrderProvider"]; }
        }
        public static string OrderProviderType
        {
            get { return ConfigurationManager.AppSettings["OrderProviderType"]; }
        }

        public static string PurchasingProvider
        {
            get { return ConfigurationManager.AppSettings["PurchasingProvider"]; }
        }
        public static string PurchasingProviderType
        {
            get { return ConfigurationManager.AppSettings["PurchasingProviderType"]; }
        }

        public static string SalesProvider
        {
            get { return ConfigurationManager.AppSettings["SalesProvider"]; }
        }
        public static string SalesProviderType
        {
            get { return ConfigurationManager.AppSettings["SalesProviderType"]; }
        }

        public static string DictionaryProvider
        {
            get { return ConfigurationManager.AppSettings["DictionaryProvider"]; }
        }
        public static string DictionaryProviderType
        {
            get { return ConfigurationManager.AppSettings["DictionaryProviderType"]; }
        }

        public static string ProductLocationProvider
        {
            get { return ConfigurationManager.AppSettings["ProductLocationProvider"]; }
        }
        public static string ProductLocationProviderType
        {
            get { return ConfigurationManager.AppSettings["ProductLocationProviderType"]; }
        }

        public static string PersonProvider
        {
            get { return ConfigurationManager.AppSettings["PersonProvider"]; }
        }
        public static string PersonProviderType
        {
            get { return ConfigurationManager.AppSettings["PersonProviderType"]; }
        }

        public static string UserProvider
        {
            get { return ConfigurationManager.AppSettings["UserProvider"]; }
        }
        public static string UserProviderType
        {
            get { return ConfigurationManager.AppSettings["UserProviderType"]; }
        }

        public static string RequestProvider
        {
            get { return ConfigurationManager.AppSettings["RequestProvider"]; }
        }
        public static string RequestProviderType
        {
            get { return ConfigurationManager.AppSettings["RequestProviderType"]; }
        }

        public static string HedgehogProvider
        {
            get { return ConfigurationManager.AppSettings["HedgehogProvider"]; }
        }
        public static string HedgehogProviderType
        {
            get { return ConfigurationManager.AppSettings["HedgehogProviderType"]; }
        }

        public static string CardProvider
        {
            get { return ConfigurationManager.AppSettings["CardProvider"]; }
        }
        public static string CardProviderType
        {
            get { return ConfigurationManager.AppSettings["CardProviderType"]; }
        }

        public static string CardPointTransferProvider
        {
            get { return ConfigurationManager.AppSettings["CardPointTransferProvider"]; }
        }
        public static string CardPointTransferProviderType
        {
            get { return ConfigurationManager.AppSettings["CardPointTransferProviderType"]; }
        }


        public static string OperationProvider
        {
            get { return ConfigurationManager.AppSettings["OperationProvider"]; }
        }
        public static string OperationProviderType
        {
            get { return ConfigurationManager.AppSettings["OperationProviderType"]; }
        }

        public static string CashboxProvider
        {
            get { return ConfigurationManager.AppSettings["CashboxProvider"]; }
        }
        public static string CashboxProviderType
        {
            get { return ConfigurationManager.AppSettings["CashboxProviderType"]; }
        }

        public static string AccountingProvider
        {
            get { return ConfigurationManager.AppSettings["AccountingProvider"]; }
        }
        public static string AccountingProviderType
        {
            get { return ConfigurationManager.AppSettings["AccountingProviderType"]; }
        }

        public static string ConfigProvider
        {
            get { return ConfigurationManager.AppSettings["ConfigProvider"]; }
        }
        public static string ConfigProviderType
        {
            get { return ConfigurationManager.AppSettings["ConfigProviderType"]; }
        }
        #endregion
    }
}