
using Application.Collections;
using Application.Collections.Commands;
using Application.Collections.Queries;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class CollectionController : BaseController
    {
        public CollectionController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet]
        public async Task<ActionResult<Result<Unit>>> GetCollections()
        {

            var result = await Mediator.Send(new GetListCollectionsQuery());
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Result<Unit>>> GetCollectionsById(int id)
        {

            var result = await Mediator.Send(new GetCollectionByIdQuery(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> AddNewCollection([FromBody] CollectionDto collection)
        {

            var result = await Mediator.Send(new AddNewCollectionCommand(collection));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
