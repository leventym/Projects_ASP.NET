using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    public partial class updateRepoToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddess",
                table: "OrderHeaders",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "CarrierStatus",
                table: "OrderHeaders",
                newName: "Carrier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "OrderHeaders",
                newName: "StreetAddess");

            migrationBuilder.RenameColumn(
                name: "Carrier",
                table: "OrderHeaders",
                newName: "CarrierStatus");
        }
    }
}
