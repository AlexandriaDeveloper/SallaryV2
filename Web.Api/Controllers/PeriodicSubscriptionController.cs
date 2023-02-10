using Application.PeriodicSubscriptions.Commands.AddEmployeeToPeriodicSubscription;
using Application.PeriodicSubscriptions.Commands.DeletePeriodicSubscription;
using Application.PeriodicSubscriptions.Commands.EmployeePaySubscription;
using Application.PeriodicSubscriptions.Commands.UpdatePeriodicSubscription;
using Application.PeriodicSubscriptions.Queries.GetEmployeesSubscriptionByFormId;
using Application.PeriodicSubscriptions.Queries.GetPeriodicSubscriptionById;
using Application.PeriodicSubscriptions.Queries.PeriodicSubscriptionHistoryByEmployee;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class PeriodicSubscriptionController : BaseController
    {
        public PeriodicSubscriptionController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> AddPeriodicSubscriptionDto([FromBody] PeriodicSubscriptionDto periodicSubscription)
        {

            var result = await Mediator.Send(new EmployeePaySubscriptionCommand(periodicSubscription));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }


        [HttpPut()]
        public async Task<ActionResult<Result<Unit>>> UpdarePeriodicSubscriptionDto([FromBody] PeriodicSubscriptionDto periodicSubscription)
        {

            var result = await Mediator.Send(new UpdatePeriodicSubscriptionCommand(periodicSubscription));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpGet("periodicSubscriptionHistoryByEmployee")]
        public async Task<ActionResult<Result<Unit>>> PeriodicSubscriptionHistory([FromQuery] int employeeId, int subscriptionId)
        {

            var result = await Mediator.Send(new PeriodicSubscriptionHistoryByEmployeeQuery(subscriptionId, employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("GetPeriodicSubscriptionById/{id}")]
        public async Task<ActionResult<Result<Unit>>> PeriodicSubscriptionHistory(int id)
        {

            var result = await Mediator.Send(new GetPeriodicSubscriptionByIdQuery(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpGet("GetEmployeesSubscriptionByFormIdQuery")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeesSubscriptionByFormId([FromQuery] int formId, int subscriptionId)
        {

            var result = await Mediator.Send(new GetEmployeesSubscriptionByFormIdQuery(formId, subscriptionId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        //DeletePeriodicSubscriptionCommand
        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<Unit>>> DeletePeriodicSubscription(int id)
        {

            var result = await Mediator.Send(new DeletePeriodicSubscriptionCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        //AddEmployeeToPeriodicSubscriptionCommand

        [HttpPost("AddEmployeeToPeriodicSubscription")]
        public async Task<ActionResult<Result<Unit>>> AddEmployeeToPeriodicSubscription([FromBody] PeriodicSubscriptionDto periodicSubscription)
        {

            var result = await Mediator.Send(new AddEmployeeToPeriodicSubscriptionCommand(periodicSubscription));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

    }
}
