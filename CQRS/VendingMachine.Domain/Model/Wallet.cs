using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Wallet : Entity, IAggregateRoot
    {
        public Coin Coin { get;  set; }
        public DateTime DateTransaction { get;  set; }
        public virtual WalletTransaction OrderTranscation { get;  set; }
    }
}
