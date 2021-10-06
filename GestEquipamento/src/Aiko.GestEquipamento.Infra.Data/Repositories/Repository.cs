using System;
using System.Collections.Generic;
using System.Linq;
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
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Remove(entity);  
            _applicationDbContext.SaveChanges();  
        }  
        
        public T Get(Guid Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);  
        }
        
        public IEnumerable<T> GetAll()  
        {  
            return entities.AsEnumerable();  
        }  
  
        public void Insert(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Add(entity);  
            _applicationDbContext.SaveChanges();  
        }  
  
        public void Remove(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Remove(entity);  
        }  
  
        public void SaveChanges()  
        {  
            _applicationDbContext.SaveChanges();  
        }  
  
        public void Update(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Update(entity);  
            _applicationDbContext.SaveChanges();  
        } 


    }
}