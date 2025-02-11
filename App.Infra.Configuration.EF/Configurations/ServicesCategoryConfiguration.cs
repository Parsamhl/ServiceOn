using App.Domain.Core.ServiceOn.Category.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Configuration.EF.Configurations
{
    public class ServicesCategoryConfiguration : IEntityTypeConfiguration<ServicesCategory>
    {
        public void Configure(EntityTypeBuilder<ServicesCategory> builder)
        {
            builder.ToTable("ServicesCategories");
            builder.HasKey(x => x.ServiceCategoryId);

            //builder.HasOne(x => x.Category)
            //    .WithMany(x => x.SubCategory);

        }
    }
}
