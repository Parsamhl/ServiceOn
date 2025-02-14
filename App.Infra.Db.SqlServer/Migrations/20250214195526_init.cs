using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infra.Db.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostomerId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    OperatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.OperatorId);
                });

            migrationBuilder.CreateTable(
                name: "Costomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Costomers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainSerivceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_AllService_MainSerivceId",
                        column: x => x.MainSerivceId,
                        principalTable: "AllService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityId = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experts_SubCategories_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "CostomerRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    DueTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    CostomerId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    OperatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostomerRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostomerRequests_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostomerRequests_Costomers_CostomerId",
                        column: x => x.CostomerId,
                        principalTable: "Costomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostomerRequests_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostomerRequests_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "OperatorId");
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    FeedBackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedBackStatus = table.Column<int>(type: "int", nullable: true),
                    SubmitedAt = table.Column<DateOnly>(type: "date", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    CostomerId = table.Column<int>(type: "int", nullable: true),
                    OperatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.FeedBackId);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Costomers_CostomerId",
                        column: x => x.CostomerId,
                        principalTable: "Costomers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeedBacks_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "OperatorId");
                });

            migrationBuilder.CreateTable(
                name: "ExpertRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    DueTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostomerRequestId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    OperatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpertRequest_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpertRequest_CostomerRequests_CostomerRequestId",
                        column: x => x.CostomerRequestId,
                        principalTable: "CostomerRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertRequest_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpertRequest_Operators_OperatorId",
                        column: x => x.OperatorId,
                        principalTable: "Operators",
                        principalColumn: "OperatorId");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    CostomerRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_CostomerRequests_CostomerRequestId",
                        column: x => x.CostomerRequestId,
                        principalTable: "CostomerRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "CostomerId" },
                values: new object[,]
                {
                    { 1, "Tehran", null },
                    { 2, "Karaj", null },
                    { 3, "Arak", "1" }
                });

            migrationBuilder.InsertData(
                table: "AllService",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Home Service " },
                    { 2, "Car Service" },
                    { 3, "Office Service" },
                    { 4, "Baby sitting" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "MainSerivceId" },
                values: new object[,]
                {
                    { 1, "Cleaning", null },
                    { 2, "Design", null },
                    { 3, "Documentation", null },
                    { 4, "Baby sitter", null }
                });

            migrationBuilder.InsertData(
                table: "Operators",
                columns: new[] { "OperatorId", "LastName", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, " Karami", " Reza ", " R12345678", "RezaKarami1234" },
                    { 2, " Masoumi", "Gholam", "MasoumiGh", " gholamM12" }
                });

            migrationBuilder.InsertData(
                table: "Costomers",
                columns: new[] { "Id", "AddressId", "Age", "Balance", "LastName", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 1, 26, 260, "Mohammadi", " ALi", "ali1350.", "Ali1350" },
                    { 2, 1, 20, 50, "Farahi", "Keyvan", "258976", "K1farahi" }
                });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "AbilityId", "AddressId", "Age", "Balance", "LastName", "Name", "Password", "Rate", "UserName" },
                values: new object[] { 1, null, 1, 20, 800, "Mousavi", "Parsa", " parsa1383", 0f, "parsa_mhl" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MainSerivceId",
                table: "Categories",
                column: "MainSerivceId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerRequests_AddressId",
                table: "CostomerRequests",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerRequests_CostomerId",
                table: "CostomerRequests",
                column: "CostomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerRequests_ExpertId",
                table: "CostomerRequests",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerRequests_OperatorId",
                table: "CostomerRequests",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Costomers_AddressId",
                table: "Costomers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRequest_AddressId",
                table: "ExpertRequest",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRequest_CostomerRequestId",
                table: "ExpertRequest",
                column: "CostomerRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRequest_ExpertId",
                table: "ExpertRequest",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRequest_OperatorId",
                table: "ExpertRequest",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AbilityId",
                table: "Experts",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AddressId",
                table: "Experts",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_CostomerId",
                table: "FeedBacks",
                column: "CostomerId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_ExpertId",
                table: "FeedBacks",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_OperatorId",
                table: "FeedBacks",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CostomerRequestId",
                table: "Images",
                column: "CostomerRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertRequest");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "CostomerRequests");

            migrationBuilder.DropTable(
                name: "Costomers");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AllService");
        }
    }
}
