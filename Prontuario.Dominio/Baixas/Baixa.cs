using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Baixas
{
    public class Baixa
    {
        public Baixa() { }

        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataHora { get; private set; }
        //
        public virtual Paciente Paciente { get; private set; }

    }
}
