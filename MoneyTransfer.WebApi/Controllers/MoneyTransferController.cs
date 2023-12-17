using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using MoneyTransfer.Business.Models.Models.BalanceView.Req;
using MoneyTransfer.Business.Models.Models.SendMoney.Req;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Req;
using MoneyTransfer.Business.Transfer.Commands;
using MoneyTransfer.Business.Transfer.Queries;

namespace MoneyTransfer.WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyTransferController : Controller
    {
        readonly IMediator _mediator;
        public MoneyTransferController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //Balance view
        [HttpGet("{accountNo}")]

        public async Task<IActionResult> GetBalanceView(string accountNo)
        {
            var request = new GetUserBalanceQuery(accountNo);

            var response = await _mediator.Send(request);

            if (response != null)
                return Json(response.amount);

            return NotFound(response.Message);
        }
        //View single transaction
        [HttpGet("{transactionNo}")]
        public async Task<IActionResult> GetMoneyTransaction(string transactionNo)
        {
            var request = new GetUserTransactionQuery(transactionNo);

            var response = await _mediator.Send(request);

            if (response != null)
                return Json(response);

            return NotFound(response.Message);
        }

        //View all transactions
        [HttpGet]
        [Route("/getalltransaction")]
        public async Task<IActionResult> GetAllTransactions(string accountNo)
        {
            var request = new GetUserAllTransactionsQuery(accountNo);

            var response = await _mediator.Send(request);

            if (response != null)
                return Json(response);

            return NotFound(response[0].Message);
        }

        //Sending money
        [HttpPost]
        [Route("/sendmoney")]
        public async Task<IActionResult> SendMoney([FromBody] SendMoneyRequest moneyRequest)
        {
            var request = new SendMoneyCommand(moneyRequest);

            var response = await _mediator.Send(request);

            if (response != null)
                return Json(response);

            return NotFound(response.Message);
        }
    }
}
