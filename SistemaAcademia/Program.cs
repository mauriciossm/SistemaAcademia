using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Data;
using SistemaAcademia.Repositorio;
using SistemaAcademia.Repositorio.Interfaces;

namespace SistemaAcademia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BancoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();


            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}