using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;


namespace VendingMachine.Infra.Data.Repository
{
    public class TransactionRepository : UnitOfWork<Transaction>, ITransactionRepository
    {
        public TransactionRepository(VendingMachineContext context) : base(context)
        {
        }


        public async Task<bool> SaveTransaction(Transaction entity)
        {
            var transactionActive = await GetAllAsync();
            var transactionCoin = Query.Where(e => e.Coin == entity.Coin).FirstOrDefault();

            //ID Block Transaction
            //if (transactionActive is not null)
            //    entity.IdTransaction = transactionActive.FirstOrDefault().IdTransaction;
            //else
            //    entity.IdTransaction = Guid.NewGuid();

            if(transactionCoin is not null)
            {
                transactionCoin.Quantity += 1;
                await UpdateAsync(entity);
            }
            else
            {
                var a = SaveAsync(entity);
                return true;
            }
            return false;

        }


    }
}
