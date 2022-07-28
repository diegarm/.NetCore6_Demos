using Microsoft.AspNetCore.Mvc;
using VendingMachine.Application.Interface;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Services.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalletController : ApiController
    {
        private readonly ILogger<WalletController> _logger;
        private readonly IVendingService _vendingService;

        public WalletController(ILogger<WalletController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "cash-in")]
        public async Task<IActionResult>Post([FromBody] CashInViewModel cashIn)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _vendingService.RegisterCashIn(cashIn));
        }
    }
}