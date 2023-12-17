using AutoMapper;
using MediatR;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Res;
using MoneyTransfer.Business.Transfer.Queries;
using MoneyTransfer.Data.Contexts;

namespace MoneyTransfer.Business.Transfer.Handlers
{
    public class GetUserTransactionHandler : IRequestHandler<GetUserTransactionQuery, ViewTransactionResponse>
    {
        private readonly MoneyTransferAPIDbContext _context;
        private readonly IMapper _mapper;
        public GetUserTransactionHandler(MoneyTransferAPIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ViewTransactionResponse> Handle(GetUserTransactionQuery request, CancellationToken cancellationToken)
        {
            var transaction = _context.Transactions.Where(x => x.transactionNo == request.req.transactionNo).FirstOrDefault();
            if (transaction == null)
            {
                return await Task.FromResult(new ViewTransactionResponse() { Ok = false }) ;
            }
            var response = _mapper.Map<ViewTransactionResponse>(transaction);
            response.Ok = true;

            return await Task.FromResult(response);
        }
    }
}
