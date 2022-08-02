using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using VendingMachine.Infra.Data.Context;
using VendingMachine.Infra.Data.Repository;

namespace VendingMachine.Services.Api.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));

            services.AddDbContext<VendingMachineContext>(
                context => context.UseInMemoryDatabase("VendingMachineContext")
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                );
        

            services.AddDbContext<EventStoreContext>(
                context => context.UseInMemoryDatabase("EventStoreContext")
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                );

        }
    }
}
