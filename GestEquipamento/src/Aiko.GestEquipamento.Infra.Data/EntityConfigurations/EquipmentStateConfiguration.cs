using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentStateConfiguration : IEntityTypeConfiguration<EquipmentState>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<EquipmentState> builder)
        {
            builder.ToTable("equipment_state");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name");

            builder.Property(e => e.Color)
                .HasColumnName("color");

            builder.Ignore(c => c.EquipmentStateHistories)
                    .Ignore(c => c.EquipmentModelStateHourlyEarnings);  
        }
    }
}