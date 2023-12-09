using System;
namespace LinkedOut.Contracts
{
    public class AuditableEntity : BaseEntity, IAuditableEntity, ISoftDelete
    {
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get ; set; } = DateTime.UtcNow;
        public int LastModifiedBy { get ; set ; }
        public DateTime? LastModifiedOn { get ; set ; } = DateTime.UtcNow;
        public DateTime? DeletedOn { get ; set; }
        public int? DeletedBy { get ; set ; }
        public bool? IsDeleted { get ; set ; }
        DateTime? IAuditableEntity.CreatedOn { get; set; } = DateTime.UtcNow;
        DateTime? IAuditableEntity.LastModifiedOn { get; set; } = DateTime.UtcNow;
    }
}
