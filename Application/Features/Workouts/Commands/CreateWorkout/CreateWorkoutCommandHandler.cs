using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutCommandHandler : IRequestHandler<CreateWorkoutCommand, Guid>
    {
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IMapper _mapper;
        public CreateWorkoutCommandHandler(IMapper mapper, IWorkoutRepository
        workoutRepository)
        {
            _mapper = mapper;
            _workoutRepository = workoutRepository;
        }

        public async Task<Guid> Handle(CreateWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workout = _mapper.Map<Workout>(request);
            workout = await _workoutRepository.AddAsync(workout);
            return workout.WorkoutId;
        }

    }
}
