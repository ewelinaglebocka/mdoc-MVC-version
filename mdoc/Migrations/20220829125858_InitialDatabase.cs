using System;
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mdoc.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    grupa_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    nazwa_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    link_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    typ_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    status_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    data_dodania = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    wydzial = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    aktywny = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    data_wydania = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    osoba_wydająca = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    osoba_dodajaca = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    nazwa_pliku_local = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    data_wygaszenia = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    uwagi = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    nr_dokumentu = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    wersja = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    stanowiska_dostepne = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    stanowiska_wydane = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    kopia_robocza = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    wygas_iD = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    link_dokumentu_ikea = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    data_porownania = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    status_porownania = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    produkt = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    nazwa_ikea = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    numer_ikea = table.Column<int>(type: "INTEGER", nullable: false),
                    ikea = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    aktywny = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    grupa_produktowa = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false),
                    symbol_sente = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documents");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
