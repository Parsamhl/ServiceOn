using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace App.Infra.Db.SqlServer.Configuration.CostomerConfiguration
{
    public class CostomerConfiguration : IEntityTypeConfiguration<Costomer>
    {
        public void Configure(EntityTypeBuilder<Costomer> builder)
        {
            builder.ToTable("Costomers");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.requests)
                .WithOne(x => x.Costomer)
                .HasForeignKey(x => x.CostomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.feedBacks)
                .WithOne(x => x.Costomer)
                .HasForeignKey(x => x.CostomerId);

            #region SeedData

            builder.HasData(new List<Costomer>()
            {

                new Costomer() {Id =1 ,Name = " ALi" , LastName = "Mohammadi" , Age = 26 , UserName = "Ali1350" ,Password = "ali1350." , Balance = 260 , AddressId = 1}
                , new Costomer() { Id = 2 ,Name = "Keyvan" , LastName = "Farahi" , Age = 20 , UserName = "K1farahi" , Password = "258976" , Balance = 50  , AddressId = 1}
            });

            #endregion
        }
    }
}
