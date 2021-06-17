using Microsoft.EntityFrameworkCore.Migrations;

namespace PeliculasApi.Migrations
{
    public partial class ChangeTable_PeliculasGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasgENERO_Generos_GeneroId",
                table: "PeliculasgENERO");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasgENERO_Peliculas_PeliculaId",
                table: "PeliculasgENERO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculasgENERO",
                table: "PeliculasgENERO");

            migrationBuilder.RenameTable(
                name: "PeliculasgENERO",
                newName: "PeliculasGenero");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculasgENERO_PeliculaId",
                table: "PeliculasGenero",
                newName: "IX_PeliculasGenero_PeliculaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculasGenero",
                table: "PeliculasGenero",
                columns: new[] { "GeneroId", "PeliculaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasGenero_Generos_GeneroId",
                table: "PeliculasGenero",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasGenero_Peliculas_PeliculaId",
                table: "PeliculasGenero",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasGenero_Generos_GeneroId",
                table: "PeliculasGenero");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasGenero_Peliculas_PeliculaId",
                table: "PeliculasGenero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeliculasGenero",
                table: "PeliculasGenero");

            migrationBuilder.RenameTable(
                name: "PeliculasGenero",
                newName: "PeliculasgENERO");

            migrationBuilder.RenameIndex(
                name: "IX_PeliculasGenero_PeliculaId",
                table: "PeliculasgENERO",
                newName: "IX_PeliculasgENERO_PeliculaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeliculasgENERO",
                table: "PeliculasgENERO",
                columns: new[] { "GeneroId", "PeliculaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasgENERO_Generos_GeneroId",
                table: "PeliculasgENERO",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasgENERO_Peliculas_PeliculaId",
                table: "PeliculasgENERO",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
