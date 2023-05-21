using Application.Banks.Queries;
using Application.FormEmployeeVacations.Queries.GetFormEmployeeVacationsBy;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class FormEmployeeVacationController : BaseController
    {
        public FormEmployeeVacationController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<Result<Unit>>> GetFormEmployeeVacation([FromQuery] GetFormEmployeeVacationsByQueryParam param)
        {

            var result = await Mediator.Send(new GetFormEmployeeVacationsByQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
