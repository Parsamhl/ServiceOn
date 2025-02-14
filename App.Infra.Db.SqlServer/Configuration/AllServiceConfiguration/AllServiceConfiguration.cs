using App.Domain.Core.ServiceOn.AllService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.Db.SqlServer.Configuration.AllServiceConfiguration
{
    public class AllServiceConfiguration : IEntityTypeConfiguration<AllService>
    {
        public void Configure(EntityTypeBuilder<AllService> builder)
        {
            builder.ToTable("AllService");

            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Categories)
                .WithOne(x => x.AllService)
                .HasForeignKey(x => x.MainSerivceId)
                .OnDelete(DeleteBehavior.Restrict);

            #region Seed Data

            builder.HasData(new List<AllService>()
            {

                new AllService () {Id = 1 ,Title = "Home Service "},
                new AllService() {Id = 2 ,Title = "Car Service"},
                new AllService() {Id = 3 , Title = "Office Service"},
                new AllService() {Id = 4 , Title ="Baby sitting" }
            
            });

            #endregion
        }
    }
}
