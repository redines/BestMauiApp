using MediatR;

namespace Application.Features.Workouts.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommand : IRequest
    {
        public Guid WorkoutId { get; set; }
    }
}
