using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentModelStateHourlyEarnings
    {
        public int Value { get; set; }

        public Guid EquipmentModelId { get; set; }

        public EquipmentModel EquipmentModel { get; set; }

        public Guid EquipmentStateId { get; set; }

        public EquipmentState EquipmentState { get; set; }
    }
}