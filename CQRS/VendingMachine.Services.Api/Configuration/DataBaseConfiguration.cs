using Microsoft.EntityFrameworkCore;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Services.Api.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));

            services.AddDbContext<VendingMachineContext>(opt => opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            services.AddDbContext<EventStoreContext>(opt => opt.UseInMemoryDatabase(Guid.NewGuid().ToString()));
            
        }
    }
}
