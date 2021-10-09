using System;
using System.Collections.Generic;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Entities
{
    public class EquipmentModel : DeletableEntity<Guid>
    {
        public string Name { get; set; }     

        // public IEnumerable<EquipmentModelStateHourlyEarnings> EquipmentModelStateHourlyEarnings { get; set; }

        // public IEnumerable<Equipment> Equipments { get; set; }


    }
}