using Microsoft.EntityFrameworkCore;
using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API
{

    public class ChamadoContext  : DbContext 
    {
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Solucao> Solucao { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public ChamadoContext(DbContextOptions<ChamadoContext> options) : base(options){ }
        public ChamadoContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chamado;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios")
                .HasKey(u => u.Id);

            modelBuilder.Entity<Responsavel>()
                .ToTable("Responsavel")
                .HasKey(r => r.Id);
            
            modelBuilder.Entity<Solucao>()
                .ToTable("Solucao")
                .HasKey(s => s.Id);

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .HasKey(c => new { c.Id});

            modelBuilder.Entity<Atendimento>()
                .ToTable("Atendimento")
                .HasKey(a => a.Id);

        }
    }
}
