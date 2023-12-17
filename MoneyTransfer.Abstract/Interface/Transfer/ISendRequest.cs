using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Abstract.Interface.Transfer
{
    public interface ISendRequest
    {
        string fromAccountNo { get; set; }
        string toAccountNo { get; set; }
        string Description { get; set; }
        decimal amount { get; set; }
    }
}
