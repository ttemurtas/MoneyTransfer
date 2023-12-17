using AutoMapper;
using MediatR;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Res;
using MoneyTransfer.Business.Transfer.Queries;
using MoneyTransfer.Concrete.Transfer;
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
            var transactionList = _userContext.Transactions.Where(x => x.fromUserAccount == request.request || x.toUserAccount == request.request).ToList();
            if (transactionList.Count == 0)
            {
                return await Task.FromResult(result: new List<ViewTransactionResponse>() { new ViewTransactionResponse() { Message = "no any transaction" } });
            }
            List<ViewTransactionResponse> transactionResponse = new();
            transactionResponse.Capacity = transactionList.Count;

            foreach (var item in transactionList)
            {
                transactionResponse.Add(new ViewTransactionResponse { description = item.description, fromUserAccount = item.fromUserAccount, toUserAccount = item.toUserAccount, transactionNo = item.transactionNo, Ok = true, amount = item.amount });
            }
            //var transactionResponse = _mapper.Map<List<Transaction>, List<ViewTransactionResponse>>(transactionList);

            return await Task.FromResult(transactionResponse);
        }
    }
}
