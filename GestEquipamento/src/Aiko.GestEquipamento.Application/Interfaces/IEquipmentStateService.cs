using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentStateService
    {
        Task<IEnumerable<EquipmentState>> GetAll();  
        Task<EquipmentState> Get(Guid Id);  
        void Insert(CreateEquipmentStateDTO dto);  
        void Update(EquipmentState entity);  
        void Delete(EquipmentState entity);           
         
    }
}