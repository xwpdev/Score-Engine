using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScoreEngine.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    UId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.UId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
