using Application.Features.Excerices.Commands.CreateExcercise;
using Application.Features.Excerices.Queries.GetExcercises;
using Application.Features.Workouts.Commands;
using Application.Features.Workouts.Queries.GetWorkouts;
using AutoMapper;
using Domain.Entities.ExcerciseEntities;

namespace Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //excercises
            CreateMap<Excercise, ExcerciseDetailVM>().ReverseMap();
            CreateMap<Excercise, CreateExcerciseCommand>().ReverseMap();

            //workouts
            CreateMap<Workout, WorkoutDetailVM>().ReverseMap();
            
        }
    }
}
