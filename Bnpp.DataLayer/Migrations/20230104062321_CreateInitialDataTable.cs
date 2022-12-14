using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bnpp.DataLayer.Migrations
{
    public partial class CreateInitialDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "initialData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowableCUF = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AllowableLifeTime = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AllowableChangingRatio = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_initialData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "initialData");
        }
    }
}
