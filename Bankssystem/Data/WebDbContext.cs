using Bankssystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bankssystem.Data
{
    public class WebDbContext : IdentityDbContext<Users>
    {
        public WebDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Account> TBL_Account { get; set; }
        public DbSet<Transaction> TBL_Transaction { get; set; }
        public DbSet<Customer> TBL_Customer { get; set; }
        public DbSet<Loan> TBL_Loan { get; set; }
        public DbSet<BankLocation> TBL_BankLocation { get; set; }
    }
}