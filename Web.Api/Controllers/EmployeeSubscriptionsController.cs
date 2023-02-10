using Application.EmployeeSubscriptions.Commands.DeleteEmployeeFromSubscription;
using Application.EmployeeSubscriptions.Commands.UpdateEmployeeSubscriptionActiveToggle;
using Application.EmployeeSubscriptions.Commands.UpdateEmployeeSubscrtiption;
using Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionByEmployeeId;
using Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionById;
using Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionList;
using Domain.EmployeeOrders.Commands.EmployeeToSubscription;
using Domain.EmployeeSubscriptions;
using Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class EmployeeSubscriptionsController : BaseController
    {
        public EmployeeSubscriptionsController(IMediator mediator) : base(mediator) { }


        [HttpGet()]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeSubscriptionListQuery([FromQuery] EmployeeSubscriptionParam paran)
        {

            var result = (await Mediator.Send(new GetEmployeeSubscriptionListQuery(paran)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }


        [HttpGet("GetEmployeeSubscriptionBalanceByEmployeeId/{employeeId}")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeSubscriptionBalanceByEmployeeId(int employeeId)
        {

            var result = (await Mediator.Send(new GetEmployeeSubscriptionBalanceByEmployeeIdQuery(employeeId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("GetEmployeeSubscriptionById/{Id}")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeSubscriptionById(int Id)
        {

            var result = (await Mediator.Send(new GetEmployeeSubscriptionByIdQuery(Id)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost("AssignEmployeeToSubscription")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeeToSubscription(EmployeeToSubscriptionDto subscriptionDto)
        {

            var result = (await Mediator.Send(new AssignEmployeeToSubscriptionCommand(subscriptionDto)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }


        [HttpPut("UpdateEmployeeSubscrtiption")]
        public async Task<ActionResult<Result<Unit>>> UpdateEmployeeSubscrtiption(EmployeeToSubscriptionDto subscriptionDto)
        {

            var result = (await Mediator.Send(new UpdateEmployeeSubscrtiptionCommand(subscriptionDto)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpPost("AssignEmployeesSubscriptionToOrderForm")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeesToSubscriptionOrderForm(int subscriptionId, int formId)
        {

            var result = (await Mediator.Send(new EmployeeToSubscriptionOrderCommand(subscriptionId, formId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPut("UpdateEmployeeSubscriptionActiveToggle/{employeeSubscriptionId}")]
        public async Task<ActionResult<Result<Unit>>> UpdateEmployeeSubscriptionActiveToggle(int employeeSubscriptionId)
        {

            var result = (await Mediator.Send(new UpdateEmployeeSubscriptionActiveToggleCommand(employeeSubscriptionId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpDelete("DeleteEmployeeFromSubscription/{employeeSubscriptionId}")]
        public async Task<ActionResult<Result<Unit>>> DeleteEmployeeFromSubscription(int employeeSubscriptionId)
        {

            var result = (await Mediator.Send(new DeleteEmployeeFromSubscriptionCommand(employeeSubscriptionId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
