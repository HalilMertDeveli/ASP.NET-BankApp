using HMD.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMD.BankApp.Web.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.AccountNumber).IsRequired(true);

            builder.Property(x => x.Balance).IsRequired(true);
            builder.Property(x => x.Balance).HasColumnType("decimal(18,4)");
        }
    }
}
