using SignosVitalesAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignosVitalesAPI.Core.Interfaces
{
    public interface IPacienteRepositorio
    {
        Task<IEnumerable<Paciente>> GetPacientes();
        Task<Paciente> GetPaciente(int id);
        Task InsertPaciente(Paciente paciente);
        Task<bool> UpdatePaciente(Paciente paciente);
        Task<bool> DeletePaciente(int id);
    }
}
