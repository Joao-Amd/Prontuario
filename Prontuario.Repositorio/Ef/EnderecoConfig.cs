using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prontuario.Dominio.Enderecos;

namespace Prontuario.Repositorio.Et
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasOne(x => x.Paciente)
                 .WithOne(p => p.Endereco)
                 .HasForeignKey<Endereco>(x => x.CodigoPaciente);
        }
    }
}
