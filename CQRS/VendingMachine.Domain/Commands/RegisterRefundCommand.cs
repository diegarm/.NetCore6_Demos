using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Commands.Validation;
using VendingMachine.Domain.Common;

namespace VendingMachine.Domain.Commands
{
    public class RegisterRefundCommand : Command
    {
        public RegisterRefundCommand() { } 

        public Guid TransactionId { get; protected set; }        

    }
}
