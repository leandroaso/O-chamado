using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class correcao08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Usuarios_UsuarioId",
                table: "Responsavel");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Responsavel",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Usuarios_UsuarioId",
                table: "Responsavel",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responsavel_Usuarios_UsuarioId",
                table: "Responsavel");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "Responsavel",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsavel_Usuarios_UsuarioId",
                table: "Responsavel",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
