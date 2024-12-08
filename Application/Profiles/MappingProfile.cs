using Application.Features.Excerices.Commands.CreateExcercise;
using Application.Features.Excerices.Commands.UpdateExcercise;
using Application.Features.Excerices.Queries.GetExcercises;
using Application.Features.Workouts.Commands.CreateWorkout;
using Application.Features.Workouts.Queries.GetWorkouts;
using Application.Features.Workouts.Queries.GetWorkoutsWithExcercises;
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
            CreateMap<Excercise, UpdateExcerciseCommand>().ReverseMap();

            //workouts
            CreateMap<Workout, ExcerciseDto>().ReverseMap();
            CreateMap<Workout, WorkoutDetailVM>().ReverseMap();
            CreateMap<Workout, CreateWorkoutCommand>().ReverseMap();

            CreateMap<Workout, WorkoutExcerciseDto>().ReverseMap();
            CreateMap<Excercise, WorkoutExcerciseDto>().ReverseMap();
            CreateMap<Workout, WorkoutExcerciseListVm>().ReverseMap();

        }
    }
}
