using Domain.EmployeesSallaries.Commands.AssignEmployeeBasicSallary;
using Domain.EmployeesSallaries.Commands.EmployeeGetRaise;
using Domain.EmployeesSallaries.Commands.EmployeesGetRaiseByGrade;
using Domain.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary;
using Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallary;
using Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear;
using Domain.Models;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeBasicSallaryController : BaseController
    {
        public EmployeeBasicSallaryController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetEmployeeBasicSallaryByFinancialYear")]
        public async Task<ActionResult<Result<EmployeeBasicSallary>>> GetEmployeeBasicSallaryByFinancialYear([FromQuery] GetEmployeeBasicSallaryQuery command)
        {
            var result = (await Mediator.Send(command));


            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Result<EmployeeBasicSallary>>> GetEmployeeLastBasicSallaryQuery(int id)
        {
            var result = (await Mediator.Send(new GetEmployeeLastBasicSallaryQuery(id)));


            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost("EmployeeGetRaised")]
        public async Task<ActionResult<Result<EmployeeBasicSallary>>> EmployeeGetRaised([FromQuery] EmployeeGetRaisedCommand command)
        {
            var result = (await Mediator.Send(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("EmployeesGetRaiseByGradeCommand")]
        public async Task<ActionResult<Result<Unit>>> EmployeesGetRaised([FromQuery] EmployeesGetRaiseByGradeCommand command)
        {
            var result = (await Mediator.Send(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("AssignEmployeeFinaicialData")]
        public async Task<ActionResult<Result<Guid>>> AssignEmployeeFinaicialData([FromQuery] AssignEmployeeBasicSallaryCommand command)
        {
            var result = (await Mediator.Send(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPut("UpdateEmployeeFinaicialData")]
        public async Task<ActionResult<Result<Unit?>>> AssignEmployeeFinaicialData([FromQuery] UpdateEmployeeBasicSallaryCommand command)
        {
            var result = (await Mediator.Send(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

    }
}
