
using entrega_modulo6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entrega_modulo6.Data.Map
{
    public class CompraMap : IEntityTypeConfiguration<CompraModel>

    {
        public void Configure(EntityTypeBuilder<CompraModel> builder)
        {
            builder.ToTable("compra");
            builder.Property(x => x.CompraId);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(128);
            builder.Property(x => x.ValorCompra).IsRequired();


              
           
                   
        }

    }
}
