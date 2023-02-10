using Application.FinancialYears.Queries;
using Application.FinancialYears.Queries.GetAllFinancialYear;
//using Application.OrderFiles.Queries;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class FinancialYearController : BaseController
    {
        public FinancialYearController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet()]
        public async Task<ActionResult<Result>> GetAllFinanicalYears()
        {

            var result = await Mediator.Send(new GetAllFinancialYearQuery());
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpGet("GetLastFinancialYear")]
        public async Task<ActionResult<Result>> GetLastFinancialYear()
        {

            var result = await Mediator.Send(new GetLastFinancialYearQuery());
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
