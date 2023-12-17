using AutoMapper;
using MediatR;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Res;
using MoneyTransfer.Business.Transfer.Queries;
using MoneyTransfer.Data.Contexts;

namespace MoneyTransfer.Business.Transfer.Handlers
{

    public class GetUserAllTransactionsHandler : IRequestHandler<GetUserAllTransactionsQuery, List<ViewTransactionResponse>>
    {
        private readonly MoneyTransferAPIDbContext _userContext;
        private readonly IMapper _mapper;
        public GetUserAllTransactionsHandler(MoneyTransferAPIDbContext context, IMapper _mapper)
        {
            _userContext = context;
            this._mapper = _mapper;
        }

        public async Task<List<ViewTransactionResponse>> Handle(GetUserAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var transactionList = _userContext.Transactions.Where(x => x.fromUserAccount == request.request.accountNo && x.toUserAccount == request.request.accountNo).ToList();
            if (transactionList.Count == 0)
            {
                return await Task.FromResult(result: new List<ViewTransactionResponse>());
            }

            var transactionResponse = _mapper.Map<List<ViewTransactionResponse>>(transactionList);
            transactionResponse.ForEach(x => x.Ok = true);

            return await Task.FromResult(transactionResponse);
        }
    }
}
