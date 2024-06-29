using HMD.BankApp.Web.Data.Configurations;
using HMD.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HMD.BankApp.Web.Data.Context
{
    public class BankContext : DbContext
    {
        public DbSet<Account> AccountDbSet { get; set; }

        public DbSet<ApplicationUser> ApplicationUserDbSet { get; set; }

        public BankContext(DbContextOptions<BankContext> context):base(context)
        {
            
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
