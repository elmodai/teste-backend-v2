using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentPositionHistoryConfiguration : IEntityTypeConfiguration<EquipmentPositionHistory>
    {
        public void Configure(EntityTypeBuilder<EquipmentPositionHistory> builder)
        {
            builder.ToTable("equipment_position_history");

            builder.HasNoKey();

            builder.Property(e => e.EquipmentId)
                .HasColumnName("equipment_id");            

            builder.Property(e => e.Lon)
                .HasColumnName("lon");

            builder.Property(e => e.Lat)
                .HasColumnName("lat");

            builder.Property(e => e.Date)
                .HasColumnType("date")            
                .HasColumnName("date");            
        }
    }
}