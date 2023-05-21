using Application.Form.Commands.CreateForm;
using Application.Form;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.JobRunners.Command.ExecuteJobRunner;

namespace Web.Api.Controllers
{

    public class JobRunnerController : BaseController
    {
        public JobRunnerController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> CreateForm([FromQuery] int formId)
        {

            var result = await Mediator.Send(new ExecuteJobRunnerCommand(formId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
    }
}
