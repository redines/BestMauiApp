using Application.Features.Excerices.Commands;
using Application.Features.Excerices.Queries;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Excercise, ExcerciseListVm>().ReverseMap();
            CreateMap<Excercise, ExcerciseDetailVM>().ReverseMap();
            CreateMap<Excercise, CreateExcerciseCommand>().ReverseMap();
        }
    }
}
