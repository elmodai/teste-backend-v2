using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aiko.GestEquipamento.Application.Interfaces;
using Aiko.GestEquipamento.Domain.Entities;

namespace Aiko.GestEquipamento.Application.Services
{
    public class EquipmentService : IEquipmentService
    {
        public void Delete(Equipment entity)
        {
            throw new NotImplementedException();
        }

        public Task<Equipment> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Equipment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Equipment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Equipment entity)
        {
            throw new NotImplementedException();
        }
    }
}