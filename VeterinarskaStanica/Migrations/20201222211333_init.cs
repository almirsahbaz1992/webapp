using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeterinarskaStanica.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dijagnoze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv_dijagnoze = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifra_dijagnoze = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dijagnoze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gradovii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalozi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true),
                    doc = table.Column<bool>(type: "bit", nullable: false),
                    teh_osob = table.Column<bool>(type: "bit", nullable: false),
                    admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalozi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lijekovii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vrsta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rok_trajanja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lijekovii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Odjelii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odjelii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Racunii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IznosZaPlatiti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racunii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StrucneSpremee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrucneSpremee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terapije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Vrsta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumTerapije = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NazivUloge = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uslugee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumUsluge = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uslugee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vlasnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vrste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vrste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zvanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zvanja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tehnicka_osoblja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Vrsta_posla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradoviId = table.Column<int>(type: "int", nullable: true),
                    OdjeliId = table.Column<int>(type: "int", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tehnicka_osoblja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tehnicka_osoblja_Gradovii_GradoviId",
                        column: x => x.GradoviId,
                        principalTable: "Gradovii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tehnicka_osoblja_KorisnickiNalozi_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tehnicka_osoblja_Odjelii_OdjeliId",
                        column: x => x.OdjeliId,
                        principalTable: "Odjelii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KupljeniLijekovii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    RacuniId = table.Column<int>(type: "int", nullable: false),
                    LijekoviId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupljeniLijekovii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KupljeniLijekovii_Lijekovii_LijekoviId",
                        column: x => x.LijekoviId,
                        principalTable: "Lijekovii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupljeniLijekovii_Racunii_RacuniId",
                        column: x => x.RacuniId,
                        principalTable: "Racunii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Iznos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RacuniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uplate_Racunii_RacuniId",
                        column: x => x.RacuniId,
                        principalTable: "Racunii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administratori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: false),
                    StrucneSpremeId = table.Column<int>(type: "int", nullable: true),
                    GradoviId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administratori_Gradovii_GradoviId",
                        column: x => x.GradoviId,
                        principalTable: "Gradovii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administratori_KorisnickiNalozi_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Administratori_StrucneSpremee_StrucneSpremeId",
                        column: x => x.StrucneSpremeId,
                        principalTable: "StrucneSpremee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IzvrseneUslugee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RacuniId = table.Column<int>(type: "int", nullable: false),
                    UslugeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzvrseneUslugee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IzvrseneUslugee_Racunii_RacuniId",
                        column: x => x.RacuniId,
                        principalTable: "Racunii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IzvrseneUslugee_Uslugee_UslugeId",
                        column: x => x.UslugeId,
                        principalTable: "Uslugee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacijenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godiste = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPrijema = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VlasnikId = table.Column<int>(type: "int", nullable: false),
                    VrstaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacijenti_Vlasnici_VlasnikId",
                        column: x => x.VlasnikId,
                        principalTable: "Vlasnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacijenti_Vrste_VrstaId",
                        column: x => x.VrstaId,
                        principalTable: "Vrste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doktori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Pozicija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradoviId = table.Column<int>(type: "int", nullable: true),
                    ZvanjeId = table.Column<int>(type: "int", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktori_Gradovii_GradoviId",
                        column: x => x.GradoviId,
                        principalTable: "Gradovii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doktori_KorisnickiNalozi_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doktori_Zvanja_ZvanjeId",
                        column: x => x.ZvanjeId,
                        principalTable: "Zvanja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pregledii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DatumPregleda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    RacuniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregledii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pregledii_Doktori_DoktorId",
                        column: x => x.DoktorId,
                        principalTable: "Doktori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pregledii_Pacijenti_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pregledii_Racunii_RacuniId",
                        column: x => x.RacuniId,
                        principalTable: "Racunii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefinsanaTerapije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Doziranje = table.Column<int>(type: "int", nullable: false),
                    PreglediId = table.Column<int>(type: "int", nullable: false),
                    TerapijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinsanaTerapije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefinsanaTerapije_Pregledii_PreglediId",
                        column: x => x.PreglediId,
                        principalTable: "Pregledii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefinsanaTerapije_Terapije_TerapijaId",
                        column: x => x.TerapijaId,
                        principalTable: "Terapije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UspostavljenaDijagnoze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Intezitet = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DijagnozaId = table.Column<int>(type: "int", nullable: false),
                    PreglediId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UspostavljenaDijagnoze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UspostavljenaDijagnoze_Dijagnoze_DijagnozaId",
                        column: x => x.DijagnozaId,
                        principalTable: "Dijagnoze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UspostavljenaDijagnoze_Pregledii_PreglediId",
                        column: x => x.PreglediId,
                        principalTable: "Pregledii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administratori_GradoviId",
                table: "Administratori",
                column: "GradoviId");

            migrationBuilder.CreateIndex(
                name: "IX_Administratori_KorisnickiNalogId",
                table: "Administratori",
                column: "KorisnickiNalogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Administratori_StrucneSpremeId",
                table: "Administratori",
                column: "StrucneSpremeId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinsanaTerapije_PreglediId",
                table: "DefinsanaTerapije",
                column: "PreglediId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinsanaTerapije_TerapijaId",
                table: "DefinsanaTerapije",
                column: "TerapijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktori_GradoviId",
                table: "Doktori",
                column: "GradoviId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktori_KorisnickiNalogId",
                table: "Doktori",
                column: "KorisnickiNalogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doktori_ZvanjeId",
                table: "Doktori",
                column: "ZvanjeId");

            migrationBuilder.CreateIndex(
                name: "IX_IzvrseneUslugee_RacuniId",
                table: "IzvrseneUslugee",
                column: "RacuniId");

            migrationBuilder.CreateIndex(
                name: "IX_IzvrseneUslugee_UslugeId",
                table: "IzvrseneUslugee",
                column: "UslugeId");

            migrationBuilder.CreateIndex(
                name: "IX_KupljeniLijekovii_LijekoviId",
                table: "KupljeniLijekovii",
                column: "LijekoviId");

            migrationBuilder.CreateIndex(
                name: "IX_KupljeniLijekovii_RacuniId",
                table: "KupljeniLijekovii",
                column: "RacuniId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacijenti_VlasnikId",
                table: "Pacijenti",
                column: "VlasnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacijenti_VrstaId",
                table: "Pacijenti",
                column: "VrstaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregledii_DoktorId",
                table: "Pregledii",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregledii_PacijentId",
                table: "Pregledii",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregledii_RacuniId",
                table: "Pregledii",
                column: "RacuniId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehnicka_osoblja_GradoviId",
                table: "Tehnicka_osoblja",
                column: "GradoviId");

            migrationBuilder.CreateIndex(
                name: "IX_Tehnicka_osoblja_KorisnickiNalogId",
                table: "Tehnicka_osoblja",
                column: "KorisnickiNalogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tehnicka_osoblja_OdjeliId",
                table: "Tehnicka_osoblja",
                column: "OdjeliId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_RacuniId",
                table: "Uplate",
                column: "RacuniId");

            migrationBuilder.CreateIndex(
                name: "IX_UspostavljenaDijagnoze_DijagnozaId",
                table: "UspostavljenaDijagnoze",
                column: "DijagnozaId");

            migrationBuilder.CreateIndex(
                name: "IX_UspostavljenaDijagnoze_PreglediId",
                table: "UspostavljenaDijagnoze",
                column: "PreglediId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administratori");

            migrationBuilder.DropTable(
                name: "DefinsanaTerapije");

            migrationBuilder.DropTable(
                name: "IzvrseneUslugee");

            migrationBuilder.DropTable(
                name: "KupljeniLijekovii");

            migrationBuilder.DropTable(
                name: "Tehnicka_osoblja");

            migrationBuilder.DropTable(
                name: "Uloges");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "UspostavljenaDijagnoze");

            migrationBuilder.DropTable(
                name: "StrucneSpremee");

            migrationBuilder.DropTable(
                name: "Terapije");

            migrationBuilder.DropTable(
                name: "Uslugee");

            migrationBuilder.DropTable(
                name: "Lijekovii");

            migrationBuilder.DropTable(
                name: "Odjelii");

            migrationBuilder.DropTable(
                name: "Dijagnoze");

            migrationBuilder.DropTable(
                name: "Pregledii");

            migrationBuilder.DropTable(
                name: "Doktori");

            migrationBuilder.DropTable(
                name: "Pacijenti");

            migrationBuilder.DropTable(
                name: "Racunii");

            migrationBuilder.DropTable(
                name: "Gradovii");

            migrationBuilder.DropTable(
                name: "KorisnickiNalozi");

            migrationBuilder.DropTable(
                name: "Zvanja");

            migrationBuilder.DropTable(
                name: "Vlasnici");

            migrationBuilder.DropTable(
                name: "Vrste");
        }
    }
}
