﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OChamado.API;
using OChamado.API.Class;
using System;

namespace OChamado.API.Migrations
{
    [DbContext(typeof(ChamadoContext))]
    [Migration("20180803182052_correcao08")]
    partial class correcao08
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OChamado.API.Models.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aplicacao");

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataFinalizacao");

                    b.Property<string>("Descricao");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Motivo");

                    b.Property<int?>("ResponsavelId");

                    b.Property<int?>("SolucaoId");

                    b.Property<int>("StatusAtendimento");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ResponsavelId");

                    b.HasIndex("SolucaoId");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("OChamado.API.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("OChamado.API.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("OChamado.API.Models.Solucao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Solucao");
                });

            modelBuilder.Entity("OChamado.API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("OChamado.API.Models.Atendimento", b =>
                {
                    b.HasOne("OChamado.API.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OChamado.API.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId");

                    b.HasOne("OChamado.API.Models.Solucao", "Solucao")
                        .WithMany()
                        .HasForeignKey("SolucaoId");
                });

            modelBuilder.Entity("OChamado.API.Models.Responsavel", b =>
                {
                    b.HasOne("OChamado.API.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
