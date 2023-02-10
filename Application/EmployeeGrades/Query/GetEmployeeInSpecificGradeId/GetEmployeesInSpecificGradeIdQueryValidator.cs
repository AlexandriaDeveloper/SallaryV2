using FluentValidation;

namespace Domain.EmployeeGrades.Query.GetEmployeeInSpecificGradeId
{
    public class GetEmployeesInSpecificGradeIdQueryValidator : AbstractValidator<GetEmployeesInSpecificGradeIdQuery>
    {
        public GetEmployeesInSpecificGradeIdQueryValidator()
        {

            RuleFor(x => x.gradeId).NotEmpty().NotNull();
        }

    }
}
