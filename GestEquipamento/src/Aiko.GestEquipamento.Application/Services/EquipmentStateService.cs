using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Aiko.GestEquipamento.Domain.Interfaces;

namespace Aiko.GestEquipamento.Application.Services
{
    public class EquipmentStateService : IEquipmentStateService
    {
        private IRepository<EquipmentState> _repository;

        public EquipmentStateService(IRepository<EquipmentState> repository)
        {
            _repository = repository;
        }

        public void Delete(EquipmentState entity)
        {
            throw new NotImplementedException();
        }

        public Task<EquipmentState> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipmentState>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(CreateEquipmentStateDTO dto)
        {
            EquipmentState es = new()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Color = dto.Color
            };

            _repository.Insert(es);
            _repository.SaveChanges();
        }

        public void Update(EquipmentState entity)
        {
            throw new NotImplementedException();
        }
    }
}
