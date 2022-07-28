using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class Sold : Entity, IAggregateRoot
    {
        public Guid IdTransaction { get; set; }
        public Product Product { get; set; }

    }
}
