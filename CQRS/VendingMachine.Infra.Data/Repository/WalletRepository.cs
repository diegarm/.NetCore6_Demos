using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class WalletRepository : UnitOfWork<Wallet>, IWalletRepository
    {
        public WalletRepository(VendingMachineContext context) : base(context)
        {
        }
    }
}
