using Application.Contracts.Persistance;
using AutoMapper;
using MediatR;

namespace Application.Features.Workouts.Queries.GetWorkoutsWithExcercises
{
    public class GetWorkoutsWithExcerciseListQueryHandler : IRequestHandler<GetWorkoutsWithExcerciseListQuery, List<WorkoutExcerciseListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IWorkoutRepository _workoutRepository;

        public GetWorkoutsWithExcerciseListQueryHandler(IMapper mapper, IWorkoutRepository workoutRepository)
        {
            _mapper = mapper;
            _workoutRepository = workoutRepository;
        }

        public async Task<List<WorkoutExcerciseListVm>> Handle(GetWorkoutsWithExcerciseListQuery request, CancellationToken cancellationToken)
        {
            var list = await _workoutRepository.GetWorkoutswithExcercises();
            return _mapper.Map<List<WorkoutExcerciseListVm>>(list);
        }
    }
}
