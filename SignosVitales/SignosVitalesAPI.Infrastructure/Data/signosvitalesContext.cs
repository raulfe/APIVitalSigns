using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SignosVitalesAPI.Core.Entities;
using SignosVitalesAPI.Infrastructure.Data.Configuration;

namespace SignosVitalesAPI.Infrastructure.Data
{
    public partial class signosvitalesContext : DbContext
    {
        public signosvitalesContext()
        {
        }

        public signosvitalesContext(DbContextOptions<signosvitalesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Paciente> Paciente { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
        }

    }
}
