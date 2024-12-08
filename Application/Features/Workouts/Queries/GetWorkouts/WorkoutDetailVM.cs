using Application.Features.Excerices.Queries.GetExcercises;
using Domain.Entities.ExcerciseEntities;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    public class WorkoutDetailVM
    {
        public Guid WorkoutId { get; set; }
        public string? Day { get; set; }
        public ICollection<ExcerciseDto>? Excercises { get; set; }
    }
}
