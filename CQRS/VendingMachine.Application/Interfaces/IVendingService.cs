
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Application.Interface
{
    public interface IVendingService : IDisposable
    {
        Task<ValidationResult> RegisterCashIn(CashInViewModel cashIn);
    }
}
