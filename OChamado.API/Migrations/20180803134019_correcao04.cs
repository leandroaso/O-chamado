using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class correcao04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Empresa_EmpresaId",
                table: "Atendimento");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "EmpresaSolucao");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_EmpresaId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_EmpresaId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "VendedorCodigo",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Resultado",
                table: "Atendimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendedorCodigo",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Resultado",
                table: "Atendimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaSolucao",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false),
                    SolucaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaSolucao", x => new { x.EmpresaId, x.SolucaoId });
                    table.ForeignKey(
                        name: "FK_EmpresaSolucao_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaSolucao_Solucao_SolucaoId",
                        column: x => x.SolucaoId,
                        principalTable: "Solucao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EmpresaId",
                table: "Cliente",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_EmpresaId",
                table: "Atendimento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaSolucao_SolucaoId",
                table: "EmpresaSolucao",
                column: "SolucaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Empresa_EmpresaId",
                table: "Atendimento",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
