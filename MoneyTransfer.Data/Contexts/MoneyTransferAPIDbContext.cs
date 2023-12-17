using Microsoft.EntityFrameworkCore;
using MoneyTransfer.Concrete.AppUser;
using MoneyTransfer.Concrete.Transfer;

namespace MoneyTransfer.Data.Contexts
{
    public class MoneyTransferAPIDbContext :  DbContext 
    {
        public MoneyTransferAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
