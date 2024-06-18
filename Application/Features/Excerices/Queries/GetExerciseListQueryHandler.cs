using Application.Contracts.Persistance;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Excerices.Queries
{
    public class GetExerciseListQueryHandler : IRequestHandler<GetExerciseListQuery, List<ExcerciseListVm>>
    {
        private readonly IAsyncRepository<Excercise> _excerciseListVmRepository;
        private readonly IMapper _mapper;

        public GetExerciseListQueryHandler(IMapper mapper,IAsyncRepository<Excercise> ExcerciseListVmRepository)
        {
            _excerciseListVmRepository = ExcerciseListVmRepository;
            _mapper = mapper;
        }

        public async Task<List<ExcerciseListVm>> Handle(GetExerciseListQuery request, CancellationToken cancellationToken)
        {
            var allExcersises = (await _excerciseListVmRepository.ListAllAsync());
            return _mapper.Map<List<ExcerciseListVm>>(allExcersises);
        }
    }
}
