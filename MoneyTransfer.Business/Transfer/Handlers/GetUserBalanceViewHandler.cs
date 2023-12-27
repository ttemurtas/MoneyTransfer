using AutoMapper;
using MediatR;
using MoneyTransfer.Business.Models.Models.BalanceView.Res;
using MoneyTransfer.Business.Transfer.Queries;
using MoneyTransfer.Data.Contexts;

namespace MoneyTransfer.Business.Transfer.Handlers
{
    public class GetUserBalanceViewHandler : IRequestHandler<GetUserBalanceQuery, GetUserBalanceViewResponse>
    {
        private readonly MoneyTransferAPIDbContext _userContext;
        private readonly IMapper _mapper;
        public GetUserBalanceViewHandler(MoneyTransferAPIDbContext context, IMapper mapper)
        {
            _userContext = context;
            _mapper = mapper;
        }

        public async Task<GetUserBalanceViewResponse> Handle(GetUserBalanceQuery request, CancellationToken cancellationToken)
        {
            var balance = _userContext.Users.Where(o => o.accountNo == request.accountNo).FirstOrDefault();
            if (balance == null)
                return await Task.FromResult(new GetUserBalanceViewResponse() { Ok = false });

            //var response = _mapper.Map<GetUserBalanceViewResponse>(balance);
            GetUserBalanceViewResponse response = new()
            {
                amount = balance.amount,
                Message = string.Format("..."),
                Ok = true
            };

            return await Task.FromResult(response);
        }
    }
}
