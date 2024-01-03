
using entrega_modulo6.Data.Map;
using entrega_modulo6.Models;
using Microsoft.EntityFrameworkCore;



namespace entrega_modulo6.Data

{

    public class entrega_modulo6DBContext : DbContext

    {

        public entrega_modulo6DBContext(DbContextOptions<entrega_modulo6DBContext> options)

            : base(options)

        {

        }

        public DbSet<UsuarioModel> Usuario { get; set; } = null!;

        public DbSet<DestinoModel> Destino { get; set; } = null!;

        public DbSet<CompraModel> Compra { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.ApplyConfiguration(new UsuarioMap());

            modelBuilder.ApplyConfiguration(new DestinoMap());

            modelBuilder.ApplyConfiguration(new CompraMap());




            base.OnModelCreating(modelBuilder);

        }

    }

}