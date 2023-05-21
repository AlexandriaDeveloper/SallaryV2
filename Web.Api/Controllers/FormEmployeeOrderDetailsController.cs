using Application.EmployeeOrderDetailses.Commands.DeleteEmployeeOrderByOrderDetailsId;
using Application.EmployeeOrderDetailses.Queries.GetEmployeeOrderByOrderFileId;
using Domain.EmployeeOrders;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class FormEmployeeOrderDetailsController : BaseController
    {
        public FormEmployeeOrderDetailsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpDelete("{orderFileId}")]
        public async Task<IActionResult> GetEmployeeOrderDetailsBy(int orderFileId)
        {

            var result = (await Mediator.Send(new DeleteEmployeeOrderByOrderDetailsIdCommand(orderFileId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);

        }
        [HttpGet("GetEmployeeOrderDetailsByOrderFileIdDto")]
        public async Task<ActionResult<Result<PagedList<EmployeeOrderDetailsByOrderFileIdDto>>>> GetEmployeeOrderDetailsByOrderFileIdDto([FromQuery] GetEmployeeOrderByFormIdQueryParams param)
        {

            var result = (await Mediator.Send(new GetEmployeeOrderByOrderFileIdQuery(param)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
