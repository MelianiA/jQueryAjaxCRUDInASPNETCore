using Microsoft.EntityFrameworkCore;

namespace jQueryAjaxCRUDInASPNETCore.Models
{
    public class TransactionDbContext :DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {

        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
