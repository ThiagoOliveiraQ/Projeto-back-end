using calculodeequipamentos.Models;
using Microsoft.EntityFrameworkCore;


namespace calculodeequipamentos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EquipamentoEletronico> Equipamentos { get; set; }

    }
}
  