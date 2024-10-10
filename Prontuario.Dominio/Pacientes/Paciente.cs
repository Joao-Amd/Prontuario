using Prontuario.Dominio.Anamneses;
using Prontuario.Dominio.Avaliacoes;
using Prontuario.Dominio.Baixas;
using Prontuario.Dominio.Enderecos;
using Prontuario.Dominio.Oportunidades;
using Prontuario.Dominio.Pacientes.Enumeradores;
using Prontuario.Dominio.Receitas;

namespace Prontuario.Dominio.Pacientes
{
    public class Paciente
    {
        public Paciente() { }

        public Paciente(string nome, string nomePai, string nomeMae, string cpf, DateTime dataNascimento,
            EnumGeneroPaciente generoPaciente, string numeroCelular, string email, EnumGrupoSanguineoPaciente grupoSanguineo, string obs)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            NomeMae = nomeMae;
            NomePai = nomePai;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Genero = generoPaciente;
            NumeroCelular = numeroCelular;
            Email = email;
            GrupoSanguineo = grupoSanguineo;
            DataCadastro = DateTime.Now;
            Observacoes = obs;
            Anamnese.Novo(this, $"Anamnese paciênte: {Nome}");
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string NomeMae { get; private set; }
        public string NomePai { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public EnumGeneroPaciente Genero { get; private set; }
        public string NumeroCelular { get; private set; }
        public string Email { get; private set; }
        public EnumGrupoSanguineoPaciente GrupoSanguineo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Observacoes { get; private set; }

        //

        public virtual Endereco Endereco { get; private set; }
        public virtual Anamnese Anamnese { get; private set; }
        public virtual ICollection<Avaliacao> Avaliacao { get; private set; }
        public virtual ICollection<Baixa> Baixa { get; private set; }
        public virtual ICollection<Oportunidade> Oportunidade { get; private set; }
        public virtual ICollection<Receita> Receita { get; private set; }

        public static Paciente Novo(string nome, string nomePai, string nomeMae, string cpf, DateTime dataNascimento,
            EnumGeneroPaciente generoPaciente, string numeroCelular, string email, EnumGrupoSanguineoPaciente grupoSanguineo, string obs)
        {
            return new Paciente(nome, nomePai, nomeMae, cpf, dataNascimento, generoPaciente, numeroCelular, email, grupoSanguineo, obs);
        }

        public void Atualizar(string nome, string nomePai, string nomeMae, string cpf, DateTime dataNascimento,
            EnumGeneroPaciente generoPaciente, string numeroCelular, string email, EnumGrupoSanguineoPaciente grupoSanguineo, string obs)
        {
            Nome = nome;
            NomeMae = nomeMae;
            NomePai = nomePai;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Genero = generoPaciente;
            NumeroCelular = numeroCelular;
            Email = email;
            GrupoSanguineo = grupoSanguineo;
            DataCadastro = DateTime.Now;
            Observacoes = obs;
        }
    }
}
