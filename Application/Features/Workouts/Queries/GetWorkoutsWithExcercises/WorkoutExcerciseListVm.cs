using Application.Features.Workouts.Queries.GetWorkouts;

namespace Application.Features.Workouts.Queries.GetWorkoutsWithExcercises
{
    public class WorkoutExcerciseListVm
    {
        public Guid WorkoutId { get; set; }
        public string? Day { get; set; }
        public ICollection<ExcerciseDto> Excercises { get; set; }
    }
}
