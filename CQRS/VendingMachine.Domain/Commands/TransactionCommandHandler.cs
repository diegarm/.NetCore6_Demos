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
        IRequestHandler<RegisterCashInCommand, ValidationResult>,
        IRequestHandler<RegisterRefundCommand, ValidationResult>
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

            _transactionRepository.AddAsync(transaction);

            return await Commit(_transactionRepository.UnitOfWork);  
        }

        public async Task<ValidationResult> Handle(RegisterRefundCommand request, CancellationToken cancellationToken)
        {
            var validation = new ValidationResult();
            var transaction = await _transactionRepository.GetAllAsync();

            if(transaction.Count() > 0)
            {
                await _transactionRepository.Refund();
            }
            else
            {
                validation.Errors.Add(new ValidationFailure("Empty", "There are no coins to return"));
                return validation;
            }

            return await Commit(_transactionRepository.UnitOfWork);
        }
    }
}
