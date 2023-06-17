
using calculodeequipamentos.Context;
using calculodeequipamentos.Repositorio;
using Microsoft.EntityFrameworkCore;



#nullable disable

namespace calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string mySqlConnection =
                    builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer
                ("Data Source=DESKTOP-GFK2EGS\\;Initial Catalog=EquipamentosCadastrados; Integrated Security=True; Encrypt=False"));
            builder.Services.AddScoped<IEquipamentoRepositorio, EquipamentoRepositorio>();


            builder.Services.AddControllersWithViews();



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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
