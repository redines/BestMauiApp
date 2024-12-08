using MediatR;

namespace Application.Features.Workouts.Queries.GetWorkoutsWithExcercises
{
    public class GetWorkoutsWithExcerciseListQuery : IRequest<List<WorkoutExcerciseListVm>>
    {

    }
}
