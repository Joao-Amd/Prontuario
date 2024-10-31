using Microsoft.AspNetCore.Mvc;
using Prontuario.Aplicacao.Pacientes;
using Prontuario.Aplicacao.Pacientes.Dtos;

namespace Prontuario.Api.Controllers
{
    [Route("Paciente")]
    public class PacienteController : Controller
    {

        private readonly IAplicPaciente _aplicPaciente;
        public PacienteController(IAplicPaciente aplicPaciente)
        {
            _aplicPaciente = aplicPaciente;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarPorId([FromRoute] Guid id)
        {
            try
            {
                var paciente = _aplicPaciente.RecuperarPorId(id);

                return Ok(paciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult RecuperarTodos()
        {
            try
            {
                var paciente = _aplicPaciente.RecuperarTodos();

                return Ok(paciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Inserir([FromBody] PacienteDto dto)
        {
            try
            {
                var paciente = _aplicPaciente.Inserir(dto);

                return Ok(paciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar([FromRoute] Guid id, [FromBody] PacienteDto dto)
        {
            try
            {
                var paciente = _aplicPaciente.Alterar(id, dto);

                return Ok(paciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remover([FromRoute] Guid id)
        {
            try
            {
                _aplicPaciente.Remover(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
