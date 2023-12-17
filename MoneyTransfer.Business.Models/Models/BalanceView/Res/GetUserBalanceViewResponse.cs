using MoneyTransfer.Business.Models.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Business.Models.Models.BalanceView.Res
{
    public class GetUserBalanceViewResponse : BaseResponse
    {
        public decimal amount { get; set; }
    }
}
