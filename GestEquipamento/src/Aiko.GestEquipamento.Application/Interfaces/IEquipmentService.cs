using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetAll();  
        Task<Equipment> Get(Guid Id);  
        void Insert(Equipment entity);  
        void Update(Equipment entity);  
        void Delete(Equipment entity);           
    }
}