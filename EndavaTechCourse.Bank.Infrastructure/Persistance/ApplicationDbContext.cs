using EndavaTechCourse.Bank.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EndavaTechCourse.Bank.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}