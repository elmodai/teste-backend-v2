using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Interfaces
{
    public interface IRepository<T> where T : IABaseEntity<Guid>
    {
        Task<IEnumerable<T>> GetAll();  
        Task<T> Get(Guid Id);  
        void Insert(T entity);  
        void Update(T entity);  
        void Delete(T entity);  
        void SaveChanges();          
        
    }
}