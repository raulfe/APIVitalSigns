using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignosVitalesAPI.Core.Entities;
using SignosVitalesAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignosVitalesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        public PacienteController(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }
        /// <summary>
        /// Método especifico para obtención Pacientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPacientes()
        {
            var pacientes = await _pacienteRepositorio.GetPacientes();
            return Ok(pacientes);
        }

        /// <summary>
        /// Método especifico para obtención Pacientes por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPacientes(int id)
        {
            var paciente = await _pacienteRepositorio.GetPaciente(id);
            return Ok(paciente);
        }

        /// <summary>
        /// Método especifico para añadir Pacientes
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> InserPaciente(Paciente pat)
        {
            var paciente = _pacienteRepositorio.InsertPaciente(pat);
            return Ok(paciente);
        }

        /// <summary>
        /// Método especifico para actualización de variables fisiologicas por Paciente
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdatePaciente(Paciente pat)
        {
            var result = _pacienteRepositorio.UpdatePaciente(pat);
            return Ok(result);
        }

        /// <summary>
        /// Método especifico para remover un Paciente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaciente(int id)
        {
            var result = _pacienteRepositorio.DeletePaciente(id);
            return Ok(result);
        }
    }
}
