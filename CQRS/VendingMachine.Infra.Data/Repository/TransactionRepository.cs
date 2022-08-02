using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;


namespace VendingMachine.Infra.Data.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(VendingMachineContext context) : base(context)
        {
        }

        public void AddAsync(Transaction entity)
        {
            var transactionActive = DbSet.ToList();
            var entityCoin = DbSet.Where(e => e.Coin == entity.Coin).FirstOrDefault();

            //ID Block Transaction
            if (transactionActive is not null && transactionActive.Count() > 0)
                entity.IdTransaction = transactionActive.FirstOrDefault().IdTransaction;
            else
                entity.IdTransaction = Guid.NewGuid();

            if(entityCoin is not null)
            {
                entityCoin.Quantity += 1;
                DbSet.Update(entityCoin);
            }
            else
            {
                var a = DbSet.Add(entity);
            }
            

        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await DbSet.ToListAsync(); 
        }

        public async Task Refund()
        {
            var entities = await GetAllAsync();
            Db.RemoveRange(entities);
        }
    }
}
