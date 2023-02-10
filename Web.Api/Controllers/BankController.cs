
using Application.Banks.Commands.DeleteBank;
using Application.Banks.Commands.RegisterBankWithBranches;
using Application.Banks.Commands.UpdateBank;
using Application.Banks.Queries;
using Application.EmployeeBankAccount;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class BankController : BaseController
    {
        public BankController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet()]
        public async Task<ActionResult<Result<Unit>>> GetBank()
        {

            var result = await Mediator.Send(new GetBankListQuery());
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> AddBankWithBranches([FromBody] BankDto bank)
        {

            var result = await Mediator.Send(new RegisterBankWithBranchesCommand(bank));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpPut()]
        public async Task<ActionResult<Result<Unit>>> UpdateBank([FromBody] BankDto bank)
        {

            var result = await Mediator.Send(new UpdateBankCommand(bank));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<Unit>>> DeleteBank(int id)
        {

            var result = await Mediator.Send(new DeleteBankCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }

}
