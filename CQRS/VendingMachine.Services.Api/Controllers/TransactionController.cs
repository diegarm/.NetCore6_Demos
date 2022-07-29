using Microsoft.AspNetCore.Mvc;
using VendingMachine.Application.Interface;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Services.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.CashIn(cashIn));
        }

        [HttpPost(Name = "refund/{id:guid}")]
        public async Task<IActionResult> Refund(Guid id)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.Refund(id));
        }

        [HttpPost(Name = "buy")]
        public async Task<IActionResult> Buy([FromBody] BuyViewModel buy)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.Buy(buy));
        }

    }
}