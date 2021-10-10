using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentStateHistoryConfiguration : IEntityTypeConfiguration<EquipmentStateHistory>
    {
        public void Configure(EntityTypeBuilder<EquipmentStateHistory> builder)
        {
            builder
                .ToTable("equipment_state_history");

            builder
                .HasNoKey();

            builder
                .Property(e => e.EquipmentStateId)
                .HasColumnName("equipment_state_id");

            builder
                .Property(e => e.EquipmentId)
                .HasColumnName("equipment_id");

            builder
                .Property(e => e.Date)
                .HasColumnName("date");
            builder
                .HasOne(e => e.Equipment)
                .WithMany();     

            builder
                .Ignore(e => e.Id);

        }
    }
}