using MoneyTransfer.Concrete.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace MoneyTransfer.Concrete.Transfer
{
    public class Transaction : BaseEntity
    {
        [Display(Name = "User Id")]
        public Guid userId { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string fromUserAccount { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public string toUserAccount { get; set; }
        [AllowNull]
        [Column(TypeName = "varchar(200)")]
        public string description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal amount { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string transactionNo { get; set; } = new Guid().ToString();
    }
}
