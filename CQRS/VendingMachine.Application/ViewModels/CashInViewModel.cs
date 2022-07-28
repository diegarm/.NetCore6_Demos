using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Application.ViewModels
{
    public class CashInViewModel
    {
        [Required(ErrorMessage = "The amount is required")]
        [MinLength(1)]
        public decimal Amount;
    }
}
