using System;
using System.Collections.Generic;

namespace SignosVitalesAPI.Core.Entities
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public int PresionArterial { get; set; }
        public int Respiracion { get; set; }
        public int Pulso { get; set; }
        public float Temperatura { get; set; }
    }
}
