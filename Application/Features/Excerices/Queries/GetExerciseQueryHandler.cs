using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Excerices.Queries
{
    //Handler will contain the actual behaviour and execute through a request and return the Vm with wanted data
    public class GetExerciseQueryHandler : IRequestHandler<GetExerciseQuery, ExcerciseListVm>
    {
        private readonly IAsyncRepository<ExcerciseEntity> _excerciseVmRepository;
        private readonly IMapper _mapper;

        public GetExerciseQueryHandler(IAsyncRepository<ExcerciseEntity> excerciseVmRepository, IMapper mapper)
        {
            _excerciseVmRepository = excerciseVmRepository;
            _mapper = mapper;
        }

        public async Task<ExcerciseListVm> Handle(GetExerciseQuery request, CancellationToken cancellationToken)
        {
            //var allEvents = await _excerciseVmRepository.GetByIdAsync();
            //return _mapper.Map<List<ExcerciseListVm>>(allEvents);
            return null;
        }
    }
}
