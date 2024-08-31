using Application.Contracts.Persistance;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommandHandler : IRequestHandler<DeleteWorkoutCommand>
    {
        private readonly IAsyncRepository<Workout> _workoutRepository;
        private readonly IMapper _mapper;

        public DeleteWorkoutCommandHandler(IMapper mapper, IAsyncRepository<Workout> workoutRepository)
        {
            _mapper = mapper;
            _workoutRepository = workoutRepository;
        }

        public async Task Handle(DeleteWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workoutToDelete = await _workoutRepository.GetByIdAsync(request.WorkoutId);

            if (workoutToDelete == null)
            {
                throw new NotFoundException(nameof(Workout), request.WorkoutId);
            }

            await _workoutRepository.DeleteAsync(workoutToDelete);
        }
    }
}
