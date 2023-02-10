using FluentValidation;

namespace Domain.Employees.Queries.GetEmployeeById
{
    public class GetEmployeesByIdQueryValidator : AbstractValidator<GetEmployeesByIdQuery>
    {
        public GetEmployeesByIdQueryValidator()
        {
            //  RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("يجب ادخال كود موظف");
        }
    }
}
