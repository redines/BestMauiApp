using Application.Features.Examples;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExcerciseEntity, ExcerciseListVm>().ReverseMap();
        }
    }
}
