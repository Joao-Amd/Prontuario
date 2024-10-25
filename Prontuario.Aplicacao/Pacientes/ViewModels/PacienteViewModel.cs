using Prontuario.Dominio.Pacientes;
using Prontuario.Dominio.Pacientes.Enumeradores;

namespace Prontuario.Aplicacao.Pacientes.ViewModels
{
    public class PacienteViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumGeneroPaciente Genero { get; set; }
        public string NumeroCelular { get; set; }
        public string Email { get; set; }
        public EnumGrupoSanguineoPaciente GrupoSanguineo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacoes { get; set; }

        public static PacienteViewModel Novo(Paciente paciente)
        {
            return new PacienteViewModel
            {
                Id = paciente.Id,
                Nome = paciente.Nome,
                NomeMae = paciente.NomeMae,
                NomePai = paciente.NomePai,
                Cpf = paciente.Cpf,
                DataNascimento = paciente.DataNascimento,
                Genero = paciente.Genero,
                NumeroCelular = paciente.NumeroCelular,
                Email = paciente.Email,
                GrupoSanguineo = paciente.GrupoSanguineo,
                DataCadastro = paciente.DataCadastro,
                Observacoes = paciente.Observacoes
            };
        }

    }
}
