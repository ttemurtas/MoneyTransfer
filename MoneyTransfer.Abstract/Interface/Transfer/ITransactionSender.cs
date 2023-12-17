using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Abstract.Interface.Transfer
{
    public interface ITransactionSender<T> where T : class
    {
        Task<T> Send(ISendRequest request);
    }
}
