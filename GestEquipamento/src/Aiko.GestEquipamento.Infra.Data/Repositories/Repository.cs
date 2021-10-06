using System;
using System.Collections.Generic;
using Aiko.GestEquipamento.Domain.Interfaces;
using Aiko.GestEquipamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : ABaseEntity<Guid>
    {
        private readonly ApplicationDbContext _applicationDbContext;  
        private DbSet<T> entities;  
        
        public Repository(ApplicationDbContext applicationDbContext)  
        {  
            _applicationDbContext = applicationDbContext;  
            entities = _applicationDbContext.Set<T>();  
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(long Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

    }
}