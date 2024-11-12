using Domain.Entities.ExcerciseEntities;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    public class WorkoutDetailVM
    {
        Guid Id { get; set; }
        public string? Day { get; set; }
        public ICollection<Excercise>? Excercises { get; set; }
    }
}
