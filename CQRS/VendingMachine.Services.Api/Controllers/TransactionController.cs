using Microsoft.AspNetCore.Mvc;
using VendingMachine.Application.Interface;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Services.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ApiController
    {
        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionService _transactionService;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "cash-in")]
        public async Task<IActionResult> CashIn([FromBody] CashInViewModel cashIn)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.RegisterCashIn(cashIn));
        }

        [HttpPost(Name = "refund")]
        public async Task<IActionResult> Refund([FromBody] CashInViewModel cashIn)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.Refund());
        }

    }
}