using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Anamneses
{
    public class Anamnese
    {
        public Anamnese(){}
        public Anamnese(Paciente paciente, string descricao)
        {
            Id = Guid.NewGuid();
            CodigoPaciente = paciente.Id;
            Paciente = paciente;
            Descricao = descricao;
        }

        public Guid Id { get; private set; }
        public Guid CodigoPaciente { get; private set; }
        public string Descricao { get; private set; }
        //
        public virtual Paciente Paciente { get; private set; }
        public ICollection<AnamneseTipoDetalhe> TipoDetalhe { get; private set; }

        public static Anamnese Novo(Paciente paciente, string descricao)
        {
            return new Anamnese(paciente, descricao);
        }
    }
}
