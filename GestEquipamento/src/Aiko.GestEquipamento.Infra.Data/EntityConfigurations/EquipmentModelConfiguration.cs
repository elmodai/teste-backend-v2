using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentModelConfiguration : IEntityTypeConfiguration<EquipmentModel>
    {
        public void Configure(EntityTypeBuilder<EquipmentModel> builder)
        {
            builder.ToTable("equipment_model");

            // builder
            // .HasMany(e => e.Equipments)
            // .WithOne()
            // .HasForeignKey(e => e.EquipmentModelId)
            // .OnDelete(DeleteBehavior.Restrict);

            // builder.HasMany(e => e.EquipmentModelStateHourlyEarnings)
            // .WithOne()
            // .HasForeignKey(e => e.EquipmentModelId)
            // .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name");

            builder.Ignore(e => e.EquipmentModelStateHourlyEarnings);

        }
    }
}