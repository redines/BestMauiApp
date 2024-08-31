using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    public class GetWorkoutListQueryHandler : IRequestHandler<GetWorkoutListQuery, List<WorkoutDetailVM>>
    {
        private readonly IAsyncRepository<Workout> _workoutListVmRepository;
        private readonly IMapper _mapper;

        public GetWorkoutListQueryHandler(IMapper mapper, IAsyncRepository<Workout> WorkoutListVmRepository)
        {
            _workoutListVmRepository = WorkoutListVmRepository;
            _mapper = mapper;
        }

        public async Task<List<WorkoutDetailVM>> Handle(GetWorkoutListQuery request, CancellationToken cancellationToken)
        {
            var allExcersises = await _workoutListVmRepository.ListAllAsync();
            return _mapper.Map<List<WorkoutDetailVM>>(allExcersises);
        }
    }
}
