using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class correcao07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "SolucaoId",
                table: "Atendimento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento",
                column: "SolucaoId",
                principalTable: "Solucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento");

            migrationBuilder.AlterColumn<int>(
                name: "SolucaoId",
                table: "Atendimento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento",
                column: "SolucaoId",
                principalTable: "Solucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
