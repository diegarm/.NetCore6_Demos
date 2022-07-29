using Microsoft.Extensions.DependencyInjection;
using VendingMachine.Application.Interface;
using VendingMachine.Application.Services;
using VendingMachine.CrossCutting.Bus;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Infra.Data.Context;
using VendingMachine.Infra.Data.EventStoring;
using VendingMachine.Infra.Data.Repository;
using VendingMachine.Infra.Data.Repository.EventStoring;

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
            services.AddScoped<ITransactionService, TransactionService>();
        }
        
        public static void RegisterEvents(IServiceCollection services)
        {
        }

        public static void RegisterData(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISoldRepository, SoldRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
        }

        public static void RegisterDataEventSourcing(IServiceCollection services)
        {
            services.AddScoped<IEventStoreRepository, EventStoreRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreContext>();
        }

    }
}