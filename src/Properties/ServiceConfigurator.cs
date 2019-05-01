using RestoreMonarchy.TeleportationPlugin.Requests;
using Rocket.API.DependencyInjection;

namespace RestoreMonarchy.TeleportationPlugin.Properties
{
    public class ServiceConfigurator : IServiceConfigurator
    {
        public void ConfigureServices(IDependencyContainer container)
        {
            container.AddSingleton<ITeleportationRequestManager, TeleportationRequestManager>();
        }
    }
}
