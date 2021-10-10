using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetAll();  
        Task<Equipment> Get(Guid Id);  
        void Insert(CreateEquipmentDTO dto);  
        void Update(Equipment entity);  
        void Delete(Equipment entity);           
    }
}