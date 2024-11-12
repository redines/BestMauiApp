using Application.Features.Excerices.Queries.GetExcercises;
using Application.Features.Workouts.Commands.CreateWorkout;
using Application.Features.Workouts.Queries.GetWorkouts;
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

        [HttpGet("one", Name = "GetWorkout")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ExcerciseDetailVM>> Getworkout()
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
