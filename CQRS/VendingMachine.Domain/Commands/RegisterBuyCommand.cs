using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Commands.Validation;
using VendingMachine.Domain.Common;

namespace VendingMachine.Domain.Commands
{
    public class RegisterBuyCommand : Command
    {
        public RegisterBuyCommand(int ProductOption)
        {
            Id = Guid.NewGuid();
            this.ProductOption = ProductOption;
        }

        public Guid Id { get; protected set; }

        public int ProductOption { get; protected set; }

        
        public override bool IsValid()
        {
            ValidationResult = new RegisterBuyCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
