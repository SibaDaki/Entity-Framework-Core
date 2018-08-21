using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebAPI.Migrations
{
    public partial class updateToPersonModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tel",
                table: "Person",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Maiden Name",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maiden Name",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "Tel",
                table: "Person",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
