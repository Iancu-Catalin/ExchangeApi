using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExchangeApi.Migrations
{
    public partial class secondmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToAdress",
                table: "Withdrawals",
                newName: "ToAddress");

            migrationBuilder.RenameColumn(
                name: "FromAdress",
                table: "Deposits",
                newName: "FromAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToAddress",
                table: "Withdrawals",
                newName: "ToAdress");

            migrationBuilder.RenameColumn(
                name: "FromAddress",
                table: "Deposits",
                newName: "FromAdress");
        }
    }
}
