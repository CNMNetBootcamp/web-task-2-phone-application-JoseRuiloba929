using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PhoneApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    iD = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brand = table.Column<string>(nullable: true),
                    LaunchDate = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    batteryLife = table.Column<decimal>(nullable: false),
                    phoneCPU = table.Column<string>(nullable: true),
                    phoneDisplay = table.Column<string>(nullable: true),
                    phoneImage = table.Column<string>(nullable: true),
                    phoneOS = table.Column<string>(nullable: true),
                    phoneRating = table.Column<decimal>(nullable: false),
                    phoneWeight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.iD);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phone");
        }
    }
}
