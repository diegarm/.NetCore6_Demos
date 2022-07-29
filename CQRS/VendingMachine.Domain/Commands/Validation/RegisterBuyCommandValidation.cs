using FluentValidation;

namespace VendingMachine.Domain.Commands.Validation
{
    public class RegisterBuyCommandValidation : AbstractValidator<RegisterBuyCommand>
    {
        public RegisterBuyCommandValidation()
        {
            ValidateProduct();
        }

        private void ValidateProduct()
        {
            RuleFor(c => c.ProductOption)
              .NotEmpty()
              .GreaterThan(0)
              .WithMessage("The Product Option must have 1 or more");
        }
    }
}
