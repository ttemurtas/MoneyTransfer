using MoneyTransfer.Business.Models.Models.Common;

namespace MoneyTransfer.Business.Models.Models.SendMoney.Res
{
    public class SendMoneyResponse : BaseResponse
    {
        public Guid transactionNo { get; set; }
    }
}
