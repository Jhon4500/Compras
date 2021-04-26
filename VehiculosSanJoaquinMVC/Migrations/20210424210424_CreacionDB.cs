using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehiculosSanJoaquinMVC.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NS_tblClientes",
                columns: table => new
                {
                    ClId = table.Column<int>(maxLength: 30, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClNombre1 = table.Column<string>(maxLength: 30, nullable: false),
                    ClNombre2 = table.Column<string>(nullable: true),
                    ClApellido1 = table.Column<string>(maxLength: 30, nullable: false),
                    ClApellido2 = table.Column<string>(nullable: true),
                    ClCedula = table.Column<int>(nullable: false),
                    ClCorreo = table.Column<string>(nullable: false),
                    ClTelefono1 = table.Column<string>(nullable: true),
                    ClTelefono2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NS_tblClientes", x => x.ClId);
                });

            migrationBuilder.CreateTable(
                name: "NS_tblListas",
                columns: table => new
                {
                    LiCodigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LiNombre = table.Column<string>(maxLength: 30, nullable: false),
                    LiActivo = table.Column<string>(maxLength: 10, nullable: false),
                    LiCodigoPadre = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NS_tblListas", x => x.LiCodigo);
                });

            migrationBuilder.CreateTable(
                name: "NS_tblListasDetalle",
                columns: table => new
                {
                    LdClave = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LdDescripcion1 = table.Column<string>(maxLength: 60, nullable: false),
                    LdDescripcion2 = table.Column<string>(nullable: true),
                    LdActivoV1 = table.Column<int>(nullable: false),
                    LdUsuario = table.Column<int>(nullable: false),
                    LdFecha = table.Column<DateTime>(nullable: false),
                    LdusuarioCambio = table.Column<int>(nullable: false),
                    LdFechaCambio = table.Column<DateTime>(nullable: false),
                    LdAplicacion = table.Column<string>(nullable: true),
                    LiCodigo = table.Column<int>(nullable: false),
                    ListasLiCodigo = table.Column<int>(nullable: true),
                    ClId = table.Column<int>(nullable: false),
                    ClienteClId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NS_tblListasDetalle", x => x.LdClave);
                    table.ForeignKey(
                        name: "FK_NS_tblListasDetalle_NS_tblClientes_ClienteClId",
                        column: x => x.ClienteClId,
                        principalTable: "NS_tblClientes",
                        principalColumn: "ClId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NS_tblListasDetalle_NS_tblListas_ListasLiCodigo",
                        column: x => x.ListasLiCodigo,
                        principalTable: "NS_tblListas",
                        principalColumn: "LiCodigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NS_tblListasDetalle_ClienteClId",
                table: "NS_tblListasDetalle",
                column: "ClienteClId");

            migrationBuilder.CreateIndex(
                name: "IX_NS_tblListasDetalle_ListasLiCodigo",
                table: "NS_tblListasDetalle",
                column: "ListasLiCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NS_tblListasDetalle");

            migrationBuilder.DropTable(
                name: "NS_tblClientes");

            migrationBuilder.DropTable(
                name: "NS_tblListas");
        }
    }
}
