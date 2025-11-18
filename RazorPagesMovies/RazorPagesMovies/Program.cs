using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;
namespace RazorPagesMovies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RazorPagesMoviesContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMoviesContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMoviesContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            } //Mapeia as exce��es

            app.UseHttpsRedirection(); //Direciona solicita��es http para https
            app.UseStaticFiles();//Permite arquivos est�ticos sejam atendidos no nosso app Ex: css, js

            app.UseRouting();//Adiciona rotas no middleware

            app.UseAuthorization();//Autoriza usu�rio a acessar recursos seguros

            app.MapRazorPages();//Configura roteamento de p�ginas razor

            app.Run();//Executa
        }
    }
}
