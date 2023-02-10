using Domain.EmployeeGrades.Commands.AssignEmployeeToGrade;
using Domain.EmployeeGrades.Query.GetEmployeeCurrentGrade;
using Domain.EmployeeGrades.Query.GetEmployeeInSpecificGradeId;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeGradeController : BaseController
    {
        public EmployeeGradeController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetEmployeesInSpecificGradeIdQuery")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeesInSpecificGradeIdQuery(int gradeId)
        {

            var result = await Mediator.Send(new GetEmployeesInSpecificGradeIdQuery(gradeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("GetEmployeeCurrentGrade")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeCurrentGrade(int employeeId)
        {
            var result = await Mediator.Send(new GetEmployeeCurrentGradeQuery(employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost("AssignEmployeeToGrade")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeeToGrade(int employeeId, int gradeId, DateTime assignDate)
        {

            var result = await Mediator.Send(new AssignEmployeeToGradeCommand(employeeId, gradeId, assignDate));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

    }
}
