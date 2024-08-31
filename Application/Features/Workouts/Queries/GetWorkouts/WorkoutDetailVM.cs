using Domain.Entities.ExcerciseEntities;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    public class WorkoutDetailVM
    {
        Guid Id { get; set; }
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public string? Day { get; set; }
        ICollection<Excercise>? Excercises { get; set; }
    }
}
