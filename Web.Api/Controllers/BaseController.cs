using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {

        protected readonly IMediator Mediator;

        protected BaseController(IMediator mediator) => Mediator = mediator;


        protected ActionResult HandleFailureResult(Result result)
       => result switch
       {
           { IsSuccess: true } => throw new InvalidOperationException(),
           { Error.Code: "Not Found" } => NotFound(CreateProblemDetails(
                       "Not Found Error", StatusCodes.Status404NotFound,
                       result.Error
                       )),
           { Error.Code: "Dublication" } => BadRequest(CreateProblemDetails(
                    "Dublication", StatusCodes.Status400BadRequest,
                    result.Error
                    )),
           IValidationResult validationResult =>
               BadRequest(
                   CreateProblemDetails(
                       "Validation Error", StatusCodes.Status400BadRequest,
                       result.Error,
                       validationResult.Errors)),
           _ =>
               BadRequest(
                   CreateProblemDetails(
                       "Bad Request",
                       StatusCodes.Status400BadRequest,
                       result.Error))
       };

        private static ProblemDetails CreateProblemDetails(
      string title,
      int status,
      Error error,
      Error[]? errors = null) =>
      new()
      {
          Title = title,
          Type = error.Code,
          Detail = error.Message,
          Status = status,
          Extensions = { { nameof(errors), errors } }
      };
    }
}