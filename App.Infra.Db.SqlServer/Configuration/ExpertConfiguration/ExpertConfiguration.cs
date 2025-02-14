using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Infra.Db.SqlServer.Configuration.ExpertConfiguration.cs
{
    public class ExpertConfiguration : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.ToTable("Experts");
            builder.HasKey(x=> x.Id);

            builder.HasMany(x => x.CostomerRequests)  //all requests 
                .WithOne(x=> x.ChoosenExpert)
                .HasForeignKey(x=>x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x=>x.ExpertRequests) // sent request from Expert
                .WithOne(x=>x.Expert)
                .HasForeignKey(x=>x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(x => x.feedBacks)  // all feedbacks from costomers 
                .WithOne(x => x.Expert)
                .HasForeignKey(x => x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(x=> x.Abilities)   // service that expert provide
            //     .WithMany(x=> x.experts)
            //     .HasForeignKey(x=>x.AbilityId);

            #region Seed Data 

            builder.HasData(new List<Expert>()
            {
                new Expert(){ Id = 1 ,Name = "Parsa" , LastName = "Mousavi" , Age = 20 , UserName="parsa_mhl" , Password = " parsa1383" ,  AddressId = 1 , Balance = 800 }


            });
            #endregion
        }
    }
}
