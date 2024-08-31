using MediatR;

namespace Application.Features.Workouts.Commands
{
    public class DeleteWorkoutCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string? Day { get; set; }
    }
}
