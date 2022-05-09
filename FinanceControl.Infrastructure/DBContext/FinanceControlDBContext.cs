using FinanceControl.Domain.Models;
using FinanceControl.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure
{
    public class FinanceControlDBContext : DbContext 
    {       
        public DbSet<User> Users { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }


        public FinanceControlDBContext(DbContextOptions<FinanceControlDBContext> options)
          : base(options)
        {
        }     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());

            new CreditCardMap(modelBuilder.Entity<CreditCard>());
            
            base.OnModelCreating(modelBuilder);
        }


    }

}
