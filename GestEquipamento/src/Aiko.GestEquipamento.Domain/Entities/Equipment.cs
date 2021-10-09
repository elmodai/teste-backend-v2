
using System;
using System.Collections.Generic;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class Equipment : ABaseEntity<Guid>
    {
        public string Name { get; set; }

        public Guid EquipmentModelId { get; set; }

        public EquipmentModel EquipmentModel { get; set; }

        // public IEnumerable<EquipmentStateHistory> EquipmentStateHistories { get; set; }

        // public IEnumerable<EquipmentPositionHistory> EquipmentPositionHistories { get; set; }
    }
}