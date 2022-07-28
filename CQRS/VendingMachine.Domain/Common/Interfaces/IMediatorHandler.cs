using FluentValidation.Results;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common;

namespace VendingMachine.Domain.Interfaces
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
