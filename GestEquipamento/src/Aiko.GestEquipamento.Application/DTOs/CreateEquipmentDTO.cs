using System;

namespace Aiko.GestEquipamento.Application.DTOs
{
    public class CreateEquipmentDTO : ACreateDTO
    {
        public string Name { get; set; }

        public Guid EquipmentModelId { get; set; }
        
    }
}