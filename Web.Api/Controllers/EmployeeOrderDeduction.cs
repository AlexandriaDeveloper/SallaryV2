using Domain.EmployeeOrders;
using Domain.EmployeeOrders.Commands.PayDeductionEmployee;
using Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeOrderDeductionController : BaseController
    {
        public EmployeeOrderDeductionController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet("GetEmployeeOrderBalance/{employeeId}")]
        public async Task<ActionResult<Result<Unit?>>> GetEmployeeOrderBalance(int employeeId)
        {


            var result = (await Mediator.Send(new EmployeeOrderDeductionBalanceQuery(employeeId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("PayDeductionEmployee")]
        public async Task<IActionResult> PayDeductionEmployee(EmployeeOrderDeductionDto model)
        {

            var result = (await Mediator.Send(new PayDeductionEmployeeCommand(model)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }


}
