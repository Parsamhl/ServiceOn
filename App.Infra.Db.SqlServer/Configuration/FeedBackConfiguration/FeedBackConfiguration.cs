using App.Domain.Core.ServiceOn.FeedBack.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.FeedBackConfiguration
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.ToTable("FeedBacks");
            builder.HasKey(x => x.FeedBackId);

            builder.HasData(new List<FeedBack>()
            {
                
            });
        }
    }
}
