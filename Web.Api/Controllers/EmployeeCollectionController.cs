using Application.EmployeeCollections.Commands.AssignEmployeeToCollection;
using Application.EmployeeCollections.Commands.DeleteEmployeeFromCollection;
using Application.EmployeeCollections.Commands.UpdateEmployeeRowOrder;
using Application.EmployeeCollections.Queries.GetEmployeeListCollection;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeCollectionController : BaseController
    {
        public EmployeeCollectionController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeListCollection([FromQuery] int collectionId)
        {

            var result = await Mediator.Send(new GetEmployeeListCollectionQuery(collectionId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> AddBankWithBranches([FromBody] EmployeeCollectionToAddDto employeeCollection)
        {

            var result = await Mediator.Send(new AssignEmployeeToCollectionCommand(employeeCollection));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }


        [HttpPut("reorderRows")]
        public async Task<ActionResult<Result<Unit>>> ReorderRows([FromBody] int[] ids)
        {

            var result = await Mediator.Send(new UpdateEmployeeRowOrderCommand(ids));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpDelete("DeleteEmployeeFromCollection/{id}")]
        public async Task<ActionResult<Result<Unit>>> DeleteEmployeeFromCollection(int id)
        {

            var result = await Mediator.Send(new DeleteEmployeeFromCollectionCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
