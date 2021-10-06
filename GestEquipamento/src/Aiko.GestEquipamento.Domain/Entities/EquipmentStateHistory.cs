using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentStateHistory : AuditableEntity<Guid>
    {
        public int EquipmentStateId { get; set; }

        public EquipmentState EquipmentState { get; set; }

        public int EquipmentId { get; set; }

        public Equipment Equipment { get; set; }

    }
}