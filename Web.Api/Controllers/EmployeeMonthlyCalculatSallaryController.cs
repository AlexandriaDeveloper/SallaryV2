using Domain.EmployeeOrders;
using Domain.EmployeeOrders.Commands.NewOrderToEmployee;
using Domain.EmployeeOrders.Queries.GetEmployeeOrderData;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeOrderController : BaseController


    {

        public EmployeeOrderController(IMediator mediator) : base(mediator) { }


        [HttpGet("GetEmployeeOrders")]
        public async Task<ActionResult<Result<Unit?>>> GetEmployeeOrders([FromQuery] int employeeId, int orderId)
        {


            var result = (await Mediator.Send(new GetEmployeeOrdersDataQuery(orderId, employeeId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("NewEmployeeOrder")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand([FromBody] EmployeeOrderDto command)
        {


            var result = await Mediator.Send(new NewEmployeeOrderCommand(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
