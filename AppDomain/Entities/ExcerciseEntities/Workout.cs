using Domain.Common;

namespace Domain.Entities.ExcerciseEntities
{
    [Serializable]
    public class Workout : AuditableEntity
    {
        public Guid WorkoutId {  get; set; } 
        public string Name { get; set; }
        public string Day { get; set; }
        //public ICollection<Excercise>? Excercises { get; set; }
    }
}
