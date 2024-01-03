
using entrega_modulo6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entrega_modulo6.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {

            builder.HasKey(x => x.UsuarioId);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(228);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(228);
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(18);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(228);
            builder.Property(x => x.Genero).IsRequired().HasMaxLength(128);

          

        }
    }
}
