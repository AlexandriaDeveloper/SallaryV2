using Application.EmployeePartTimes;
using Application.EmployeePartTimes.Commands.EmployeeEndPartTime;
using Application.EmployeePartTimes.Commands.EmployeeStratPartTime;
using Application.EmployeePartTimes.Queries.GetAllPartTimesByEmployeeId;
using Application.EmployeePartTimes.Queries.GetPartTimeByEmployeeId;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeePartTimeController : BaseController
    {
        public EmployeePartTimeController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetEmployeeParttimeByEmployeeId/{employeeId}")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeStartPartTime(int employeeId)
        {

            var result = await Mediator.Send(new GetPartTimeByEmployeeIdQuery(employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


        }
        [HttpGet("GetEmployeeParttimeHistoryByEmployeeId/{employeeId}")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeStaGetEmployeeParttimeHistoryByEmployeeIdrtPartTime(int employeeId)
        {

            var result = await Mediator.Send(new GetEmployeePartTimeHistoryQuery(employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


        }
        [HttpPost("EmployeeStartPartTime")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeStartPartTime([FromBody] EmployeePartTimeDto command)
        {

            var result = await Mediator.Send(new EmployeeStartPartTimeCommand(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


        }
        [HttpPut("EmployeeEndPartTime")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeEndPartTime([FromBody] EmployeePartTimeDto command)
        {


            var result = await Mediator.Send(new EmployeeEndPartTimeCommand(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);

        }
    }
}
