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
    public class VendingMachineContext : DbContext
    {
        public VendingMachineContext(DbContextOptions<VendingMachineContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                            new Wallet { IdTransaction = idTransaction, Coin = Coin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = Coin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = Coin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 },
                            new Wallet { IdTransaction = idTransaction, Coin = Coin.Cent10, DateTransaction = DateTime.Now, Quantity = 100 }
                         );


            base.OnModelCreating(modelBuilder);

        }
    }
}
