using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{


    public abstract class BaseRepository<TEntity> : IDisposable where TEntity : class
    {
        protected readonly DbSet<TEntity> DbSet;
        protected readonly VendingMachineContext Db;
        
        public BaseRepository(VendingMachineContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public IUnitOfWork UnitOfWork => Db;

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
