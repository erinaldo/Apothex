using Apothex.Contracts.Config;
using Apothex.DataType.DS_ConfigurationTableAdapters;
using Apothex.Configuration;

namespace Apothex.SqlDataAccess.Cashbox
{
    public sealed class SqlConfigProvider : ConfigProvider
    {
        public override string Get(string name)
        {
            using (var adapter = ConfigurationQueriesAdapter.CreateInstance(ConfigurationManagerEx.ConnectionString, ConfigurationManagerEx.CommandTimeout))
            {
                return (string)adapter.SP_DD_Configuration_Get(name);
            }
        }
    }
}
