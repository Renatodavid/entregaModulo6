
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
            builder.Property(x => x.Valor).IsRequired().HasMaxLength(20);
            builder.Property(x => x.DataChegada).IsRequired().HasMaxLength(10);  
            builder.Property(x => x.DataSaida).IsRequired().HasMaxLength(10);
            builder.Property(x => x.HoraChegada).IsRequired().HasMaxLength(10);
         

        
        }
              
    }
}
