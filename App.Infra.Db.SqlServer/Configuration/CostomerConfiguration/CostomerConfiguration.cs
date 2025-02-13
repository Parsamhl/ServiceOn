using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace App.Infra.Db.SqlServer.Configuration.CostomerConfiguration
{
    public class CostomerConfiguration : IEntityTypeConfiguration<Costomer>
    {
        public void Configure(EntityTypeBuilder<Costomer> builder)
        {
            builder.ToTable("Costomers");
            builder.HasKey(x=> x.CostomerId);

            builder.HasMany(x=> x.requests)
                .WithOne(x=> x.Costomer)
                .HasForeignKey(x=>x.CostomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x=> x.feedBacks)
                .WithOne(x=> x.Costomer)
                .HasForeignKey(x=>x.CostomerId);
           
        }
    }
}
