using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Events;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Configuration;
using VendingMachine.Infra.Data.Extension;

namespace VendingMachine.Infra.Data.Context
{
    public sealed class VendingMachineContext : DbContext, IUnitOfWork
    {

        private readonly IMediatorHandler _mediatorHandler;

        public VendingMachineContext(DbContextOptions<VendingMachineContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public async Task<bool> Commit()
        {
            await _mediatorHandler.PublishDomainEvents(this).ConfigureAwait(false);
            var success = await SaveChangesAsync() > 0;

            return success;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            //Product
            modelBuilder.Entity<Product>()
                        .HasData(
                         new Product { isActive = true, Price = 1.30m, Description = "Tea", Quantity = 10 },
                         new Product { isActive = true, Price = 1.80m, Description = "Espresso", Quantity = 20 },
                         new Product { isActive = true, Price = 1.80m, Description = "Juice", Quantity = 20 },
                         new Product { isActive = true, Price = 1.80m, Description = "Chicken soup", Quantity = 15 });

            //Loading the Wallet
            var idTransaction = Guid.NewGuid();
            modelBuilder.Entity<Wallet>()
                        .HasData(
                            new Wallet { IdTransaction = idTransaction, Coin = TypeCoin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = TypeCoin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = TypeCoin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = TypeCoin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 }
                         );


            base.OnModelCreating(modelBuilder);

        }
    }
}
