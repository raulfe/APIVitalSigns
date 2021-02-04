using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignosVitalesAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignosVitalesAPI.Infrastructure.Data.Configuration
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(e => e.IdPaciente)
                    .HasName("PRIMARY");

            builder.ToTable("paciente");

            builder.Property(e => e.IdPaciente).HasColumnName("Id_paciente");

            builder.Property(e => e.NombrePaciente)
                .IsRequired()
                .HasColumnName("Nombre_paciente")
                .HasMaxLength(50);

            builder.Property(e => e.PresionArterial).HasColumnName("Presion_arterial");
        }
    }
}
