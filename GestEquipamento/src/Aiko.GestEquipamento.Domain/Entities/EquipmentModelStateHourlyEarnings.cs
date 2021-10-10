using System;
using System.ComponentModel.DataAnnotations.Schema;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentModelStateHourlyEarnings : ABaseEntity<Guid>
    {
        public float Value { get; set; }

        public Guid EquipmentModelId { get; set; }

        public EquipmentModel EquipmentModel { get; set; }

        public Guid EquipmentStateId { get; set; }

        public EquipmentState EquipmentState { get; set; }
    }
}