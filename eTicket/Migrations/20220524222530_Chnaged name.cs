using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicket.Migrations
{
    public partial class Chnagedname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCtegory",
                table: "Movies",
                newName: "MovieCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "MovieCtegory");
        }
    }
}
