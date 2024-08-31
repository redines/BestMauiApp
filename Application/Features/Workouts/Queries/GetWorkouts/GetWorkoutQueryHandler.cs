using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Queries.GetWorkouts
{
    //Handler will contain the actual behaviour and execute through a request and return the Vm with wanted data
    public class GetWorkoutQueryHandler : IRequestHandler<GetWorkoutQuery, WorkoutDetailVM>
    {
        private readonly IAsyncRepository<Workout> _WorkoutVmRepository;
        private readonly IMapper _mapper;

        public GetWorkoutQueryHandler(IAsyncRepository<Workout> WorkoutVmRepository, IMapper mapper)
        {
            _WorkoutVmRepository = WorkoutVmRepository;
            _mapper = mapper;
        }

        public async Task<WorkoutDetailVM> Handle(GetWorkoutQuery request, CancellationToken cancellationToken)
        {
            var excer = await _WorkoutVmRepository.GetByIdAsync(request.Id);
            var detail = _mapper.Map<WorkoutDetailVM>(excer);


            return detail;
        }
    }
}
