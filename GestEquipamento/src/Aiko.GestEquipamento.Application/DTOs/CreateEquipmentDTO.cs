using System;

namespace Aiko.GestEquipamento.Application.DTOs
{
    public record CreateEquipmentDTO
    {
        public string Name { get; set; }

        public string EquipmentModelId { get; set; }
        
    }
}