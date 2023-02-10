namespace Web.Api.Controllers
{
    //public class OrderFileController : BaseController
    //{
    //public OrderFileController(IMediator mediator) : base(mediator)
    //{

    //}

    //[HttpGet]
    //public async Task<ActionResult<Result>> GetOrderFiles()
    //{

    //    var result = await Mediator.Send(new GetAllOrderFilesQuery());
    //    if (result.IsFailure)
    //    {
    //        return HandleFailureResult(result);
    //    }
    //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


    //}


    //[HttpGet("GetPaginatedOrderFile")]
    //public async Task<ActionResult<Result>> GetPaginatedOrderFile([FromQuery] GetPaginatedOrderFilesQueryParam param)
    //{

    //    var result = await Mediator.Send(new GetPaginatedOrderFilesQuery(param));
    //    if (result.IsFailure)
    //    {
    //        return HandleFailureResult(result);
    //    }
    //    return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
    //}


    //[HttpGet("{id}")]
    //public async Task<ActionResult<Result>> GetOrderFileByIdQuery(int id )
    //{

    //    var result = await Mediator.Send(new GetOrderFileByIdQuery(id));
    //    if (result.IsFailure)
    //    {
    //        return HandleFailureResult(result);
    //    }
    //    return result.IsSuccess ? Ok(result) : NotFound(result.Error);
    //}
    //[HttpPost]
    //public async Task<ActionResult<Result<Unit>>> CreateOrderFile([FromBody] OrderFileDto orderFile)
    //{

    //    var result = await Mediator.Send(new CreateOrderFileCommand(orderFile));
    //    if (result.IsFailure)
    //    {
    //        return HandleFailureResult(result);
    //    }
    //    return result.IsSuccess ? Ok(result) : NotFound(result.Error);
    //}
    // }
}
