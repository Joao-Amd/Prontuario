using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Avaliacoes
{
    public class Avaliacao
    {
        public Avaliacao(Paciente paciente, string descricao) 
        { 
            Id = Guid.NewGuid();
            CodigoPaciente = paciente.Id;
            Paciente = paciente;
            Descricao =  descricao;
            DataHora = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; private set; }

        public string Descricao { get; private set; }
        public DateTime DataHora { get; private set; }
        //
        public virtual Paciente Paciente { get; private set; }

        public static Avaliacao Novo(Paciente paciente, string descricao)
        {
            return new Avaliacao(paciente, descricao);
        }
    }
}
