using Application.BankBranches.Commands.AddBranchToBank;
using Application.BankBranches.Commands.DeleteBrach;
using Application.BankBranches.Commands.UpdtareBranch;
using Application.BankBranches.Queries;
using Application.EmployeeBankAccount;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class BankBranchController : BaseController
    {
        public BankBranchController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{bankId}")]
        public async Task<ActionResult<Result<Unit>>> GetBankBranch(int bankId)
        {

            var result = await Mediator.Send(new GetBankBranchesListQuery(bankId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> EmployeeAddBankAccount([FromBody] BrancheDto branch)
        {

            var result = await Mediator.Send(new AddBranchToBankCommand(branch));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpPut()]
        public async Task<ActionResult<Result<Unit>>> UpdateBranch([FromBody] BrancheDto branch)
        {

            var result = await Mediator.Send(new UpdateBranchCommand(branch));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        //DeleteBranchCommand
        [HttpDelete("{id}")]

        public async Task<ActionResult<Result<Unit>>> DeleteBranch(int id)
        {

            var result = await Mediator.Send(new DeleteBranchCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
