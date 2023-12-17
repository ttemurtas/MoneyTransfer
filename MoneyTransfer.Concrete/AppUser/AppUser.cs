using MoneyTransfer.Concrete.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer.Concrete.AppUser
{
    public class AppUser : BaseUser
    {
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string accountNo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal amount { get; set; }
    }
}
