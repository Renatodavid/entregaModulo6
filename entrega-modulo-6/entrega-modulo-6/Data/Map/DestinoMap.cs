
using entrega_modulo6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace entrega_modulo6.Data.Map
{
    public class DestinoMap : IEntityTypeConfiguration<DestinoModel>
    {
        public void Configure(EntityTypeBuilder<DestinoModel> builder)
        {
            builder.ToTable("destino");
            builder.HasKey(x => x.DestinoId);
            builder.Property(x => x.NomeDestino).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.DataChegada).IsRequired(); 
            builder.Property(x => x.DataSaida).IsRequired(); 
            builder.Property(x => x.HoraChegada).IsRequired(); 
            builder.Property(x => x.Status).IsRequired(); 

            builder
                .HasOne(x => x.Usuarios)
                .WithMany(y => y.Destinos)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict); 

             builder
                .HasMany(x => x.Compras)
                .WithOne(y => y.Destino)
                .OnDelete(DeleteBehavior.Restrict);
        }
              
    }
}
