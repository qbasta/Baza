﻿// <auto-generated />
using System;
using Baza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Baza.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Baza.Models.Aktualnosci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Aktualnoscis");
                });

            modelBuilder.Entity("Baza.Models.Burmistrz", b =>
                {
                    b.Property<int>("id_Miejscowosci")
                        .HasColumnType("int");

                    b.Property<DateTime?>("drugaKadencja")
                        .HasColumnType("datetime2");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kadencja")
                        .HasColumnType("int");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("pierwszaKadencja")
                        .HasColumnType("datetime2");

                    b.HasKey("id_Miejscowosci");

                    b.ToTable("Burmistrzs");
                });

            modelBuilder.Entity("Baza.Models.Miejscowosc", b =>
                {
                    b.Property<int>("idMiejscowosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMiejscowosci"), 1L, 1);

                    b.Property<int>("liczbaMieszkancow")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("powierzchnia")
                        .HasColumnType("int");

                    b.HasKey("idMiejscowosci");

                    b.ToTable("Miejscowoscs");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscAktualnosci", b =>
                {
                    b.Property<int>("AktualnosciMiejscowoscId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AktualnosciMiejscowoscId"), 1L, 1);

                    b.Property<int>("AktualnosciId")
                        .HasColumnType("int");

                    b.Property<int>("MiejscowoscidMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("idAktualnosci")
                        .HasColumnType("int");

                    b.Property<int>("idMiejscowosci")
                        .HasColumnType("int");

                    b.HasKey("AktualnosciMiejscowoscId");

                    b.HasIndex("AktualnosciId");

                    b.HasIndex("MiejscowoscidMiejscowosci");

                    b.ToTable("MiejscowoscAktualnosci");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscUslugi", b =>
                {
                    b.Property<int>("MiastoUslugiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MiastoUslugiId"), 1L, 1);

                    b.Property<int>("MiejscowoscidMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("UslugiPubliczneidUslugiPublicznej")
                        .HasColumnType("int");

                    b.Property<int>("idMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("idUslugi")
                        .HasColumnType("int");

                    b.HasKey("MiastoUslugiId");

                    b.HasIndex("MiejscowoscidMiejscowosci");

                    b.HasIndex("UslugiPubliczneidUslugiPublicznej");

                    b.ToTable("MiejscowoscUslugi");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscZgloszenie", b =>
                {
                    b.Property<int>("ZgloszenieMiastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZgloszenieMiastoId"), 1L, 1);

                    b.Property<int>("MiejscowoscidMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("ZgloszenieidZgloszenia")
                        .HasColumnType("int");

                    b.Property<int>("idMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("idZgloszenia")
                        .HasColumnType("int");

                    b.HasKey("ZgloszenieMiastoId");

                    b.HasIndex("MiejscowoscidMiejscowosci");

                    b.HasIndex("ZgloszenieidZgloszenia");

                    b.ToTable("MiejscowoscZgloszenie");
                });

            modelBuilder.Entity("Baza.Models.Serwis", b =>
                {
                    b.Property<int>("idSerwisu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSerwisu"), 1L, 1);

                    b.Property<int>("NIP")
                        .HasColumnType("int");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSerwisu");

                    b.ToTable("Serwis");
                });

            modelBuilder.Entity("Baza.Models.SerwisMiejscowosc", b =>
                {
                    b.Property<int>("serwisMiejscowoscId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("serwisMiejscowoscId"), 1L, 1);

                    b.Property<int>("MiejscowoscidMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("SerwisidSerwisu")
                        .HasColumnType("int");

                    b.Property<int>("idMiejscowosci")
                        .HasColumnType("int");

                    b.Property<int>("idSerwisu")
                        .HasColumnType("int");

                    b.HasKey("serwisMiejscowoscId");

                    b.HasIndex("MiejscowoscidMiejscowosci");

                    b.HasIndex("SerwisidSerwisu");

                    b.ToTable("SerwisMiejscowosc");
                });

            modelBuilder.Entity("Baza.Models.SerwisUsterka", b =>
                {
                    b.Property<int>("SerwisUsterkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SerwisUsterkaId"), 1L, 1);

                    b.Property<int>("SerwisidSerwisu")
                        .HasColumnType("int");

                    b.Property<int>("UsterkiidUsterki")
                        .HasColumnType("int");

                    b.Property<int>("idSerwisu")
                        .HasColumnType("int");

                    b.Property<int>("idUsterki")
                        .HasColumnType("int");

                    b.HasKey("SerwisUsterkaId");

                    b.HasIndex("SerwisidSerwisu");

                    b.HasIndex("UsterkiidUsterki");

                    b.ToTable("SerwisUsterka");
                });

            modelBuilder.Entity("Baza.Models.UrzadMiasta", b =>
                {
                    b.Property<int>("id_Miejscowosci")
                        .HasColumnType("int");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("godzinyOtwarcia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("godzinyZamknięcia")
                        .HasColumnType("datetime2");

                    b.Property<string>("telefonKontaktowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Miejscowosci");

                    b.ToTable("UrzadMiastas");
                });

            modelBuilder.Entity("Baza.Models.UslugiPubliczne", b =>
                {
                    b.Property<int>("idUslugiPublicznej")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUslugiPublicznej"), 1L, 1);

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("udogodnienia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUslugiPublicznej");

                    b.ToTable("UslugiPublicznes");
                });

            modelBuilder.Entity("Baza.Models.Usterki", b =>
                {
                    b.Property<int>("idUsterki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsterki"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miejscowosc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dataZgloszenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typUsterki")
                        .HasColumnType("int");

                    b.HasKey("idUsterki");

                    b.ToTable("Usterkis");
                });

            modelBuilder.Entity("Baza.Models.Zabytek", b =>
                {
                    b.Property<int>("idZabytku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idZabytku"), 1L, 1);

                    b.Property<int>("MiejscowoscidMiejscowosci")
                        .HasColumnType("int");

                    b.Property<string>("Wsp_Lat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wsp_Lng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMiejscowosci")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idZabytku");

                    b.HasIndex("MiejscowoscidMiejscowosci");

                    b.ToTable("Zabytek");
                });

            modelBuilder.Entity("Baza.Models.Zgloszenie", b =>
                {
                    b.Property<int>("idZgloszenia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idZgloszenia"), 1L, 1);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miejscowosc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsterkaidUsterki")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dataZgloszenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typUsterki")
                        .HasColumnType("int");

                    b.HasKey("idZgloszenia");

                    b.HasIndex("UsterkaidUsterki");

                    b.ToTable("Zgloszenies");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Baza.Models.Burmistrz", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithOne("Burmitrz")
                        .HasForeignKey("Baza.Models.Burmistrz", "id_Miejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscAktualnosci", b =>
                {
                    b.HasOne("Baza.Models.Aktualnosci", "Aktualnosci")
                        .WithMany("MiejscowoscAktualnosci")
                        .HasForeignKey("AktualnosciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithMany("MiejscowoscAktualnosci")
                        .HasForeignKey("MiejscowoscidMiejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aktualnosci");

                    b.Navigation("Miejscowosc");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscUslugi", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithMany("GminaUslugi")
                        .HasForeignKey("MiejscowoscidMiejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Baza.Models.UslugiPubliczne", "UslugiPubliczne")
                        .WithMany("MiejscowoscUslugi")
                        .HasForeignKey("UslugiPubliczneidUslugiPublicznej")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");

                    b.Navigation("UslugiPubliczne");
                });

            modelBuilder.Entity("Baza.Models.MiejscowoscZgloszenie", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithMany("MiejscowoscZgloszenie")
                        .HasForeignKey("MiejscowoscidMiejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Baza.Models.Zgloszenie", "Zgloszenie")
                        .WithMany("MiejscowoscZgloszenie")
                        .HasForeignKey("ZgloszenieidZgloszenia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");

                    b.Navigation("Zgloszenie");
                });

            modelBuilder.Entity("Baza.Models.SerwisMiejscowosc", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithMany("SerwisMiejscowosc")
                        .HasForeignKey("MiejscowoscidMiejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Baza.Models.Serwis", "Serwis")
                        .WithMany("SerwisMiejscowosc")
                        .HasForeignKey("SerwisidSerwisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");

                    b.Navigation("Serwis");
                });

            modelBuilder.Entity("Baza.Models.SerwisUsterka", b =>
                {
                    b.HasOne("Baza.Models.Serwis", "Serwis")
                        .WithMany("SerwisUsterka")
                        .HasForeignKey("SerwisidSerwisu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Baza.Models.Usterki", "Usterki")
                        .WithMany()
                        .HasForeignKey("UsterkiidUsterki")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Serwis");

                    b.Navigation("Usterki");
                });

            modelBuilder.Entity("Baza.Models.UrzadMiasta", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithOne("UrzadMiasta")
                        .HasForeignKey("Baza.Models.UrzadMiasta", "id_Miejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");
                });

            modelBuilder.Entity("Baza.Models.Zabytek", b =>
                {
                    b.HasOne("Baza.Models.Miejscowosc", "Miejscowosc")
                        .WithMany("Zabytki")
                        .HasForeignKey("MiejscowoscidMiejscowosci")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miejscowosc");
                });

            modelBuilder.Entity("Baza.Models.Zgloszenie", b =>
                {
                    b.HasOne("Baza.Models.Usterki", "Usterka")
                        .WithMany("Zgloszenie")
                        .HasForeignKey("UsterkaidUsterki")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usterka");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Baza.Models.Aktualnosci", b =>
                {
                    b.Navigation("MiejscowoscAktualnosci");
                });

            modelBuilder.Entity("Baza.Models.Miejscowosc", b =>
                {
                    b.Navigation("Burmitrz")
                        .IsRequired();

                    b.Navigation("GminaUslugi");

                    b.Navigation("MiejscowoscAktualnosci");

                    b.Navigation("MiejscowoscZgloszenie");

                    b.Navigation("SerwisMiejscowosc");

                    b.Navigation("UrzadMiasta")
                        .IsRequired();

                    b.Navigation("Zabytki");
                });

            modelBuilder.Entity("Baza.Models.Serwis", b =>
                {
                    b.Navigation("SerwisMiejscowosc");

                    b.Navigation("SerwisUsterka");
                });

            modelBuilder.Entity("Baza.Models.UslugiPubliczne", b =>
                {
                    b.Navigation("MiejscowoscUslugi");
                });

            modelBuilder.Entity("Baza.Models.Usterki", b =>
                {
                    b.Navigation("Zgloszenie");
                });

            modelBuilder.Entity("Baza.Models.Zgloszenie", b =>
                {
                    b.Navigation("MiejscowoscZgloszenie");
                });
#pragma warning restore 612, 618
        }
    }
}
