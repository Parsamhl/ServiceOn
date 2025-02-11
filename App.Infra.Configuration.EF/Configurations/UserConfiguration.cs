using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Configuration.EF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Wallet)
                .WithOne(x => x.User);

            builder.HasMany(x => x.Services)  // title that user hold as profassion
                .WithMany(x => x.Providers); /// list of  users who doing Services

            

            
                
                
        }
    }
}
