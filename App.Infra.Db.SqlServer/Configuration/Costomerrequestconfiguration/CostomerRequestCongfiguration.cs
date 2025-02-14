using App.Domain.Core.ServiceOn.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.Costomerrequestconfiguration
{
    public class CostomerRequestCongfiguration : IEntityTypeConfiguration<CostomerRequest>
    {
        public void Configure(EntityTypeBuilder<CostomerRequest> builder)
        {
            builder.ToTable("CostomerRequests");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.RecivedRequest)
                .WithOne(x => x.SpeceficRequest)
                .HasForeignKey(x => x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(x => x.ChoosenExpert)
            //    .WithOne(x => x.SpeceficRequest); 
        }
    }
}
