using FluentValidation;

namespace Domain.EmployeeGrades.Commands.AssignEmployeeToGrade
{
    public partial class AssignEmployeeToGradeCommandHandler
    {
        public class AssignEmployeeToGradeCommandValidator : AbstractValidator<AssignEmployeeToGradeCommand>
        {

            public AssignEmployeeToGradeCommandValidator()
            {
                this.CascadeMode = CascadeMode.StopOnFirstFailure;
                RuleFor(x => x.employeeId).NotEmpty().NotNull();
                RuleFor(x => x.gradeId).NotEmpty().NotNull();
                RuleFor(x => x.assignDate).NotEmpty().NotNull();
            }
        }
    }
}
