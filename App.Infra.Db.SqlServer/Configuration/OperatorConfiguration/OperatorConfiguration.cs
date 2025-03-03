﻿
using App.Domain.Core.ServiceOn.User.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.Db.SqlServer.Configuration.OperatorConfiguration
{
    public class OperatorConfiguration : IEntityTypeConfiguration<Operator>
    {
        public void Configure(EntityTypeBuilder<Operator> builder)
        {
            builder.ToTable("Operators");
            builder.HasKey(x => x.OperatorId);

            builder.HasData(new List<Operator>()
            {

                new Operator () {OperatorId = 1 ,Name = " Reza " , LastName = " Karami" , UserName = "RezaKarami1234" , Password = " R12345678"}
                , new Operator() {OperatorId = 2 ,Name = "Gholam" , LastName = " Masoumi" , UserName = " gholamM12" , Password = "MasoumiGh"}

            });



        }
    }
}

        
      
