using Application.Banks.Queries;
using Application.Employees.Queries.GetEmployeeByTabCodeOrTegaraCode;
using Application.FormEmployee;
using Application.FormEmployee.Queries.GetFormEmployeeByEmployeeIdAndFormId;
using Application.FormEmployeeOrderExecutions.Queries.GetFormEmployeeOrderExecutionByFormEmployeeOrderId;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class FormEmployeeOrderExecutionController : BaseController
    {
        public FormEmployeeOrderExecutionController(IMediator mediator) : base(mediator)
        {
        }
        //GetEmployeesByEmployeeIdAndFormId
        [HttpGet("GetByFormEmployeeId")]
        public async Task<ActionResult<Result<IReadOnlyList<FormEmployeeOrderExecutionsDto>>>> GetEmployeesByEmployeeIdAndFormId([FromQuery] FormEmployeeOrderExecutionParam param)
        {

            var result = await Mediator.Send(new GetFormEmployeeOrderExecutionByQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

    }
}
