using System;

namespace Aiko.GestEquipamento.Application.DTOs
{
    public record EquipmentModelStateHourlyEarningsDTO
    {
        public float Value { get; set; }

        public Guid EquipmentModelId { get; set; }

        public Guid EquipmentStateId { get; set; }
    }
}