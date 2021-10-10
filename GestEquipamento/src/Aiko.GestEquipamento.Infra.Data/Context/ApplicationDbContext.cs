using Aiko.GestEquipamento.Domain.Entities;
using Aiko.GestEquipamento.Infra.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Aiko.GestEquipamento.Infra.Data.Context
{
    public class AppContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder
                .UseNpgsql("Server=127.0.0.1;Database=operation;Username=postgres;Password=Udtqcss8");            

            return new ApplicationDbContext(optionsBuilder.Options);
        }        
    }

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentModel> PosEquipmentModels { get; set; }

        public DbSet<EquipmentModel> EquipmentModels { get; set; }

        public DbSet<EquipmentModelStateHourlyEarnings> EquipmentModelStateHourlyEarnings { get; set; }

        public DbSet<EquipmentPositionHistory> EquipmentPositionHistories { get; set; }

        public DbSet<EquipmentStateHistory> EquipmentStateHistories { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("operation");       

            builder.ApplyConfiguration(new EquipmentConfiguration());

            builder.ApplyConfiguration(new EquipmentModelConfiguration());

            builder.ApplyConfiguration(new EquipmentStateConfiguration());

            builder.ApplyConfiguration(new EquipmentModelStateHourlyEarningsConfiguration());

            builder.ApplyConfiguration(new EquipmentStateHistoryConfiguration());

            builder.ApplyConfiguration(new EquipmentPositionHistoryConfiguration());          

            base.OnModelCreating(builder);


        }
        
    }
}
