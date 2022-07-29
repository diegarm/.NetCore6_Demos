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
    }
}
