using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baza.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktualnoscis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    zdjecie = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktualnoscis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Miejscowoscs",
                columns: table => new
                {
                    idMiejscowosci = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    liczbaMieszkancow = table.Column<int>(type: "int", nullable: false),
                    powierzchnia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejscowoscs", x => x.idMiejscowosci);
                });

            migrationBuilder.CreateTable(
                name: "UslugiPublicznes",
                columns: table => new
                {
                    idUslugiPublicznej = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    udogodnienia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UslugiPublicznes", x => x.idUslugiPublicznej);
                });

            migrationBuilder.CreateTable(
                name: "Usterkis",
                columns: table => new
                {
                    idUsterki = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typUsterki = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Miejscowosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataZgloszenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zdjecie = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usterkis", x => x.idUsterki);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Burmistrzs",
                columns: table => new
                {
                    id_Miejscowosci = table.Column<int>(type: "int", nullable: false),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kadencja = table.Column<int>(type: "int", nullable: false),
                    pierwszaKadencja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    drugaKadencja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burmistrzs", x => x.id_Miejscowosci);
                    table.ForeignKey(
                        name: "FK_Burmistrzs_Miejscowoscs_id_Miejscowosci",
                        column: x => x.id_Miejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrzadMiastaInfos",
                columns: table => new
                {
                    id_Miejscowosci = table.Column<int>(type: "int", nullable: false),
                    telefonKontaktowy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    godzinyOtwarcia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    godzinyZamknięcia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrzadMiastaInfos", x => x.id_Miejscowosci);
                    table.ForeignKey(
                        name: "FK_UrzadMiastaInfos_Miejscowoscs_id_Miejscowosci",
                        column: x => x.id_Miejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zabytek",
                columns: table => new
                {
                    idZabytku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wsp_Lat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wsp_Lng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    MiejscowoscidMiejscowosci = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zabytek", x => x.idZabytku);
                    table.ForeignKey(
                        name: "FK_Zabytek_Miejscowoscs_MiejscowoscidMiejscowosci",
                        column: x => x.MiejscowoscidMiejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiejscowoscUslugi",
                columns: table => new
                {
                    MiastoUslugiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    idUslugi = table.Column<int>(type: "int", nullable: false),
                    MiejscowoscidMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    UslugiPubliczneidUslugiPublicznej = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiejscowoscUslugi", x => x.MiastoUslugiId);
                    table.ForeignKey(
                        name: "FK_MiejscowoscUslugi_Miejscowoscs_MiejscowoscidMiejscowosci",
                        column: x => x.MiejscowoscidMiejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiejscowoscUslugi_UslugiPublicznes_UslugiPubliczneidUslugiPublicznej",
                        column: x => x.UslugiPubliczneidUslugiPublicznej,
                        principalTable: "UslugiPublicznes",
                        principalColumn: "idUslugiPublicznej",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiejscowoscUsterki",
                columns: table => new
                {
                    UsterkaMiastoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    idUsterki = table.Column<int>(type: "int", nullable: false),
                    MiejscowoscidMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    UsterkiidUsterki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiejscowoscUsterki", x => x.UsterkaMiastoId);
                    table.ForeignKey(
                        name: "FK_MiejscowoscUsterki_Miejscowoscs_MiejscowoscidMiejscowosci",
                        column: x => x.MiejscowoscidMiejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiejscowoscUsterki_Usterkis_UsterkiidUsterki",
                        column: x => x.UsterkiidUsterki,
                        principalTable: "Usterkis",
                        principalColumn: "idUsterki",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ogloszenias",
                columns: table => new
                {
                    idOgloszenia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Miejscowosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataZgloszenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zdjecie = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UsterkaidUsterki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogloszenias", x => x.idOgloszenia);
                    table.ForeignKey(
                        name: "FK_Ogloszenias_Usterkis_UsterkaidUsterki",
                        column: x => x.UsterkaidUsterki,
                        principalTable: "Usterkis",
                        principalColumn: "idUsterki",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MiejscowoscOgloszenia",
                columns: table => new
                {
                    OgloszeniaMiejscowoscId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    idAktualnosci = table.Column<int>(type: "int", nullable: false),
                    MiejscowoscidMiejscowosci = table.Column<int>(type: "int", nullable: false),
                    OgloszeniaidOgloszenia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiejscowoscOgloszenia", x => x.OgloszeniaMiejscowoscId);
                    table.ForeignKey(
                        name: "FK_MiejscowoscOgloszenia_Miejscowoscs_MiejscowoscidMiejscowosci",
                        column: x => x.MiejscowoscidMiejscowosci,
                        principalTable: "Miejscowoscs",
                        principalColumn: "idMiejscowosci",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MiejscowoscOgloszenia_Ogloszenias_OgloszeniaidOgloszenia",
                        column: x => x.OgloszeniaidOgloszenia,
                        principalTable: "Ogloszenias",
                        principalColumn: "idOgloszenia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscOgloszenia_MiejscowoscidMiejscowosci",
                table: "MiejscowoscOgloszenia",
                column: "MiejscowoscidMiejscowosci");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscOgloszenia_OgloszeniaidOgloszenia",
                table: "MiejscowoscOgloszenia",
                column: "OgloszeniaidOgloszenia");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscUslugi_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUslugi",
                column: "MiejscowoscidMiejscowosci");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscUslugi_UslugiPubliczneidUslugiPublicznej",
                table: "MiejscowoscUslugi",
                column: "UslugiPubliczneidUslugiPublicznej");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscUsterki_MiejscowoscidMiejscowosci",
                table: "MiejscowoscUsterki",
                column: "MiejscowoscidMiejscowosci");

            migrationBuilder.CreateIndex(
                name: "IX_MiejscowoscUsterki_UsterkiidUsterki",
                table: "MiejscowoscUsterki",
                column: "UsterkiidUsterki");

            migrationBuilder.CreateIndex(
                name: "IX_Ogloszenias_UsterkaidUsterki",
                table: "Ogloszenias",
                column: "UsterkaidUsterki");

            migrationBuilder.CreateIndex(
                name: "IX_Zabytek_MiejscowoscidMiejscowosci",
                table: "Zabytek",
                column: "MiejscowoscidMiejscowosci");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktualnoscis");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Burmistrzs");

            migrationBuilder.DropTable(
                name: "MiejscowoscOgloszenia");

            migrationBuilder.DropTable(
                name: "MiejscowoscUslugi");

            migrationBuilder.DropTable(
                name: "MiejscowoscUsterki");

            migrationBuilder.DropTable(
                name: "UrzadMiastaInfos");

            migrationBuilder.DropTable(
                name: "Zabytek");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ogloszenias");

            migrationBuilder.DropTable(
                name: "UslugiPublicznes");

            migrationBuilder.DropTable(
                name: "Miejscowoscs");

            migrationBuilder.DropTable(
                name: "Usterkis");
        }
    }
}
