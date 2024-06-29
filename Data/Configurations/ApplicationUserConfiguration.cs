using HMD.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HMD.BankApp.Web.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(200);

            builder.Property(x => x.SurName).IsRequired(true);
            builder.Property(x => x.SurName).HasMaxLength(250);

            builder.HasMany(x => x.Accounts).WithOne(x => x.ApplicationUser).HasForeignKey(x => x.ApplicationUserId);
        }
    }
}
