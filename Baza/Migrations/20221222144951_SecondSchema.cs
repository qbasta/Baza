using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baza.Migrations
{
    public partial class SecondSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Burmistrzs_Miejscowoscs_id_Miejscowosci",
                table: "Burmistrzs");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscOgloszenia_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscOgloszenia");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscOgloszenia_Ogloszenias_OgloszeniaidOgloszenia",
                table: "MiejscowoscOgloszenia");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUslugi_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUslugi");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUslugi_UslugiPublicznes_UslugiPubliczneidUslugiPublicznej",
                table: "MiejscowoscUslugi");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUsterki_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUsterki");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUsterki_Usterkis_UsterkiidUsterki",
                table: "MiejscowoscUsterki");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenias_Usterkis_UsterkaidUsterki",
                table: "Ogloszenias");

            migrationBuilder.DropForeignKey(
                name: "FK_UrzadMiastaInfos_Miejscowoscs_id_Miejscowosci",
                table: "UrzadMiastaInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Zabytek_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "Zabytek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usterkis",
                table: "Usterkis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UslugiPublicznes",
                table: "UslugiPublicznes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UrzadMiastaInfos",
                table: "UrzadMiastaInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogloszenias",
                table: "Ogloszenias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Miejscowoscs",
                table: "Miejscowoscs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Burmistrzs",
                table: "Burmistrzs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aktualnoscis",
                table: "Aktualnoscis");

            migrationBuilder.DropColumn(
                name: "zdjecie",
                table: "Usterkis");

            migrationBuilder.DropColumn(
                name: "zdjecie",
                table: "Ogloszenias");

            migrationBuilder.RenameTable(
                name: "Usterkis",
                newName: "Usterki");

            migrationBuilder.RenameTable(
                name: "UslugiPublicznes",
                newName: "UslugiPubliczne");

            migrationBuilder.RenameTable(
                name: "UrzadMiastaInfos",
                newName: "UrzadMiastaInfo");

            migrationBuilder.RenameTable(
                name: "Ogloszenias",
                newName: "Ogloszenia");

            migrationBuilder.RenameTable(
                name: "Miejscowoscs",
                newName: "Miejscowosc");

            migrationBuilder.RenameTable(
                name: "Burmistrzs",
                newName: "Burmistrz");

            migrationBuilder.RenameTable(
                name: "Aktualnoscis",
                newName: "Aktualnosci");

            migrationBuilder.RenameIndex(
                name: "IX_Ogloszenias_UsterkaidUsterki",
                table: "Ogloszenia",
                newName: "IX_Ogloszenia_UsterkaidUsterki");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usterki",
                table: "Usterki",
                column: "idUsterki");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UslugiPubliczne",
                table: "UslugiPubliczne",
                column: "idUslugiPublicznej");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UrzadMiastaInfo",
                table: "UrzadMiastaInfo",
                column: "id_Miejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogloszenia",
                table: "Ogloszenia",
                column: "idOgloszenia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miejscowosc",
                table: "Miejscowosc",
                column: "idMiejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Burmistrz",
                table: "Burmistrz",
                column: "id_Miejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aktualnosci",
                table: "Aktualnosci",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Burmistrz_Miejscowosc_id_Miejscowosci",
                table: "Burmistrz",
                column: "id_Miejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscOgloszenia_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscOgloszenia",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscOgloszenia_Ogloszenia_OgloszeniaidOgloszenia",
                table: "MiejscowoscOgloszenia",
                column: "OgloszeniaidOgloszenia",
                principalTable: "Ogloszenia",
                principalColumn: "idOgloszenia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUslugi_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUslugi",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUslugi_UslugiPubliczne_UslugiPubliczneidUslugiPublicznej",
                table: "MiejscowoscUslugi",
                column: "UslugiPubliczneidUslugiPublicznej",
                principalTable: "UslugiPubliczne",
                principalColumn: "idUslugiPublicznej",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUsterki_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUsterki",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUsterki_Usterki_UsterkiidUsterki",
                table: "MiejscowoscUsterki",
                column: "UsterkiidUsterki",
                principalTable: "Usterki",
                principalColumn: "idUsterki",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenia_Usterki_UsterkaidUsterki",
                table: "Ogloszenia",
                column: "UsterkaidUsterki",
                principalTable: "Usterki",
                principalColumn: "idUsterki",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UrzadMiastaInfo_Miejscowosc_id_Miejscowosci",
                table: "UrzadMiastaInfo",
                column: "id_Miejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zabytek_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "Zabytek",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowosc",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Burmistrz_Miejscowosc_id_Miejscowosci",
                table: "Burmistrz");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscOgloszenia_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscOgloszenia");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscOgloszenia_Ogloszenia_OgloszeniaidOgloszenia",
                table: "MiejscowoscOgloszenia");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUslugi_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUslugi");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUslugi_UslugiPubliczne_UslugiPubliczneidUslugiPublicznej",
                table: "MiejscowoscUslugi");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUsterki_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUsterki");

            migrationBuilder.DropForeignKey(
                name: "FK_MiejscowoscUsterki_Usterki_UsterkiidUsterki",
                table: "MiejscowoscUsterki");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogloszenia_Usterki_UsterkaidUsterki",
                table: "Ogloszenia");

            migrationBuilder.DropForeignKey(
                name: "FK_UrzadMiastaInfo_Miejscowosc_id_Miejscowosci",
                table: "UrzadMiastaInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Zabytek_Miejscowosc_MiejscowoscidMiejscowosci",
                table: "Zabytek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usterki",
                table: "Usterki");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UslugiPubliczne",
                table: "UslugiPubliczne");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UrzadMiastaInfo",
                table: "UrzadMiastaInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogloszenia",
                table: "Ogloszenia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Miejscowosc",
                table: "Miejscowosc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Burmistrz",
                table: "Burmistrz");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aktualnosci",
                table: "Aktualnosci");

            migrationBuilder.RenameTable(
                name: "Usterki",
                newName: "Usterkis");

            migrationBuilder.RenameTable(
                name: "UslugiPubliczne",
                newName: "UslugiPublicznes");

            migrationBuilder.RenameTable(
                name: "UrzadMiastaInfo",
                newName: "UrzadMiastaInfos");

            migrationBuilder.RenameTable(
                name: "Ogloszenia",
                newName: "Ogloszenias");

            migrationBuilder.RenameTable(
                name: "Miejscowosc",
                newName: "Miejscowoscs");

            migrationBuilder.RenameTable(
                name: "Burmistrz",
                newName: "Burmistrzs");

            migrationBuilder.RenameTable(
                name: "Aktualnosci",
                newName: "Aktualnoscis");

            migrationBuilder.RenameIndex(
                name: "IX_Ogloszenia_UsterkaidUsterki",
                table: "Ogloszenias",
                newName: "IX_Ogloszenias_UsterkaidUsterki");

            migrationBuilder.AddColumn<byte[]>(
                name: "zdjecie",
                table: "Usterkis",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "zdjecie",
                table: "Ogloszenias",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usterkis",
                table: "Usterkis",
                column: "idUsterki");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UslugiPublicznes",
                table: "UslugiPublicznes",
                column: "idUslugiPublicznej");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UrzadMiastaInfos",
                table: "UrzadMiastaInfos",
                column: "id_Miejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogloszenias",
                table: "Ogloszenias",
                column: "idOgloszenia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miejscowoscs",
                table: "Miejscowoscs",
                column: "idMiejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Burmistrzs",
                table: "Burmistrzs",
                column: "id_Miejscowosci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aktualnoscis",
                table: "Aktualnoscis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Burmistrzs_Miejscowoscs_id_Miejscowosci",
                table: "Burmistrzs",
                column: "id_Miejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscOgloszenia_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscOgloszenia",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscOgloszenia_Ogloszenias_OgloszeniaidOgloszenia",
                table: "MiejscowoscOgloszenia",
                column: "OgloszeniaidOgloszenia",
                principalTable: "Ogloszenias",
                principalColumn: "idOgloszenia",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUslugi_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUslugi",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUslugi_UslugiPublicznes_UslugiPubliczneidUslugiPublicznej",
                table: "MiejscowoscUslugi",
                column: "UslugiPubliczneidUslugiPublicznej",
                principalTable: "UslugiPublicznes",
                principalColumn: "idUslugiPublicznej",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUsterki_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUsterki",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MiejscowoscUsterki_Usterkis_UsterkiidUsterki",
                table: "MiejscowoscUsterki",
                column: "UsterkiidUsterki",
                principalTable: "Usterkis",
                principalColumn: "idUsterki",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogloszenias_Usterkis_UsterkaidUsterki",
                table: "Ogloszenias",
                column: "UsterkaidUsterki",
                principalTable: "Usterkis",
                principalColumn: "idUsterki",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UrzadMiastaInfos_Miejscowoscs_id_Miejscowosci",
                table: "UrzadMiastaInfos",
                column: "id_Miejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zabytek_Miejscowoscs_MiejscowoscidMiejscowosci",
                table: "Zabytek",
                column: "MiejscowoscidMiejscowosci",
                principalTable: "Miejscowoscs",
                principalColumn: "idMiejscowosci",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
