using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace OChamado.API.Migrations
{
    public partial class novas_propriedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_ClienteId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "HoraCriacao",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "HoraFinalizacao",
                table: "Atendimento");

            migrationBuilder.AlterColumn<string>(
                name: "VendedorCodigo",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Aplicacao",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteEmail",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "Atendimento",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                columns: new[] { "Id", "Email" });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ClienteId1_ClienteEmail",
                table: "Atendimento",
                columns: new[] { "ClienteId1", "ClienteEmail" });

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId1_ClienteEmail",
                table: "Atendimento",
                columns: new[] { "ClienteId1", "ClienteEmail" },
                principalTable: "Cliente",
                principalColumns: new[] { "Id", "Email" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId1_ClienteEmail",
                table: "Atendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_ClienteId1_ClienteEmail",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Aplicacao",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "ClienteEmail",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "Atendimento");

            migrationBuilder.AlterColumn<string>(
                name: "VendedorCodigo",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Cliente",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraCriacao",
                table: "Atendimento",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraFinalizacao",
                table: "Atendimento",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ClienteId",
                table: "Atendimento",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Cliente_ClienteId",
                table: "Atendimento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
