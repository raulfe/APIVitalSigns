using Microsoft.EntityFrameworkCore;
using SignosVitalesAPI.Core.Entities;
using SignosVitalesAPI.Core.Interfaces;
using SignosVitalesAPI.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignosVitalesAPI.Infrastructure.Repositories
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly signosvitalesContext _context;

        public PacienteRepositorio(signosvitalesContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            var pacientes = await _context.Paciente.ToListAsync();
            return pacientes;
        }

        public async Task<Paciente> GetPaciente(int id )
        {
            var paciente = await _context.Paciente.FirstOrDefaultAsync(x=>x.IdPaciente == id);
            return paciente;
        }

        public async Task InsertPaciente(Paciente paciente)
        {
            _context.Paciente.Add(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePaciente(Paciente paciente)
        {
            var data = await GetPaciente(paciente.IdPaciente);
            data.IdPaciente = paciente.IdPaciente;
            data.NombrePaciente = paciente.NombrePaciente;
            data.PresionArterial = paciente.PresionArterial;
            data.Pulso = paciente.Pulso;
            data.Respiracion = paciente.Respiracion;
            data.Temperatura = paciente.Temperatura;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
            
        }

        public async Task<bool> DeletePaciente(int id)
        {
            var data = await GetPaciente(id);
            _context.Paciente.Remove(data);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
