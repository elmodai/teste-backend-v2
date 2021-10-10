using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentModelService
    {
        Task<IEnumerable<EquipmentModel>> GetAll();  
        Task<EquipmentModel> Get(Guid Id);  
        void Insert(EquipmentModel entity);  
        void Update(EquipmentModel entity);  
        void Delete(EquipmentModel entity);           
         
    }
}