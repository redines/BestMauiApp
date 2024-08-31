using Application.Features.Excerices.Commands.CreateExcercise;
using Application.Features.Excerices.Queries;
using Application.Features.Excerices.Queries.GetExcercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MauiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcerciseController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExcerciseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllExcercises")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ExcerciseDetailVM>>> GetAllExcercises()
        {
            var result = await _mediator.Send(new GetExerciseListQuery());
            return Ok(result);
        }

        [HttpGet("one", Name = "GetExcercise")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ExcerciseDetailVM>> GetExcercise()
        {
            var result = await _mediator.Send(new GetExerciseQuery());
            return Ok(result);
        }

        [HttpPost(Name = "AddExcercise")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateExcerciseCommand createExcerciseCommand)
        {
            var id = await _mediator.Send(createExcerciseCommand);
            return Ok(id);
        }
    }
}
