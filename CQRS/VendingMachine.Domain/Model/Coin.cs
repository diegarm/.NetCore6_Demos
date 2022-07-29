using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;

namespace VendingMachine.Domain.Model
{
    public enum TypeCoin 
    {
        Cent10 = 10,
        Cent20 = 20,
        Cent50 = 50,
        Euro1 = 100
    }
}
