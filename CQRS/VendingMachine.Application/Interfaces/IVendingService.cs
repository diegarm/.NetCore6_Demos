
using System.ComponentModel.DataAnnotations;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Application.Interface
{
    public interface ITransactionService : IDisposable
    {
        Task<ValidationResult> RegisterCashIn(CashInViewModel cashIn);
        Task<ValidationResult> Refund();
    }
}
