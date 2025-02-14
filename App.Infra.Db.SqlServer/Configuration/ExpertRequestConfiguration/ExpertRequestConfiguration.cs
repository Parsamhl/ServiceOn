

using App.Domain.Core.ServiceOn.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.Db.SqlServer.Configuration.ExpertRequestConfiguration
{
    public class ExpertRequestConfiguration : IEntityTypeConfiguration<ExpertRequest>
    {
        public void Configure(EntityTypeBuilder<ExpertRequest> builder)
        {
            builder.ToTable("ExpertRequest");
            builder.HasKey(x => x.Id);
            
            
        }
    }
}
