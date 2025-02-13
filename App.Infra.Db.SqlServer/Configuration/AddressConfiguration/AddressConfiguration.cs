using App.Domain.Core.ServiceOn.Address.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.AddressConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x=> x.Id);

            builder.HasMany(x => x.Costomer)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x=> x.Expert)
                .WithOne(x => x.Address)
                .HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.costomerRequests)
                .WithOne(x => x.RequestAdderss)
                .HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.expertRequests)
                .WithOne(x => x.RequestAdderss)
                .HasForeignKey(x => x.AddressId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
