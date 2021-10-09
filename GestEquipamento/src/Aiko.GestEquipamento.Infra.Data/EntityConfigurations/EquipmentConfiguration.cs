using Aiko.GestEquipamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aiko.GestEquipamento.Infra.Data.EntityConfigurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.ToTable("equipment");            

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name");

            builder.Property(e => e.EquipmentModelId)
                .HasColumnName("equipment_model_id");


            // builder
            //     .HasMany(e => e.EquipmentStateHistories)
            //     .WithOne()
            //     .HasForeignKey(e => e.EquipmentId)
            //     .OnDelete(DeleteBehavior.Restrict);
        }
    }
}