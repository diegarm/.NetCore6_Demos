using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Application.ViewModels
{
    public class BuyViewModel
    {
        [Required(ErrorMessage = "The Product Option is required")]
        [MinLength(1)]
        public int ProductOption { get; set; }
    }
}
