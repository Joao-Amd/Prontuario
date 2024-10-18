using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Receitas
{
    public class Receita
    {
        public Receita(Paciente paciente, string descricao) 
        { 
            Id = Guid.NewGuid();
            CodigoPaciente = paciente.Id;
            Paciente = paciente;
            Descricao = descricao;
            DataHora = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        //
        public virtual Paciente Paciente { get; private set; }

    }
}
