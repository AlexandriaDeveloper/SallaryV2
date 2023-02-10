using FluentValidation;

namespace Domain.EmployeeGrades.Query.GetEmployeeCurrentGrade
{
    public class GetEmployeeCurrentGradeQueryHandlerValidator : AbstractValidator<GetEmployeeCurrentGradeQuery>
    {
        public GetEmployeeCurrentGradeQueryHandlerValidator()
        {

            RuleFor(x => x.employeeId).NotEmpty().NotNull();
        }

    }
}
