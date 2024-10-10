using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Baixas;
using Prontuario.Dominio.Receitas;

namespace Prontuario.Repositorio.Et
{
    public class ReceitaConfig : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.HasOne(x => x.Paciente)
                               .WithMany(p => p.Receita)
                               .HasForeignKey(x => x.CodigoPaciente);
        }
    }
}
