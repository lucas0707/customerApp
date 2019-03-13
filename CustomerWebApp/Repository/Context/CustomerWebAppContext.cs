using Microsoft.EntityFrameworkCore;
using CustomerWebApp.Models;

namespace CustomerWebApp.Repository.Context
{
    public class CustomerWebAppContext : DbContext
    {
        public CustomerWebAppContext (DbContextOptions<CustomerWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
