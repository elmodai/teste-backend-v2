using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Infra.IoC
{
    public static class Extensions
    {
        public static EquipmentDTO AsEquipmentDTO(this Equipment e)
        {
            return new EquipmentDTO
            {              
                Name = e.Name,
                EquipmentModelId = e.EquipmentModelId
            };
        }

    }
}