using System;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentPositionHistory
    {
        public float Lat { get; set; }

        public float Lon { get; set; }

        public Guid EquipmentId { get; set; }

        public Equipment Equipment { get; set; }
        
        public DateTime Date { get; set; }
    }
}