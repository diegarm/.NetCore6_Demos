using VendingMachine.CrossCutting.IoC;

namespace VendingMachine.Services.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));

            DependencyInjection.RegisterMediator(services);
            DependencyInjection.RegisterApplication(services);
            DependencyInjection.RegisterEvents(services);            
            DependencyInjection.RegisterData(services);
            DependencyInjection.RegisterDataEventSourcing(services);

        }

        

    }
}
