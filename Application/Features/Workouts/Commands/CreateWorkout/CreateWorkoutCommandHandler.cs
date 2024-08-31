using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Workouts.Commands
{
    public class DeleteWorkoutCommandHandler : IRequestHandler<DeleteWorkoutCommand, Guid>
    {
        private readonly IExcerciseRepository _excerciseRepository;
        private readonly IMapper _mapper;
        public DeleteWorkoutCommandHandler(IMapper mapper, IExcerciseRepository
        excerciseRepository)
        {
            _mapper = mapper;
            _excerciseRepository = excerciseRepository;
        }

        public async Task<Guid> Handle(DeleteWorkoutCommand request, CancellationToken cancellationToken)
        {
            var excercise = _mapper.Map<Excercise>(request);
            excercise = await _excerciseRepository.AddAsync(excercise);
            return excercise.Id;
        }

    }
}
