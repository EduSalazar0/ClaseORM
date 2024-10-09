using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClaseORM.Migrations
{
    /// <inheritdoc />
    public partial class MiPrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteUdla",
                columns: table => new
                {
                    IdBanner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TieneBeca = table.Column<bool>(type: "bit", nullable: false),
                    IdCarrera = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteUdla", x => x.IdBanner);
                    table.ForeignKey(
                        name: "FK_EstudianteUdla_Carrera_IdCarrera",
                        column: x => x.IdCarrera,
                        principalTable: "Carrera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteUdla_IdCarrera",
                table: "EstudianteUdla",
                column: "IdCarrera");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudianteUdla");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}
