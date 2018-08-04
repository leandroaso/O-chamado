using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class correcao05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Responsavel_ResponsavelId",
                table: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                table: "Atendimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Responsavel_ResponsavelId",
                table: "Atendimento",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Responsavel_ResponsavelId",
                table: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "ResponsavelId",
                table: "Atendimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Responsavel_ResponsavelId",
                table: "Atendimento",
                column: "ResponsavelId",
                principalTable: "Responsavel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
