using Application.Subscriptions;
using Application.Subscriptions.Commands.AddSubscription;
using Application.Subscriptions.Queries.GetSubscriptions;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class SubscriptionController : BaseController
    {
        public SubscriptionController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<Result<Unit>>> GetAllSubscriptions()
        {

            var result = await Mediator.Send(new GetSubscriptionsQuery());
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> AddSubscriptions(SubscriptionDto subscription)
        {

            var result = await Mediator.Send(new AddSubscriptionCommand(subscription));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
