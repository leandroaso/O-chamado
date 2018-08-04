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
    [Migration("20180803132107_novas_propriedades")]
    partial class novas_propriedades
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

                    b.Property<string>("ClienteEmail");

                    b.Property<int>("ClienteId");

                    b.Property<int?>("ClienteId1");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataFinalizacao");

                    b.Property<string>("Descricao");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Motivo");

                    b.Property<int>("ResponsavelId");

                    b.Property<int>("Resultado");

                    b.Property<int>("SolucaoId");

                    b.Property<int>("StatusAtendimento");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ResponsavelId");

                    b.HasIndex("SolucaoId");

                    b.HasIndex("ClienteId1", "ClienteEmail");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("OChamado.API.Models.Cliente", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Email");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.Property<string>("VendedorCodigo");

                    b.HasKey("Id", "Email");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("OChamado.API.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("OChamado.API.Models.EmpresaSolucao", b =>
                {
                    b.Property<int>("EmpresaId");

                    b.Property<int>("SolucaoId");

                    b.HasKey("EmpresaId", "SolucaoId");

                    b.HasIndex("SolucaoId");

                    b.ToTable("EmpresaSolucao");
                });

            modelBuilder.Entity("OChamado.API.Models.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

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
                    b.HasOne("OChamado.API.Models.Empresa", "Empresa")
                        .WithMany("Atendimento")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("OChamado.API.Models.Responsavel", "Responsavel")
                        .WithMany()
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OChamado.API.Models.Solucao", "Solucao")
                        .WithMany()
                        .HasForeignKey("SolucaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OChamado.API.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1", "ClienteEmail");
                });

            modelBuilder.Entity("OChamado.API.Models.Cliente", b =>
                {
                    b.HasOne("OChamado.API.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OChamado.API.Models.EmpresaSolucao", b =>
                {
                    b.HasOne("OChamado.API.Models.Empresa", "Empresa")
                        .WithMany("EmpresaSolucao")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OChamado.API.Models.Solucao", "Solucao")
                        .WithMany("EmpresaSolucao")
                        .HasForeignKey("SolucaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OChamado.API.Models.Responsavel", b =>
                {
                    b.HasOne("OChamado.API.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
