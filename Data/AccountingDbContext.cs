using Microsoft.EntityFrameworkCore;
using Accounting.Api.Models;

namespace Accounting.Api.Data
{
    public class AccountingDbContext: DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options): base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}
