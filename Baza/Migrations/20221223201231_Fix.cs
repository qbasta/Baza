using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baza.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenia_Usterki_UsterkaidUsterki",
                table: "Ogloszenia");

            migrationBuilder.DropIndex(
                name: "IX_Ogloszenia_UsterkaidUsterki",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "UsterkaidUsterki",
                table: "Ogloszenia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsterkaidUsterki",
                table: "Ogloszenia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogloszenia_UsterkaidUsterki",
                table: "Ogloszenia",
                column: "UsterkaidUsterki");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenia_Usterki_UsterkaidUsterki",
                table: "Ogloszenia",
                column: "UsterkaidUsterki",
                principalTable: "Usterki",
                principalColumn: "idUsterki",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
