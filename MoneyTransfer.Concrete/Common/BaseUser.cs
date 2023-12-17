using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Concrete.Common
{
    public class BaseUser : BaseEntity
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string nationalId { get; set; }
        public string email { get; set; }
    }
}
