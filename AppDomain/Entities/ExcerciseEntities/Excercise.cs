using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class Excercise : AuditableEntity
    {
        public Guid Id { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Comment { get; set; }
        public int? Weight { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }
    }
}
