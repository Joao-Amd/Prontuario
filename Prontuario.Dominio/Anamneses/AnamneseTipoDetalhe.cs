using Prontuario.Dominio.Pacientes;

namespace Prontuario.Dominio.Anamneses
{
    public class AnamneseTipoDetalhe
    {
        public AnamneseTipoDetalhe() { }

        public AnamneseTipoDetalhe(Guid codigoAnamnese, string nome, bool possui, string? descricao)
        {
            Id = Guid.NewGuid();
            CodigoAnamnese = codigoAnamnese;
            Nome = nome;
            PossuiDoenca = possui;
            Descricao = descricao;
        }
        public Guid Id { get; private set; }
        public Guid CodigoAnamnese { get; private set; }
        public string Nome { get; private set; }
        public bool PossuiDoenca { get; private set; }
        public string? Descricao { get; private set; }
        public bool Ativo { get; private set; }

        public static AnamneseTipoDetalhe Novo(Guid codigoAnamnese, string nome, bool possui, string? descricao)
        {
            return new AnamneseTipoDetalhe(codigoAnamnese, nome, possui, descricao);
        }

        public void Atualizar(string nome, bool possui, string? descricao)
        {
            Nome = nome;
            PossuiDoenca = possui;
            Descricao = descricao;
        }
    }
}
