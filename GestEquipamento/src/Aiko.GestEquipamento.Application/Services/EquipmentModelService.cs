using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.DTOs;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;
using Aiko.GestEquipamento.Domain.Interfaces;

namespace Aiko.GestEquipamento.Application.Services
{
    public class EquipmentModelService : IEquipmentModelService
    {
        private IRepository<EquipmentModel> _repository;

        public EquipmentModelService(IRepository<EquipmentModel> repository)
        {
            _repository = repository;
        }

        public void Delete(EquipmentModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<EquipmentModel> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipmentModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(CreateEquipmentModelDTO dto)
        {
            EquipmentModel em = new()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name
            };
            _repository.Insert(em);
            _repository.SaveChanges();
        }

        public void Update(EquipmentModel entity)
        {
            throw new NotImplementedException();
        }
    }
}