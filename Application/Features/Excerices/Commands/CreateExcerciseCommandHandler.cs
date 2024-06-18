using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Excerices.Commands
{
    public class CreateExcerciseCommandHandler : IRequestHandler<CreateExcerciseCommand, Guid>
    {
        private readonly IExcerciseRepository _excerciseRepository;
        private readonly IMapper _mapper;
        public CreateExcerciseCommandHandler(IMapper mapper, IExcerciseRepository
        excerciseRepository)
        {
            _mapper = mapper;
            _excerciseRepository = excerciseRepository;
        }

        public async Task<Guid> Handle(CreateExcerciseCommand request, CancellationToken cancellationToken)
        {
            var excercise = _mapper.Map<Excercise>(request);
            excercise = await _excerciseRepository.AddAsync(excercise);
            return excercise.Id;
        }

    }
}
