using Prontuario.Dominio.Pacientes.Enumeradores;

namespace Prontuario.Aplicacao.Pacientes.Dtos
{
    public class PacienteDto
    {
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumGeneroPaciente Genero { get; set; }
        public string NumeroCelular { get; set; }
        public string Email { get; set; }
        public EnumGrupoSanguineoPaciente GrupoSanguineo { get; set; }
        public string Observacoes { get; set; }
    }
}
