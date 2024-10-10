using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Anamneses;

namespace Prontuario.Repositorio.Et
{
    public class AnamneseTipoDetalheConfig : IEntityTypeConfiguration<AnamneseTipoDetalhe>
    {
        public void Configure(EntityTypeBuilder<AnamneseTipoDetalhe> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
