using Microsoft.EntityFrameworkCore.Migrations;

namespace InternetStore.Migrations
{
    public partial class OrderPassport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPasportNumber",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CustomerPassportNumber",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPassportNumber",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CustomerPasportNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
