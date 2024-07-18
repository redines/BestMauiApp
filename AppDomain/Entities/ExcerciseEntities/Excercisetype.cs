using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class Excercisetype : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ExcerciseName { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
    }
}
