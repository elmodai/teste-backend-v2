using System;
namespace Aiko.GestEquipamento.Application.DTOs
{
    public record CreateEquipmentDTO(string Name, string EquipmentModelId);

    public record CreateEquipmentModelDTO(string Name);

    public record CreateEquipmentStateDTO(string Name, string Color);

    public record EquipmentDTO(string Name, Guid EquipmentModelId);

    public record EquipmentModelStateHourlyEarningsDTO(float Value, Guid EquipmentModelId, Guid EquipmentStateId);

    public record EquipmentStateDTO(string Name, string Color);
}
