using App.Domain.Core.ServiceOn.Base.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.SqlServer.Configuration.ImageConfiguration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
           builder.HasOne(x=> x.CostomerRequest)
                .WithMany(x=> x.Images)
                .HasForeignKey(x=>x.RequestId);
        }
    }
}
