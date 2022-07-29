using Microsoft.AspNetCore.Mvc;
using VendingMachine.Application.Interface;
using VendingMachine.Application.ViewModels;

namespace VendingMachine.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ApiController
    {
        private readonly ILogger<TransactionController> _logger;
        private readonly ITransactionService _transactionService;

        public TransactionController(ILogger<TransactionController> logger, ITransactionService transactionService)
        {
            _logger = logger;
            _transactionService = transactionService;
        }

        [HttpPost]
        [Route("cash-in")]
        public async Task<IActionResult> CashIn([FromBody] CashInViewModel cashIn)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.CashIn(cashIn));
        }

        [HttpPost]
        [Route("refund/{id:guid}")]
        public async Task<IActionResult> Refund(Guid id)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.Refund(id));
        }

        [HttpPost]
        [Route("buy")]
        public async Task<IActionResult> Buy([FromBody] BuyViewModel buy)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _transactionService.Buy(buy));
        }

    }
}