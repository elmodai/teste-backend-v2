using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentModelService
    {
        Task<IEnumerable<EquipmentModel>> GetAll();  
        Task<EquipmentModel> Get(Guid Id);  
        void Insert(CreateEquipmentModelDTO dto);  
        void Update(EquipmentModel entity);  
        void Delete(EquipmentModel entity);           
         
    }
}