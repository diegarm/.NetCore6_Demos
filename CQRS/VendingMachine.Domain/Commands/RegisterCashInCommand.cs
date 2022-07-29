using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common;
using VendingMachine.Domain.Model;

namespace VendingMachine.Domain.Commands
{
    public class RegisterCashInCommand : Command
    {
        public RegisterCashInCommand(TypeCoin coin)
        {
            Coin = coin;
        }

        public TypeCoin Coin { get; protected set; }

    }
}
