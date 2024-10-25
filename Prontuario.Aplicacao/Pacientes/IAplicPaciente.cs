using Prontuario.Aplicacao.Pacientes.Dtos;
using Prontuario.Aplicacao.Pacientes.ViewModels;

namespace Prontuario.Aplicacao.Pacientes
{
    public interface IAplicPaciente
    {
        PacienteViewModel RecuperarPorId(Guid id);
        List<PacienteViewModel> RecuperarTodos();
        PacienteViewModel Inserir(PacienteDto dto);
        void Remover(Guid id);
    }
}
