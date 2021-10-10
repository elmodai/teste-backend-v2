using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Aiko.GestEquipamento.Domain.Interfaces;

namespace Aiko.GestEquipamento.Application.Services
{
    public class EquipmentModelStateHourlyEarningsService : IEquipmentModelStateHourlyEarningsService
    {
        private IRepository<EquipmentModelStateHourlyEarnings> _repository;

        public EquipmentModelStateHourlyEarningsService(IRepository<EquipmentModelStateHourlyEarnings> repository)
        {
            _repository = repository;
        }

        public void Delete(EquipmentModelStateHourlyEarnings entity)
        {
            throw new NotImplementedException();
        }

        public Task<EquipmentModelStateHourlyEarnings> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipmentModelStateHourlyEarnings>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(EquipmentModelStateHourlyEarningsDTO dto)
        {
            EquipmentModelStateHourlyEarnings hs = new()
            {
                Value = dto.Value,
                EquipmentModelId = dto.EquipmentModelId,
                EquipmentStateId = dto.EquipmentStateId
            };

            _repository.Insert(hs);
            _repository.SaveChanges();
        }

        public void Update(EquipmentModelStateHourlyEarnings entity)
        {
            throw new NotImplementedException();
        }
    }
}
