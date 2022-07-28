using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Application.Interface;

namespace VendingMachine.Application.Services
{
    public class VendingService : ITransactionService
    {


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
