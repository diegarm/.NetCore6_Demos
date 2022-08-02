using AutoMapper;
using FluentValidation.Results;
using VendingMachine.Application.Interface;
using VendingMachine.Application.ViewModels;
using VendingMachine.Domain.Commands;
using VendingMachine.Domain.Interfaces;

namespace VendingMachine.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;

        public TransactionService(IMapper mapper, IMediatorHandler mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ValidationResult> Buy(BuyViewModel buy)
        {
            var registerBuyCommand = _mapper.Map<RegisterBuyCommand>(buy);
            return await _mediator.SendCommand(registerBuyCommand);
        }

        public async Task<ValidationResult> CashIn(CashInViewModel cashIn)
        {
            var registerCashInCommand = _mapper.Map<RegisterCashInCommand>(cashIn);
            return await _mediator.SendCommand(registerCashInCommand);
        }

        public async Task<ValidationResult> Refund()
        {
            var registerRefundCommand = new RegisterRefundCommand();
            return await _mediator.SendCommand(registerRefundCommand);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
