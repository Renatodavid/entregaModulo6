
using entrega_modulo6.Data;
using entrega_modulo6.Repositorys;
using entrega_modulo6.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


namespace entrega_modulo_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions
                        .ReferenceHandler = ReferenceHandler.IgnoreCycles);


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
             .AddDbContext<entrega_modulo6DBContext>(
                 Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
    );

            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<ICompraRepository, CompraRepository>();
            builder.Services.AddScoped<IDestinoRepository, DestinoRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }



    }
}
