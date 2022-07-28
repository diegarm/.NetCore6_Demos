using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public class WalletTransaction : Entity, IAggregateRoot
    {

        public string Description { get; set; }
        public bool IsFinish { get; set; }
        public virtual ICollection<Wallet> Wallet { get; set; }
    }
}
