using FluentValidation;

namespace Application.EmployeePartTimes.Commands.EmployeeEndPartTime
{
    public class EmployeeEndPartTimeCommandValidator : AbstractValidator<EmployeeEndPartTimeCommand>
    {
        public EmployeeEndPartTimeCommandValidator()
        {
            RuleFor(p => p.employeePartTimeDto.Id).NotEmpty().NotNull();
            RuleFor(p => p.employeePartTimeDto.EndAt).NotEmpty().NotNull();
            RuleFor(p => p.employeePartTimeDto.Details).MaximumLength(200);
        }
    }
}
