using MediatR;
using MoneyTransfer.Abstract.Interface.Transfer;
using MoneyTransfer.Business.Models.Models.SendMoney.Req;
using MoneyTransfer.Business.Models.Models.SendMoney.Res;

namespace MoneyTransfer.Business.Transfer.Commands
{
    public record SendMoneyCommand(SendMoneyRequest moneySendRequest) : IRequest<SendMoneyResponse>;
}
