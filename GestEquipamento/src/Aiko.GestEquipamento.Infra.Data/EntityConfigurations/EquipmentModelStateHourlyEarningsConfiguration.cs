using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentModelStateHourlyEarningsConfiguration 
        : IEntityTypeConfiguration<EquipmentModelStateHourlyEarnings>
    {
        public void Configure(EntityTypeBuilder<EquipmentModelStateHourlyEarnings> builder)
        {
            builder
                .ToTable("equipment_model_state_hourly_earnings");

            builder
                .HasOne(e => e.EquipmentModel)
                .WithMany();
                
            builder
                .HasNoKey();

            builder
                .Property(e => e.Value)
                .HasColumnName("value");

            builder
                .Property(e => e.EquipmentModelId)
                .HasColumnName("equipment_model_id");

            builder
                .Property(e => e.EquipmentStateId)
                .HasColumnName("equipment_state_id");

            builder
                .Ignore(e => e.Id);
        }
    }
}