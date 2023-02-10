using Application.Orders.Queries;
//using Application.OrderFiles.Queries;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers;


public class OrderController : BaseController
{
    public OrderController(IMediator mediator) : base(mediator)
    {

    }

    [HttpGet]
    public async Task<ActionResult<Result>> GetOrders()
    {

        var result = await Mediator.Send(new GetAllOrdersQuery());
        if (result.IsFailure)
        {
            return HandleFailureResult(result);
        }
        return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


    }
}

