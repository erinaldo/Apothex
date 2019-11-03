namespace Apothex.Contracts.Config
{
    public abstract class ConfigProvider : IConfig
    {
        public abstract string Get(string name);
    }
}
