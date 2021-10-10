using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Domain.Entities;


namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentPositionHistoryService
    {
        Task<IEnumerable<EquipmentPositionHistory>> GetAll();  
        Task<EquipmentPositionHistory> Get(Guid Id);  
        void Insert(EquipmentPositionHistory entity);  
        void Update(EquipmentPositionHistory entity);  
        void Delete(EquipmentPositionHistory entity);           
         
    }
}