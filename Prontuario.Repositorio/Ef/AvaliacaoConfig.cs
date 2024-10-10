using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Anamneses;
using Prontuario.Dominio.Avaliacoes;

namespace Prontuario.Repositorio.Et
{
    public class AvaliacaoConfig : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasOne(x => x.Paciente)
                   .WithMany(p => p.Avaliacao)
                   .HasForeignKey(x => x.CodigoPaciente);
        }
    }
}
