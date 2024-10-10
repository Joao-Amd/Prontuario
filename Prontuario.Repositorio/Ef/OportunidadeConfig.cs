using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Oportunidades;

namespace Prontuario.Repositorio.Et
{
    public class OportunidadeConfig : IEntityTypeConfiguration<Oportunidade>
    {
        public void Configure(EntityTypeBuilder<Oportunidade> builder)
        {
            builder.HasOne(x => x.Paciente)
                   .WithMany(p => p.Oportunidade)
                   .HasForeignKey(x => x.CodigoPaciente);
        }
    }
}
