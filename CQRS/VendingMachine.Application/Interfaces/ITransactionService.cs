
using FluentValidation.Results;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Application.Interface
{
    public interface ITransactionService : IDisposable
    {
        Task<ValidationResult> CashIn(CashInViewModel cashIn);
        Task<ValidationResult> Refund(Guid id);
        Task<ValidationResult> Buy(BuyViewModel buy);
    }
}
