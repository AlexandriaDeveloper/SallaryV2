
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


    }
}
