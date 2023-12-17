using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Concrete.Common
{
    public class BaseEntity
    {
        public Guid id { get; set; } = new Guid();
        public DateTime creationDate { get; set; } = DateTime.Now;
    }
}
