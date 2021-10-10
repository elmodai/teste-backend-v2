namespace Aiko.GestEquipamento.Application.DTOs
{
    public record CreateEquipmentModelDTO : ACreateDTO
    {
        public string Name { get; set; }        
    }
}