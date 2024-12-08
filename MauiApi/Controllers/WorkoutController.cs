using Application.Features.Excerices.Queries.GetExcercises;
using Application.Features.Workouts.Commands.CreateWorkout;
using Application.Features.Workouts.Queries.GetWorkouts;
using Application.Features.Workouts.Queries.GetWorkoutsWithExcercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MauiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IMediator _mediator;
        public WorkoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllWorkouts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<WorkoutDetailVM>>> GetAllworkouts()
        {
            var result = await _mediator.Send(new GetWorkoutListQuery());
            return Ok(result);
        }

        [HttpGet("allwithexcercises", Name = "GetAllWorkoutsWithExcercises")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<WorkoutExcerciseListVm>>> GetWorkoutsWithExcercises()
        {
            GetWorkoutsWithExcerciseListQuery getWorkoutsWithExcerciseListQuery = new GetWorkoutsWithExcerciseListQuery();

            var dtos = await _mediator.Send(getWorkoutsWithExcerciseListQuery);
            return Ok(dtos);
        }

        [HttpGet("one", Name = "GetWorkout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<WorkoutDetailVM>> Getworkout()
        {
            var result = await _mediator.Send(new GetWorkoutQuery());
            return Ok(result);
        }

        [HttpPost(Name = "AddWorkout")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateWorkoutCommand createWorkoutCommand)
        {
            var id = await _mediator.Send(createWorkoutCommand);
            return Ok(id);
        }
    }
}
