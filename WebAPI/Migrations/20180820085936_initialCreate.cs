using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAPI.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(name: "Address Line 1", nullable: true),
                    AddressLine2 = table.Column<string>(name: "Address Line 2", nullable: true),
                    AddressLine3 = table.Column<string>(name: "Address Line 3", nullable: true),
                    Cell = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(name: "First Name", nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    IDNumber = table.Column<int>(name: "ID Number", nullable: false),
                    LastName = table.Column<string>(name: "Last Name", nullable: true),
                    Tel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
