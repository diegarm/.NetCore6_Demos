using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Model;

namespace VendingMachine.Domain.Interface
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
    }
}
