using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Infra.IoC
{
    public static class Extensions
    {
        public static EquipmentStateDTO AsEquipmentStateDTO(this EquipmentState es)
        {
            return new EquipmentStateDTO(es.Name, es.Color);
        }

    }
}