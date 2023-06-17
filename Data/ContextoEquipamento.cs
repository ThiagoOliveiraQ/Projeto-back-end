using calculodeequipamentos.Context;
using calculodeequipamentos.Models;
using Microsoft.EntityFrameworkCore;

namespace calculodeequipamentos.Data
{
    public class ContextoEquipamento : DbContext
    {
        public ContextoEquipamento(DbContextOptions<ContextoEquipamento> options) : base(options)
        {
        }

        public DbSet<EquipamentoEletronico> Equipamentos { get; set; }

        public static implicit operator ContextoEquipamento(AppDbContext v)
        {
            throw new NotImplementedException();
        }
    }

}