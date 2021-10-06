using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentPositionHistory : AuditableEntity<Guid>
    {
        public double Lat { get; set; }

        public double Lon { get; set; }

        public int EquipmentId { get; set; }

        public Equipment Equipment { get; set; }
    }
}