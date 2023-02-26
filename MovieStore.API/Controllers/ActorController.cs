using Application.Features.CQRS.Queries.ActorQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetActors()
        {
            var result = await _mediator.Send(new GetActorsQueryRequest());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActorByID(int id)
        {
            var result = await _mediator.Send(new GetActorQueryRequest(id));

            return Ok(result);
        }
    }
}
