using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class OperatorClassCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeedBackStatus",
                table: "FeedBacks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "FeedBacks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "ExpertRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OperatorId",
                table: "CostomerRequest",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_OperatorId",
                table: "FeedBacks",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertRequest_OperatorId",
                table: "ExpertRequest",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CostomerRequest_OperatorId",
                table: "CostomerRequest",
                column: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CostomerRequest_Operators_OperatorId",
                table: "CostomerRequest",
                column: "OperatorId",
                principalTable: "Operators",
                principalColumn: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpertRequest_Operators_OperatorId",
                table: "ExpertRequest",
                column: "OperatorId",
                principalTable: "Operators",
                principalColumn: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBacks_Operators_OperatorId",
                table: "FeedBacks",
                column: "OperatorId",
                principalTable: "Operators",
                principalColumn: "OperatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostomerRequest_Operators_OperatorId",
                table: "CostomerRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpertRequest_Operators_OperatorId",
                table: "ExpertRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBacks_Operators_OperatorId",
                table: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.DropIndex(
                name: "IX_FeedBacks_OperatorId",
                table: "FeedBacks");

            migrationBuilder.DropIndex(
                name: "IX_ExpertRequest_OperatorId",
                table: "ExpertRequest");

            migrationBuilder.DropIndex(
                name: "IX_CostomerRequest_OperatorId",
                table: "CostomerRequest");

            migrationBuilder.DropColumn(
                name: "FeedBackStatus",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "ExpertRequest");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "CostomerRequest");
        }
    }
}
