using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Transaction : Entity, IAggregateRoot
    {
        public Guid IdTransaction { get; set; }
        public TypeCoin Coin { get; set; }
        public int Quantity { get; set; } = 1;       
    }
}
