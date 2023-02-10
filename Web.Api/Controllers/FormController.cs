using Application.Form;
using Application.Form.Commands.CreateForm;
using Application.Form.Commands.DeleteForm;
using Application.Form.Queries.FormList;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class FormController : BaseController
    {
        public FormController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet]
        public async Task<ActionResult<Result<Unit>>> GetForms([FromQuery] FormListQueryParam formparam)
        {

            var result = await Mediator.Send(new FormListQuery(formparam));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }

            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> CreateForm([FromBody] FormDto form)
        {

            var result = await Mediator.Send(new CreateFormCommand(form));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Result<Unit>>> DeleteForm(int id)
        {

            var result = await Mediator.Send(new DeleteFormCommand(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
