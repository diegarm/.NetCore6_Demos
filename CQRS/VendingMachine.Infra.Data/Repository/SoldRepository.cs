using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class SoldRepository : UnitOfWork<Sold>, ISoldRepository
    {
        public SoldRepository(VendingMachineContext context) : base(context)
        {
        }
    }
}
