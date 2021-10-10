using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Interfaces
{
    public interface IEquipmentModelStateHourlyEarningsService
    {
        Task<IEnumerable<EquipmentModelStateHourlyEarnings>> GetAll();  
        Task<EquipmentModelStateHourlyEarnings> Get(Guid Id);  
        void Insert(EquipmentModelStateHourlyEarningsDTO dto);  
        void Update(EquipmentModelStateHourlyEarnings entity);  
        void Delete(EquipmentModelStateHourlyEarnings entity);           
         
    }
}