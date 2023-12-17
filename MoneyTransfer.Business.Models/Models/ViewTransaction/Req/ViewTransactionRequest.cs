using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Business.Models.Models.ViewTransaction.Req
{
    public class ViewTransactionRequest
    {
        public string? transactionNo { get; set; }
        public string? accountNo { get; set; }
    }
}
