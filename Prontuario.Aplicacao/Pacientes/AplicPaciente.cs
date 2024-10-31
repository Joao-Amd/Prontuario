using Prontuario.Aplicacao.Pacientes.Dtos;
using Prontuario.Aplicacao.Pacientes.ViewModels;
using Prontuario.Dominio.Pacientes;
using Prontuario.Dominio.Pacientes.Enumeradores;
using Prontuario.Repositorio.RepPatterns;
using Prontuario.Repositorio.UnitOfWorks;

namespace Prontuario.Aplicacao.Pacientes
{
    public class AplicPaciente : IAplicPaciente
    {
        private readonly IRep<Paciente> _repPaciente;
        private readonly  IUnitOfWork _unitOfWork;
        public AplicPaciente(IRep<Paciente> repPaciente, IUnitOfWork unitOfWork)
        {
            _repPaciente = repPaciente;
            _unitOfWork = unitOfWork;
        }

        public PacienteViewModel Inserir(PacienteDto dto)
        {
            var paciente = Paciente.Novo(dto.Nome, dto.NomePai, dto.NomeMae, dto.cpf, dto.DataNascimento, dto.Genero, dto.NumeroCelular, dto.Email, dto.GrupoSanguineo, dto.Observacoes);

            _repPaciente.Inserir(paciente);

            _unitOfWork.Commit();

            return PacienteViewModel.Novo(paciente);
        }

        public PacienteViewModel Alterar(Guid id, PacienteDto dto)
        {
            var paciente = _repPaciente.GetById(id);

            paciente.Atualizar(dto.Nome, dto.NomePai, dto.NomeMae, dto.cpf, dto.DataNascimento, dto.Genero, dto.NumeroCelular, dto.Email, dto.GrupoSanguineo, dto.Observacoes);

            _unitOfWork.Commit();

            return PacienteViewModel.Novo(paciente);
        }


        public PacienteViewModel RecuperarPorId(Guid id)
        {
            var paciente = _repPaciente.GetById(id);

            return PacienteViewModel.Novo(paciente);
        }

        public List<PacienteViewModel> RecuperarTodos()
        {
           var pacientes = _repPaciente.Get();

            return pacientes.Select(x => PacienteViewModel.Novo(x)).ToList();
        }

        public void Remover(Guid id)
        {
            _repPaciente.Delete(id);

            _unitOfWork.Commit();
        }
    }
}
