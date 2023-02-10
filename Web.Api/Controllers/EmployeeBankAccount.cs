using Application.EmployeeBankAccount;

using Application.EmployeeBankAccount.Commands.EmployeeAddBankAccount;
using Application.EmployeeBankAccount.Commands.EmployeeRemoveBankAccount;
using Application.EmployeeBankAccount.Query.GetEmployeeBankAccountData;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeBankAccountController : BaseController
    {
        public EmployeeBankAccountController(IMediator mediator) : base(mediator)
        {
        }


        [HttpGet("{bankId}")]
        public async Task<ActionResult<Result<Unit>>> EmployeeBankAccount(int bankId)
        {

            var result = await Mediator.Send(new GetEmployeeBankAccountDataQuery(bankId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }



        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> EmployeeAddBankAccount([FromBody] EmployeeBankAccountDto employeeBankAccount)
        {

            var result = await Mediator.Send(new EmployeeAddBankAccountCommand(employeeBankAccount));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpDelete("EmployeeRemoveBankAccount/{employeeId}")]
        public async Task<ActionResult<Result<Unit>>> EmployeeRemoveBankAccount(int employeeId)
        {

            var result = await Mediator.Send(new EmployeeRemoveBankAccountCommand(employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }


    }
}
