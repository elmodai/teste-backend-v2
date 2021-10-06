using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentModelStateHourlyEarnings : DeletableEntity<Guid>
    {
        public int Value { get; set; }

        public int EquipmentModelId { get; set; }

        public EquipmentModel EquipmentModel { get; set; }

        public int EquipmentStateId { get; set; }

        public EquipmentState EquipmentState { get; set; }
    }
}