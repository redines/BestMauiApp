using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string? Day { get; set; }
        public ICollection<Excercise>? Excercises { get; set; }
    }
}
