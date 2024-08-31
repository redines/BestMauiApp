using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    public class Workout : AuditableEntity
    {
        Guid Id {  get; set; } 
        public string Name { get; set; }
        public string? Day { get; set; }
        ICollection<Excercise>? Excercises { get; set; }
    }
}
