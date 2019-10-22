using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1A.Migrations
{
    public partial class modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Dealership",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Dealership",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
