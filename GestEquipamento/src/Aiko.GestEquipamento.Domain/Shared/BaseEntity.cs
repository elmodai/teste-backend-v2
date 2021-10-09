using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aiko.GestEquipamento.Domain.Shared
{
    public class BaseEntity
    {
        public interface IAuditableEntity<TKey> : IAuditableEntity
        {
        }

        public interface IAuditableEntity
        {
            DateTime? Date { get; set; }
        }

        public interface IABaseEntity<TKey>
        {
            TKey Id { get; set; }
        }
        public abstract class ABaseEntity<TKey> : IABaseEntity<TKey>
        {
            [Key]
            public TKey Id { get; set; }

        }

        public abstract class AuditableEntity<TKey> : IAuditableEntity<TKey>
        {
            public DateTime? Date { get; set; }
        }

    }
}