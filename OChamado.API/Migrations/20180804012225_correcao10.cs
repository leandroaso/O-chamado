using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class correcao10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_SolucaoId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "SolucaoId",
                table: "Atendimento");

            migrationBuilder.AddColumn<string>(
                name: "Solucao",
                table: "Atendimento",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Solucao",
                table: "Atendimento");

            migrationBuilder.AddColumn<int>(
                name: "SolucaoId",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_SolucaoId",
                table: "Atendimento",
                column: "SolucaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Solucao_SolucaoId",
                table: "Atendimento",
                column: "SolucaoId",
                principalTable: "Solucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
