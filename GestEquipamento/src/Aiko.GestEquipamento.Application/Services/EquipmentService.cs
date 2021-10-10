using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Aiko.GestEquipamento.Domain.Interfaces;

namespace Aiko.GestEquipamento.Application.Services
{
    public class EquipmentService : IEquipmentService
    {
        private IRepository<Equipment> _repository;

        public EquipmentService(IRepository<Equipment> repository)
        {
            _repository = repository;
        }
        public void Delete(Equipment entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public Task<Equipment> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Equipment>> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(CreateEquipmentDTO dto)
        {
            Equipment e = new()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                EquipmentModelId = Guid.Parse(dto.EquipmentModelId)
            };

            _repository.Insert(e);
            _repository.SaveChanges();
        }

        public void Update(Equipment entity)
        {
            throw new NotImplementedException();
        }
    }
}