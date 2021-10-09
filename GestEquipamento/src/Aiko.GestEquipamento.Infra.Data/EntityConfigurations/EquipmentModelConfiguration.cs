using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentModelConfiguration : IEntityTypeConfiguration<EquipmentModel>
    {
        public void Configure(EntityTypeBuilder<EquipmentModel> builder)
        {
            builder
                .ToTable("equipment_model");

            builder
                .Property(e => e.Id)
                .HasColumnName("id");

            builder
                .Property(e => e.Name)
                .HasColumnName("name");

            builder
                .HasMany(e => e.Equipments)
                .WithOne(e => e.EquipmentModel);

            builder
                .Ignore(e => e.EquipmentModelStateHourlyEarnings);

        }
    }
}