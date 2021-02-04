using System;
using System.Collections.Generic;
using System.Text;

namespace SignosVitalesAPI.Core.DTOs
{
    public class PacienteDTO
    {
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public int PresionArterial { get; set; }
        public int Respiracion { get; set; }
        public int Pulso { get; set; }
        public float Temperatura { get; set; }
    }
}
