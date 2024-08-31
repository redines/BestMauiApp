using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Excerices.Queries.GetExcercises
{
    //Handler will contain the actual behaviour and execute through a request and return the Vm with wanted data
    public class GetExerciseQueryHandler : IRequestHandler<GetExerciseQuery, ExcerciseDetailVM>
    {
        private readonly IAsyncRepository<Excercise> _excerciseVmRepository;
        private readonly IMapper _mapper;

        public GetExerciseQueryHandler(IAsyncRepository<Excercise> excerciseVmRepository, IMapper mapper)
        {
            _excerciseVmRepository = excerciseVmRepository;
            _mapper = mapper;
        }

        public async Task<ExcerciseDetailVM> Handle(GetExerciseQuery request, CancellationToken cancellationToken)
        {
            var excer = await _excerciseVmRepository.GetByIdAsync(request.Id);
            var detail = _mapper.Map<ExcerciseDetailVM>(excer);


            return detail;
        }
    }
}
