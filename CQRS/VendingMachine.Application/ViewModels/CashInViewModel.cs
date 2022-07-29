using System.ComponentModel.DataAnnotations;
using VendingMachine.Domain.Model;

namespace VendingMachine.Application.ViewModels
{
    public class CashInViewModel
    {
        [Required(ErrorMessage = "The coin is required")]
        [MinLength(1)]
        public TypeCoin Coin { get; set; }
    }
}
