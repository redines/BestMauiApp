using MediatR;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetWorkoutQuery : IRequest<WorkoutDetailVM>
    {
        public Guid Id { get; set; }
    }
}
