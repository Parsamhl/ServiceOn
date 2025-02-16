﻿// <auto-generated />
using System;
using App.Infra.Db.SqlServer.SqlServerDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Infra.Db.SqlServer.Migrations
{
    [DbContext(typeof(ServiceOnDbContext))]
    partial class ServiceOnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Address.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CostomerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Tehran"
                        },
                        new
                        {
                            Id = 2,
                            City = "Karaj"
                        },
                        new
                        {
                            Id = 3,
                            City = "Arak",
                            CostomerId = "1"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.AllService.Entities.AllService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AllService", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Home Service "
                        },
                        new
                        {
                            Id = 2,
                            Title = "Car Service"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Office Service"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Baby sitting"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Base.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CostomerRequestId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CostomerRequestId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainSerivceId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("MainSerivceId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cleaning"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Design"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Documentation"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Baby sitter"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.SubCategories", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategoryId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories", (string)null);
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.FeedBack.Entities.FeedBack", b =>
                {
                    b.Property<int>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedBackId"));

                    b.Property<int?>("CostomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExpertId")
                        .HasColumnType("int");

                    b.Property<int?>("FeedBackStatus")
                        .HasColumnType("int");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("int");

                    b.Property<float?>("Rate")
                        .HasColumnType("real");

                    b.Property<DateOnly>("SubmitedAt")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeedBackId");

                    b.HasIndex("CostomerId");

                    b.HasIndex("ExpertId");

                    b.HasIndex("OperatorId");

                    b.ToTable("FeedBacks", (string)null);
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Orders.Entities.CostomerRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("CostomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExpertId")
                        .HasColumnType("int");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("int");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CostomerId");

                    b.HasIndex("ExpertId");

                    b.HasIndex("OperatorId");

                    b.ToTable("CostomerRequests");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Orders.Entities.ExpertRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CostomerRequestId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExpertId")
                        .HasColumnType("int");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CostomerRequestId");

                    b.HasIndex("ExpertId");

                    b.HasIndex("OperatorId");

                    b.ToTable("ExpertRequest");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Costomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Costomers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Age = 26,
                            Balance = 260,
                            LastName = "Mohammadi",
                            Name = " ALi",
                            Password = "ali1350.",
                            UserName = "Ali1350"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 1,
                            Age = 20,
                            Balance = 50,
                            LastName = "Farahi",
                            Name = "Keyvan",
                            Password = "258976",
                            UserName = "K1farahi"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("AddressId");

                    b.ToTable("Experts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Age = 20,
                            Balance = 800,
                            LastName = "Mousavi",
                            Name = "Parsa",
                            Password = " parsa1383",
                            Rate = 0f,
                            UserName = "parsa_mhl"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Operator", b =>
                {
                    b.Property<int>("OperatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OperatorId"));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OperatorId");

                    b.ToTable("Operators", (string)null);

                    b.HasData(
                        new
                        {
                            OperatorId = 1,
                            LastName = " Karami",
                            Name = " Reza ",
                            Password = " R12345678",
                            UserName = "RezaKarami1234"
                        },
                        new
                        {
                            OperatorId = 2,
                            LastName = " Masoumi",
                            Name = "Gholam",
                            Password = "MasoumiGh",
                            UserName = " gholamM12"
                        });
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Base.Entities.Image", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Orders.Entities.CostomerRequest", "CostomerRequest")
                        .WithMany("Images")
                        .HasForeignKey("CostomerRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CostomerRequest");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.Categories", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.AllService.Entities.AllService", "AllService")
                        .WithMany("Categories")
                        .HasForeignKey("MainSerivceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("AllService");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.SubCategories", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Category.Entities.Categories", "Categories")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.FeedBack.Entities.FeedBack", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Costomer", "Costomer")
                        .WithMany("feedBacks")
                        .HasForeignKey("CostomerId");

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Expert", "Expert")
                        .WithMany("feedBacks")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Operator", null)
                        .WithMany("FeedBacks")
                        .HasForeignKey("OperatorId");

                    b.Navigation("Costomer");

                    b.Navigation("Expert");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Orders.Entities.CostomerRequest", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Address.Entities.Address", "RequestAdderss")
                        .WithMany("costomerRequests")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Costomer", "Costomer")
                        .WithMany("requests")
                        .HasForeignKey("CostomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Expert", "ChoosenExpert")
                        .WithMany("CostomerRequests")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Operator", null)
                        .WithMany("CostomersRequests")
                        .HasForeignKey("OperatorId");

                    b.Navigation("ChoosenExpert");

                    b.Navigation("Costomer");

                    b.Navigation("RequestAdderss");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Orders.Entities.ExpertRequest", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Address.Entities.Address", "RequestAdderss")
                        .WithMany("expertRequests")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.Orders.Entities.CostomerRequest", "SpeceficRequest")
                        .WithMany("RecivedRequest")
                        .HasForeignKey("CostomerRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Expert", "Expert")
                        .WithMany("ExpertRequests")
                        .HasForeignKey("ExpertId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("App.Domain.Core.ServiceOn.User.Entities.Operator", null)
                        .WithMany("ExpertsRequests")
                        .HasForeignKey("OperatorId");

                    b.Navigation("Expert");

                    b.Navigation("RequestAdderss");

                    b.Navigation("SpeceficRequest");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Costomer", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Address.Entities.Address", "Address")
                        .WithMany("Costomer")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Address");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Expert", b =>
                {
                    b.HasOne("App.Domain.Core.ServiceOn.Category.Entities.SubCategories", "Abilities")
                        .WithMany("experts")
                        .HasForeignKey("AbilityId");

                    b.HasOne("App.Domain.Core.ServiceOn.Address.Entities.Address", "Address")
                        .WithMany("Expert")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Abilities");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Address.Entities.Address", b =>
                {
                    b.Navigation("Costomer");

                    b.Navigation("Expert");

                    b.Navigation("costomerRequests");

                    b.Navigation("expertRequests");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.AllService.Entities.AllService", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.Categories", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Category.Entities.SubCategories", b =>
                {
                    b.Navigation("experts");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.Orders.Entities.CostomerRequest", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("RecivedRequest");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Costomer", b =>
                {
                    b.Navigation("feedBacks");

                    b.Navigation("requests");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Expert", b =>
                {
                    b.Navigation("CostomerRequests");

                    b.Navigation("ExpertRequests");

                    b.Navigation("feedBacks");
                });

            modelBuilder.Entity("App.Domain.Core.ServiceOn.User.Entities.Operator", b =>
                {
                    b.Navigation("CostomersRequests");

                    b.Navigation("ExpertsRequests");

                    b.Navigation("FeedBacks");
                });
#pragma warning restore 612, 618
        }
    }
}
