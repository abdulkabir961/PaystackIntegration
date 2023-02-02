using Microsoft.EntityFrameworkCore;
using PaystackIntegration.Models;

namespace PaystackIntegration.Repository
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
