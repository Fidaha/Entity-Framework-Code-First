using Microsoft.EntityFrameworkCore;
using Savings.Models;

namespace Savings.Repositories
{
    public class SavingContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<SavingAccount> SavingAccount { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // I add a connection to a database instance while the context configures
            optionsBuilder.UseSqlServer( @"Data Source=localhost;Database=Savings;
                Integrated Security=sspi;Encrypt=true;TrustServerCertificate=true;");
        }


    }
}
