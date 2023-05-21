using Application.EmployeeVacationTypes;
using Application.EmployeeVacationTypes.Command.AddEmployeeVacation;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeVactionTypeController : BaseController
    {
        public EmployeeVactionTypeController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> EmployeeBankAccount(FormEmployeeVacationTypeDto EmployeeVacationTypeDto)
        {

            var result = await Mediator.Send(new AddEmployeeVacationCommand(EmployeeVacationTypeDto));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
