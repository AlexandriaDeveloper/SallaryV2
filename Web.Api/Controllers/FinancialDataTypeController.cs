using Application.Banks.Commands.RegisterBankWithBranches;
using Application.EmployeeBankAccount;
using Application.FinancialDataTypes;
using Application.FinancialDataTypes.Commands.AddFinincialDataType;
using Application.FinancialDataTypes.Commands.DeleteFinicialDataType;
using Application.FinancialDataTypes.Commands.UpdateFinincialDataType;
using Application.FinancialDataTypes.Queries.GetParentElements;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class FinancialDataTypeController : BaseController
    {

        //AddFinincialDataTypeCommand
        public FinancialDataTypeController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet]
        public async Task<ActionResult<Result>> GetParentElementsQuery([FromQuery] ElementParameter param)
        {

            var result = await Mediator.Send(new GetParentElementsQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> AddFinincialDataTypeCommand([FromBody] FinancialDataTypeDto data)
        {

            var result = await Mediator.Send(new AddFinincialDataTypeCommand(data));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpPut]
        public async Task<ActionResult<Result<Unit>>> UpdateFinincialDataTypeCommand([FromBody] FinancialDataTypeDto data)
        {

            var result = await Mediator.Send(new UpdateFinincialDataTypeCommand(data));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<Unit>>> DeleteFinincialDataTypeCommand(int id)
        {

            var result = await Mediator.Send(new DeleteFinicialDataTypeCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
