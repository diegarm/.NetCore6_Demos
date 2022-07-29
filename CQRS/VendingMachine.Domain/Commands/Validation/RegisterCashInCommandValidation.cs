using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common;
using VendingMachine.Domain.Model;

namespace VendingMachine.Domain.Commands.Validation
{
    public class RegisterCashInCommandValidation : AbstractValidator<RegisterCashInCommand>
    {
        public RegisterCashInCommandValidation()
        {
            ValidateAmount();
        }

        private void ValidateAmount()
        {
            RuleFor(c => c.Coin)
              .IsInEnum();
        }
    }
}
