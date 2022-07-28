using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Events;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Configuration;

namespace VendingMachine.Infra.Data.Context
{
    public class EventStoreContext : DbContext
    {
        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
