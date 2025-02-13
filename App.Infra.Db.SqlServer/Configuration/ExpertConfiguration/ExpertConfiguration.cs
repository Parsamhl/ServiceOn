using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.ExpertConfiguration.cs
{
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.ToTable("Experts");
            builder.HasKey(x=> x.ExpertId);

            builder.HasMany(x => x.CostomerRequests)  //all requests 
                .WithMany();

            builder.HasMany(x=>x.ExpertRequests) // sent request from Expert
                .WithOne(x=>x.Expert)
                .HasForeignKey(x=>x.ExpertId);

            
            builder.HasMany(x => x.feedBacks)  // all feedbacks from costomers 
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId);

           //builder.HasOne(x=> x.Abilities)   // service that expert provide
           //     .WithMany(x=> x.experts)
           //     .HasForeignKey(x=>x.AbilityId);

            
        }
    }
}
