using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Business.Models.Models.Common
{
    public class BaseResponse
    {
        public bool Ok { get; set; }
        public string Message { get; set; }
    }
}
