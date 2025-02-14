using App.Domain.Core.ServiceOn.Category.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.CategoryConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x => x.CategoryId);

            builder.HasMany(x => x.SubCategories)  // categories that has subcategories
                .WithOne(x => x.Categories)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            #region Seed Data

            builder.HasData(new List<Categories>()
            {
                new Categories (){CategoryId = 1 ,CategoryName = "Cleaning"},
                new Categories() {CategoryId =2 ,CategoryName = "Design"},
                new Categories() {CategoryId = 3 ,CategoryName = "Documentation" },
                new Categories() {CategoryId = 4 ,CategoryName = "Baby sitter" },



            });

            #endregion
        }
    }
}
