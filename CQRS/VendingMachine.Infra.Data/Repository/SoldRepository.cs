using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class SoldRepository : BaseRepository<Sold>, ISoldRepository
    {
        public SoldRepository(VendingMachineContext context) : base(context)
        {
        }
    }
}
