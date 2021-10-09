using System;
using System.Collections.Generic;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentState : DeletableEntity<Guid>
    {
        public string Name { get; set; }

        public string Color { get; set; }

        // public IEnumerable<EquipmentModelStateHourlyEarnings> EquipmentModelStateHourlyEarnings { get; set; }

        // public IEnumerable<EquipmentPositionHistory> EquipmentPositionHistories { get; set; }

    }
}