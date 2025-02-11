using App.Domain.Core.ServiceOn.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Configuration.EF.Configurations
{
    public class ServiceProviderRequestConfiguration : IEntityTypeConfiguration<ServiceProviderRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceProviderRequest> builder)
        {
            builder.ToTable("ServiceProvidersRequests");
            builder.HasKey(x=>x.ServiceProviderId);

           
        }
    }
}
