namespace Aiko.GestEquipamento.Application.DTOs
{
    public record CreateEquipmentStateDTO : ACreateDTO
    {
        public string Name { get; set; }

        public string Color { get; set; }
        
    }
}