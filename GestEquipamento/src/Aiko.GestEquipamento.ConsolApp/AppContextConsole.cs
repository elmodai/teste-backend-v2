using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiko.GestEquipamento.ConsolApp
{
    public class AppContextConsole : DbContext
    {

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentModel> EquipmentModels { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder
                .UseNpgsql("Server=127.0.0.1;Database=Koperation;Username=postgres;Password=Udtqcss8");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            
        }

    }
}