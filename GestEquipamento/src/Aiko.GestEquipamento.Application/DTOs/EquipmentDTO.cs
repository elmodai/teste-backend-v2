using System;
namespace Aiko.GestEquipamento.Application.DTOs
{
    public record EquipmentDTO
    {
        public string Name { get; set; }

        public Guid EquipmentModelId { get; set; }

    }
}
