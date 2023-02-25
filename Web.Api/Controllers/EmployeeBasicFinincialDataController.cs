using Application.Banks.Queries;
using Application.EmployeeBasicFinancialDatas.Commands.UploadEmployeeBasicFinicialData;
using Application.EmployeeBasicFinancialDatas.Commands.AddEmployeeWazifiElements;
using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    public class EmployeeBasicFinincialDataController : BaseController
    {
        public EmployeeBasicFinincialDataController(IMediator mediator) : base(mediator)
        {
        }

     
        [HttpGet()]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeFinincialData(int employeeId ,DateTime? date)
        {

            var result = await Mediator.Send(new GetEmployeeFinincialDataQuery(employeeId,date));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost()]

        public async Task<ActionResult<Result<Unit>>> AddEmployeeWazifiElements([FromBody] EmployeeBasicFinancialDataDtos[] EmployeeBasicFinancialData)
        {

            var result = await Mediator.Send(new AddEmployeeElementsCommand(EmployeeBasicFinancialData));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }



        [HttpPost("UploadEmployeeWazifiElements")]

        public async Task<ActionResult<Result<Unit>>> UploadEmployeeWazifiElements([FromForm] UploadEmployeeBasicFinicialDataParam param)
        {

            var result = await Mediator.Send(new UploadEmployeeBasicFinicialDataCommand(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

    }
}
/*WAZIFI
 * [
  {
    "id": 0,
    "employeeId": 213,
    "financialDataTypesId": 1002,
    "amount": 246
  },

  {
    "id": 0,
    "employeeId": 213,
    "financialDataTypesId": 1003,
    "amount": 246
  },
 {
    "id": 0,
    "employeeId": 213,
    "financialDataTypesId": 1004,
    "amount": 340
  },
 {
    "id": 0,
    "employeeId": 213,
    "financialDataTypesId": 1005,
    "amount": 28.8
  },
 {
    "id": 0,
    "employeeId": 213,
    "financialDataTypesId": 1006,
    "amount": 20
  }
]*/