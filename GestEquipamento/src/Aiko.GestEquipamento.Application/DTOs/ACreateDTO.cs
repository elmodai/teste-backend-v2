using System;

namespace Aiko.GestEquipamento.Application.DTOs
{
    public abstract record ACreateDTO
    {
        public Guid Id { get; init; }
        
    }
}