using MoneyTransfer.Abstract.Interface.Transfer;
using MoneyTransfer.Concrete.Transfer;

namespace MoneyTransfer.Business.Models.Models.SendMoney.Req
{
    public class SendMoneyRequest : ISendRequest
    {
        public string fromAccountNo { get; set; }
        public string toAccountNo { get; set; }
        public string Description { get; set; }
        public decimal amount { get; set; }
    }
}
