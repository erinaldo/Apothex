using Apothex.Contracts.Config;
using Apothex.Configuration;
using Apothex.SqlDataAccess.Cashbox;
using Apothex.DataType;
using Zek.Extensions;

namespace Apothex.DataManagment.Config
{
    public static class ConfigManager
    {
        #region Fields
        private static object sync = new object();
        private static ConfigProvider _instance;
        private static ConfigProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (sync)
                    {
                        if (_instance == null)
                        {
                            switch (ConfigurationManagerEx.ConfigProvider)
                            {
                                case "WebService":
                                case "SqlDataBase":
                                default: //SqlDataBase
                                    _instance = new SqlConfigProvider();
                                    break;
                            }
                        }
                    }
                }
                return _instance;
            }
        }
        #endregion

        public static string GetString(ConfigName configName)
        {
            return Get(configName.ToString());
        }
        public static bool GetBool(ConfigName configName)
        {
            return Get(configName.ToString()).ToBoolean();
        }
        public static int GetInt32(ConfigName configName)
        {
            return Get(configName.ToString()).ToInt32();
        }

        private static string Get(string name)
        {
            return Instance.Get(name);
        }
    }
}
