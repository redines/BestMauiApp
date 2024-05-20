using Application.Contracts.Persistance;
using AutoMapper;
using MediatR;

namespace Application.Features.Examples
{
    public class GetExerciseListQueryHandler : IRequestHandler<GetExerciseListQuery,List<ExcerciseListVm>>
    {
        private readonly IAsyncRepository<ExcerciseListVm> _excerciseListVmRepository;
        private readonly IMapper _mapper;

        public GetExerciseListQueryHandler(IAsyncRepository<ExcerciseListVm> exampleListVmRepository, IMapper mapper)
        {
            _excerciseListVmRepository = exampleListVmRepository;
            _mapper = mapper;
        }

        public async Task<List<ExcerciseListVm>> Handle(GetExerciseListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _excerciseListVmRepository.ListAllAsync());
            return _mapper.Map<List<ExcerciseListVm>>(allEvents);
        }
    }
}
