using AutoMapper;
using MediatR;
using MoneyTransfer.Abstract.Interface.Transfer;
using MoneyTransfer.Business.Helpers;
using MoneyTransfer.Business.Models.Models.SendMoney.Res;
using MoneyTransfer.Business.Transfer.Commands;
using MoneyTransfer.Concrete.Transfer;
using MoneyTransfer.Data.Contexts;

namespace MoneyTransfer.Business.Transfer.Handlers
{
    public class SendMoneyHandler : IRequestHandler<SendMoneyCommand, SendMoneyResponse>
    {
        private readonly MoneyTransferAPIDbContext _context;
        private readonly IMapper _mapper;
        public SendMoneyHandler(MoneyTransferAPIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<SendMoneyResponse> Handle(SendMoneyCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return await Task.FromResult(new SendMoneyResponse() { Ok = false });

            var fromUser = _context.Users.Where(x => x.accountNo == request.moneySendRequest.fromAccountNo).FirstOrDefault();
            var toUser = _context.Users.Where(x => x.accountNo == request.moneySendRequest.toAccountNo).FirstOrDefault();

            fromUser.amount = fromUser.amount - request.moneySendRequest.amount;
            toUser.amount = toUser.amount + request.moneySendRequest.amount;

            _context.Update(fromUser);
            _context.Update(toUser);

            Transaction transaction = new() { amount = request.moneySendRequest.amount, description = request.moneySendRequest.Description, fromUserAccount = request.moneySendRequest.fromAccountNo, toUserAccount = request.moneySendRequest.toAccountNo, userId = fromUser.id };
            _context.Add(transaction);
            _context.SaveChanges();


            var response = _mapper.Map<SendMoneyResponse>(transaction);
            response.Ok = true;
            response.Message = response.transactionNo;


            return response;
        }
    }
}
