using MediatR;
using MoneyTransfer.Business.Models.Models.BalanceView.Res;
using MoneyTransfer.Concrete.AppUser;

namespace MoneyTransfer.Business.Transfer.Queries
{
    public record GetUserBalanceQuery(string accountNo) : IRequest<GetUserBalanceViewResponse>;
}
