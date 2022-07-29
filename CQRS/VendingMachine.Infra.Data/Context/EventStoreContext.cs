using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Events;
using VendingMachine.Infra.Data.Configuration;

namespace VendingMachine.Infra.Data.Context
{
    public class EventStoreContext : DbContext
    {
        public EventStoreContext(DbContextOptions<EventStoreContext> options) : base(options) { }
        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
