using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentStateHistory : ABaseEntity<Guid>
    {
        public Guid EquipmentStateId { get; set; }

        public EquipmentState EquipmentState { get; set; }

        public Guid EquipmentId { get; set; }

        public Equipment Equipment { get; set; }

        public DateTime Date { get; set; }

    }
}