using Domain.Common;

namespace Domain.Entities
{
    public class ExcerciseEntities : AuditableEntity
    {
        public Guid Id { get; set; }
        public ICollection<ExcerciseEntity> Excercises { get; set; }
    }
}
