using App.Domain.Core.ServiceOn.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Configuration.EF.Configurations
{
    public class UserRequestConfiguration : IEntityTypeConfiguration<UserRequest>
    {
        public void Configure(EntityTypeBuilder<UserRequest> builder)
        {
            builder.ToTable("UserRequests");
            builder.HasKey(x=>x.RequestId);

            builder.HasMany(x=> x.serviceProviderRequests)
                .WithMany(x=>x.UserRequests);

        

        }
    }
}
