using App.Domain.Core.ServiceOn.Category.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace App.Infra.Db.SqlServer.Configuration.SubCategoryConfiguration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategories>
    {
        public void Configure(EntityTypeBuilder<SubCategories> builder)
        {
            builder.ToTable("SubCategories");
            builder.HasKey(x => x.SubCategoryId);

            //builder.HasOne(x=> x.Categories).
            //    WithMany(x=> x.SubCategories)
            //   .HasForeignKey(x=>x.SubCategoryId);

            builder.HasMany(x => x.experts)
                .WithOne(x => x.Abilities)
                .HasForeignKey(x => x.AbilityId);

            //builder.HasData(new List<SubCategories>
            //{
               
            //});
        }
    }
}
