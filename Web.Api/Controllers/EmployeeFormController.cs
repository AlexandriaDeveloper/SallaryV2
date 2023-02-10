using Application.EmployeeCollections.Commands.UpdateEmployeeRowOrder;
using Application.EmployeesForm;
using Application.EmployeesForm.Commands;
using Application.EmployeesForm.Commands.AddEmploueeSubscriptionToForm;
using Application.EmployeesForm.Commands.AddEmployeesToFormFromCollections;
using Application.EmployeesForm.Commands.AddEmployeeToForm;
using Application.EmployeesForm.Commands.DeleteSubscriptionElement;
using Application.EmployeesForm.Commands.UploadSubscriptionElement;
using Application.EmployeesForm.Queries.CheckEmployeeInFormByFormId;
using Application.EmployeesForm.Queries.GetCheckedSubscriptionByFormId;
using Application.EmployeesForm.Queries.GetEmployeeByFormId;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Application.EmployeesForm.Queries.GetEmployeeByFormId.GetEmployeeByFormIdQuerySpec;

namespace Web.Api.Controllers
{
    public class EmployeeFormController : BaseController
    {
        public EmployeeFormController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet()]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeByFormIdQuery([FromQuery] GetEmployeeByFormIdQueryParam param)
        {

            var result = await Mediator.Send(new GetEmployeeByFormIdQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("CheckEmployeeInFormByFormId")]
        public async Task<ActionResult<Result<bool>>> GetEmployeeByFormIdQuery(int employeeId, int formId)
        {

            var result = await Mediator.Send(new CheckEmployeeInFormByFormIdQuery(formId, employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        //CheckEmployeeInFormByFormIdQuery

        [HttpPost()]
        public async Task<ActionResult<Result<Unit>>> AddEmployeesToFormFromCollections([FromBody] EmployeeFormParam param)
        {

            var result = await Mediator.Send(new AddEmployeesToFormFromCollectionsCommand(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpPost("AddEmployeeToForm")]
        public async Task<ActionResult<Result<Unit>>> AddEmployeeToForm([FromBody] AddEmployeeToFormParam param)
        {

            var result = await Mediator.Send(new AddEmployeeToFormCommand(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        //UpdateEmployeeFormRowOrderCommandHandler

        [HttpPut("reorderRows")]
        public async Task<ActionResult<Result<Unit>>> ReorderRows([FromBody] int[] ids)
        {

            var result = await Mediator.Send(new UpdateEmployeeFormRowOrderCommand(ids));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<Unit>>> DeleteEmployeeFromForm(int id)
        {

            var result = await Mediator.Send(new DeleteEmployeeFromCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        //GetCheckedSubscriptionByFormIdQuery
        [HttpGet("GetCheckedSubscriptionByFormId/{formId}")]
        public async Task<ActionResult<Result<Unit>>> GetCheckedSubscriptionByFormId(int formId)
        {

            var result = await Mediator.Send(new GetCheckedSubscriptionByFormIdQuery(formId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        //AddEmployeeSubscriptionToFormCommand

        [HttpPost("AddEmployeeSubscriptionToForm/{formId}")]
        public async Task<ActionResult<Result<Unit>>> AddEmployeeSubscriptionToForm(int formId, List<GetCheckedSubscriptionByFormIdDto> param)
        {

            var result = await Mediator.Send(new AddEmployeeSubscriptionToFormCommand(formId, param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }


        [HttpPost("UploadEmployeeSubscriptionElement")]
        public async Task<ActionResult<Result<Unit>>> AddEmployeeSubscriptionToForm([FromForm] UploadSubscriptionElementFileDto file)
        {

            var result = await Mediator.Send(new UploadSubscriptionElementCommand(file));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpDelete("DeleteSubscriptionElement/{formId}")]
        public async Task<ActionResult<Result<Unit>>> DeleteSubscriptionElement(int formId, int subscriptionId)
        {

            var result = await Mediator.Send(new DeleteSubscriptionElementCommand(formId, subscriptionId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
