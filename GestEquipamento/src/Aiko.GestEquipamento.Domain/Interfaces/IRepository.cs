using System.Collections.Generic;
using static Aiko.GestEquipamento.Domain.Shared.BaseEntity;

namespace Aiko.GestEquipamento.Domain.Interfaces
{
    public interface IRepository<T> where T : ABaseEntity<int>
    {
        IEnumerable<T> GetAll();  
        T Get(long Id);  
        void Insert(T entity);  
        void Update(T entity);  
        void Delete(T entity);  
        void Remove(T entity);  
        void SaveChanges();          
        
    }
}