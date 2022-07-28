using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interface;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class ProductRepository : UnitOfWork<Product>, IProductRepository
    {
        public ProductRepository(VendingMachineContext context) : base(context)
        {            
        }
    }
}
