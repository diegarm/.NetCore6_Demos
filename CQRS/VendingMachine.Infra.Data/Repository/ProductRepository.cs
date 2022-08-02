using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class ProductRepository : BaseRepository<Sold>, IProductRepository
    {
        public ProductRepository(VendingMachineContext context) : base(context)
        {
        }
    }
}
