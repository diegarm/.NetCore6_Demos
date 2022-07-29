using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common;
using VendingMachine.Domain.Interfaces;
using VendingMachine.Domain.Model;

namespace VendingMachine.Domain.Commands
{
    public class TransactionCommandHandler : CommandHandler,
        IRequestHandler<RegisterCashInCommand, ValidationResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly ISoldRepository _soldRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IWalletRepository _walletRepository;

        public TransactionCommandHandler(IProductRepository productRepository, ISoldRepository soldRepository, ITransactionRepository transactionRepository, IWalletRepository walletRepository)
        {
            _productRepository = productRepository;
            _soldRepository = soldRepository;
            _transactionRepository = transactionRepository;
            _walletRepository = walletRepository;
        }

        public async Task<ValidationResult> Handle(RegisterCashInCommand request, CancellationToken cancellationToken)
        {
            var validation = new ValidationResult();

            if (!request.IsValid()) return request.ValidationResult;

            var transaction = new Transaction
            {
                Coin = request.Coin
            };

            var isOk = await _transactionRepository.SaveTransaction(transaction);
            

            if (!isOk)
            {
                ValidationFailure failure = new ValidationFailure("Fatal", "Failed to Insert Coin, redo the operation");
                validation.Errors.Add(failure);
            }


            return validation;

        }
    }
}
