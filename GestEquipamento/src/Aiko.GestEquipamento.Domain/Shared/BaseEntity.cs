using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aiko.GestEquipamento.Domain.Shared
{
    public class BaseEntity
    {
        public interface IDeletableEntity
        {
            public bool IsDeleted { get; set; }
        }

        public interface IDeletableEntity<TKey> : IDeletableEntity, IABaseEntity<TKey>
        {
        }

        public interface IAuditableEntity<TKey> : IAuditableEntity, IDeletableEntity<TKey>
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
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public TKey Id { get; set; }

        }

        public abstract class DeletableEntity<TKey> : ABaseEntity<TKey>, IDeletableEntity<TKey>
        {
            public bool IsDeleted { get; set; }
        }

        public abstract class AuditableEntity<TKey> : DeletableEntity<TKey>, IAuditableEntity<TKey>
        {
            public DateTime? Date { get; set; }
        }

    }
}