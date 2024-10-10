using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Avaliacoes;
using Prontuario.Dominio.Baixas;

namespace Prontuario.Repositorio.Et
{
    public class BaixaConfig : IEntityTypeConfiguration<Baixa>
    {
        public void Configure(EntityTypeBuilder<Baixa> builder)
        {
            builder.HasOne(x => x.Paciente)
                   .WithMany(p => p.Baixa)
                   .HasForeignKey(x => x.CodigoPaciente);
        }
    }
}
