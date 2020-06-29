using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class deletebehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_film_language_language_id",
                table: "film");

            migrationBuilder.DropForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film");

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_language_id",
                table: "film",
                column: "language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film",
                column: "original_language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_film_language_language_id",
                table: "film");

            migrationBuilder.DropForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film");

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_language_id",
                table: "film",
                column: "language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film",
                column: "original_language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
