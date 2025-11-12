using Microsoft.EntityFrameworkCore;
using FinancePortfolioDashboard.Models;

namespace FinancePortfolioDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Portfolio> Portfolios { get; set; } = null!;
        public DbSet<Asset> Assets { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
    }
}
