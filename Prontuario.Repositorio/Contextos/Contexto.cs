using Microsoft.EntityFrameworkCore;
using Prontuario.Dominio.Anamneses;
using Prontuario.Dominio.Avaliacoes;
using Prontuario.Dominio.Baixas;
using Prontuario.Dominio.Enderecos;
using Prontuario.Dominio.Oportunidades;
using Prontuario.Dominio.Pacientes;
using Prontuario.Dominio.Receitas;

namespace Prontuario.Repositorio.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options){ }

        public virtual DbSet<Anamnese> Anamnese { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Baixa> Baixa { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Oportunidade> Oportunidade { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Receita> Receita { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);
        }
    }
}
