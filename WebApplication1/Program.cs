using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            //Builders do swagger(adicionar sempre antes do builder.build)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Builders do banco de dados
            var conexionString = builder.Configuration.GetConnectionString("ConexaoBancoDados");

            builder.Services.AddDbContext<Data.AppDbContext>(options =>
            {
                options.UseMySql(conexionString, ServerVersion.AutoDetect(conexionString));
            });

            //-----------------------------------------------------------------
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
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
