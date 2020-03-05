using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HousesPeru.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Precio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publicacions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    ApellidoP = table.Column<string>(nullable: true),
                    ApellidoM = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    TipoUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    InmuebleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: false),
                    NombreInm = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    NumHabitaciones = table.Column<string>(nullable: true),
                    Pisos = table.Column<string>(nullable: true),
                    Piso = table.Column<string>(nullable: true),
                    PrecioVentaInm = table.Column<string>(nullable: true),
                    PrecioAlquilerInm = table.Column<string>(nullable: true),
                    UbicacionInm = table.Column<string>(nullable: true),
                    FechaPublic = table.Column<DateTime>(nullable: false),
                    CiudadInmueble = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    EstaActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.InmuebleId);
                    table.ForeignKey(
                        name: "FK_Inmuebles_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    ImagenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(nullable: true),
                    InmuebleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.ImagenId);
                    table.ForeignKey(
                        name: "FK_Imagens_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InmuebleTipos",
                columns: table => new
                {
                    InmuebleTipoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    InmuebleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InmuebleTipos", x => x.InmuebleTipoId);
                    table.ForeignKey(
                        name: "FK_InmuebleTipos_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanPublicacions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(nullable: false),
                    PublicacionId = table.Column<int>(nullable: false),
                    InmuebleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanPublicacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanPublicacions_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanPublicacions_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanPublicacions_Publicacions_PublicacionId",
                        column: x => x.PublicacionId,
                        principalTable: "Publicacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_InmuebleId",
                table: "Imagens",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_UsuarioId",
                table: "Inmuebles",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InmuebleTipos_InmuebleId",
                table: "InmuebleTipos",
                column: "InmuebleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanPublicacions_InmuebleId",
                table: "PlanPublicacions",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanPublicacions_PlanId",
                table: "PlanPublicacions",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanPublicacions_PublicacionId",
                table: "PlanPublicacions",
                column: "PublicacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "InmuebleTipos");

            migrationBuilder.DropTable(
                name: "PlanPublicacions");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Publicacions");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
