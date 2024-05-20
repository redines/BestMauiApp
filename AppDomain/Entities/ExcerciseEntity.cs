using Domain.Common;

namespace Domain.Entities
{
    public class ExcerciseEntity : AuditableEntity
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string ExampleDescription { get; set; }
    }
}
