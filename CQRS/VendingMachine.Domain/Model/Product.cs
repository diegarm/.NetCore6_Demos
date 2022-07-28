using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Product : Entity, IAggregateRoot
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public int Quantity { get; set; }
        public bool isActive { get; set; }

    }
}
