using MoneyTransfer.Business.Models.Models.Common;

namespace MoneyTransfer.Business.Models.Models.ViewTransaction.Res
{
    public class ViewTransactionResponse : BaseResponse
    {
        public string fromUserAccount { get; set; }
        public string toUserAccount { get; set; }
        public string description { get; set; }
        public Guid transactionNo { get; set; }
        public decimal amount { get; set; }
    }
}
