using Nancy.Test.Performance.Modules;
using Nancy.Testing;

namespace Tests
{
    public static class BootstrapConfigurator
    {
        public static void DefaultBootstrap(ConfigurableBootstrapper.ConfigurableBootstrapperConfigurator config)
        {
            config.RootPathProvider(new NunitTestRootPathProvider());
            config.Module<DefaultModule>();
        }
    }
}