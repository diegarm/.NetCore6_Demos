using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Stock : Entity, IAggregateRoot
    {

        public int Quatity { get; set; }

        public virtual Product Product { get; set; }
    }
}
