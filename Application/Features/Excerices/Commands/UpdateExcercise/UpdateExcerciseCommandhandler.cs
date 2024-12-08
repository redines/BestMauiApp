using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;

namespace Application.Features.Excerices.Commands.UpdateExcercise
{
    public class UpdateExcerciseCommandhandler : IRequestHandler<UpdateExcerciseCommand>
    {
        private readonly IAsyncRepository<Excercise> _excerciseRepository;
        private readonly IMapper _mapper;

        public UpdateExcerciseCommandhandler(IMapper mapper, IAsyncRepository<Excercise> excerciseRepository)
        {
            _mapper = mapper;
            _excerciseRepository = excerciseRepository;
        }

        public async Task Handle(UpdateExcerciseCommand request, CancellationToken cancellationToken)
        {
            var excerciseToUpdate = await _excerciseRepository.GetByIdAsync(request.ExcerciseId);

            _mapper.Map(request, excerciseToUpdate, typeof(UpdateExcerciseCommand), typeof(Excercise));

            await _excerciseRepository.UpdateAsync(excerciseToUpdate);
        }
    }
}
