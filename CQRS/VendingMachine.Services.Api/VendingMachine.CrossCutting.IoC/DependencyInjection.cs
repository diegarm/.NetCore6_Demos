using Microsoft.Extensions.DependencyInjection;
using VendingMachine.CrossCutting.Bus;
using VendingMachine.CrossCutting.Bus.Interfaces;

namespace VendingMachine.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static void RegisterMediator(IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, InMemoryBus>();
        }
        public static void RegisterApplication(IServiceCollection services)
        {
        }
        
        public static void RegisterEvents(IServiceCollection services)
        {
        }

        public static void RegisterData(IServiceCollection services)
        {
        }

        public static void RegisterDataEventSourcing(IServiceCollection services)
        {
        }

    }
}