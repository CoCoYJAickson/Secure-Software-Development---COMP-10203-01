using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1A.Migrations
{
    public partial class enbaleNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "Member",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Member",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
