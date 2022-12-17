using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baza.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Zgloszenies");

            migrationBuilder.DropColumn(
                name: "Wsp_Lat",
                table: "Zgloszenies");

            migrationBuilder.RenameColumn(
                name: "Wsp_Lng",
                table: "Zgloszenies",
                newName: "Miejscowosc");

            migrationBuilder.RenameColumn(
                name: "Wsp_Lng",
                table: "Usterkis",
                newName: "Miejscowosc");

            migrationBuilder.AddColumn<DateTime>(
                name: "dataZgloszenia",
                table: "Usterkis",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataZgloszenia",
                table: "Usterkis");

            migrationBuilder.RenameColumn(
                name: "Miejscowosc",
                table: "Zgloszenies",
                newName: "Wsp_Lng");

            migrationBuilder.RenameColumn(
                name: "Miejscowosc",
                table: "Usterkis",
                newName: "Wsp_Lng");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Zgloszenies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wsp_Lat",
                table: "Zgloszenies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
