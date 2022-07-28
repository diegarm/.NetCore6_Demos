using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Wallet : Entity, IAggregateRoot
    {
        public Coin Coin { get;  set; }
        public Guid IdTransaction { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTransaction { get;  set; }        
    }
}
