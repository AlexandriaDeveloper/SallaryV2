using Application.VacationTypes;
using Application.VacationTypes.Queries.GetVacationTypeList;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class VacationTypeController : BaseController
    {
        public VacationTypeController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet()]
        public async Task<ActionResult<Result<IReadOnlyList<VacationTypeDto>>>> GetVacationType([FromQuery] GetVacationTypeListQueryParam param)
        {

            var result = await Mediator.Send(new GetVacationTypeListQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
