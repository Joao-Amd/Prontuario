using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Anamneses;
using Prontuario.Dominio.Pacientes;
using System.Reflection.Emit;

namespace Prontuario.Repositorio.Et
{
    public class AnamneseConfig : IEntityTypeConfiguration<Anamnese>
    {
        public void Configure(EntityTypeBuilder<Anamnese> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).HasMaxLength(200);

            builder.HasOne(x => x.Paciente)
                .WithOne(p => p.Anamnese)
                .HasForeignKey<Anamnese>(x => x.CodigoPaciente);
        }
    }
}
