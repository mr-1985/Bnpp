﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bnpp.DataLayer.Migrations
{
    public partial class CreateStrucureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Strctures",
                columns: table => new
                {
                    StrctureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Station2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ConstructionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Azk = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AzkStruct = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StrctureImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BasicImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strctures", x => x.StrctureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Strctures");
        }
    }
}
