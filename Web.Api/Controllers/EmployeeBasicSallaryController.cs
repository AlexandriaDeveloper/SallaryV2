
using Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallary;

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

        //[HttpGet("GetEmployeeBasicSallaryByFinancialYear")]
        //public async Task<ActionResult<Result<EmployeeBasicSallary>>> GetEmployeeBasicSallaryByFinancialYear([FromQuery] GetEmployeeBasicSallaryQuery command)
        //{
        //    var result = (await Mediator.Send(command));


        //    if (result.IsFailure)
        //    {
        //        return HandleFailureResult(result);
        //    }
        //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<Result<EmployeeBasicSallaryDto>>> GetEmployeeLastBasicSallaryQuery(int id, DateTime selectedDate)
        {
            var result = (await Mediator.Send(new GetEmployeeLastBasicSallaryQuery(id, selectedDate)));


            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        //[HttpPost("EmployeeGetRaised")]
        //public async Task<ActionResult<Result<EmployeeBasicSallary>>> EmployeeGetRaised([FromQuery] EmployeeGetRaisedCommand command)
        //{
        //    var result = (await Mediator.Send(command));
        //    if (result.IsFailure)
        //    {
        //        return HandleFailureResult(result);
        //    }
        //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        //}

        //[HttpPost("EmployeesGetRaiseByGradeCommand")]
        //public async Task<ActionResult<Result<Unit>>> EmployeesGetRaised([FromQuery] EmployeesGetRaiseByGradeCommand command)
        //{
        //    var result = (await Mediator.Send(command));
        //    if (result.IsFailure)
        //    {
        //        return HandleFailureResult(result);

        //    }
        //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        //}

        //[HttpPost("AssignEmployeeFinaicialData")]
        //public async Task<ActionResult<Result<Guid>>> AssignEmployeeFinaicialData([FromQuery] AssignEmployeeBasicSallaryCommand command)
        //{
        //    var result = (await Mediator.Send(command));
        //    if (result.IsFailure)
        //    {
        //        return HandleFailureResult(result);

        //    }
        //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        //}
        //[HttpPut("UpdateEmployeeFinaicialData")]
        //public async Task<ActionResult<Result<Unit?>>> AssignEmployeeFinaicialData([FromQuery] UpdateEmployeeBasicSallaryCommand command)
        //{
        //    var result = (await Mediator.Send(command));
        //    if (result.IsFailure)
        //    {
        //        return HandleFailureResult(result);

        //    }
        //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        //}

    }
}
