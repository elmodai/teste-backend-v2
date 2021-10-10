using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentStateHistoryService
    {
        Task<IEnumerable<EquipmentStateHistory>> GetAll();  
        Task<EquipmentStateHistory> Get(Guid Id);  
        void Insert(EquipmentStateHistory entity);  
        void Update(EquipmentStateHistory entity);  
        void Delete(EquipmentStateHistory entity);           
         
    }
}