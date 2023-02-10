using FluentValidation;

namespace Application.EmployeePartTimes.Commands.EmployeeStratPartTime
{
    public class EmployeeStartPartTimeCommandValidator : AbstractValidator<EmployeeStartPartTimeCommand>
    {
        public EmployeeStartPartTimeCommandValidator()
        {
            RuleFor(p => p.employeePartTime.EmployeeId).NotNull().NotEmpty().WithMessage("يجب ادخال كود الموظف");
            RuleFor(p => p.employeePartTime.StartFrom).NotNull().NotEmpty().WithMessage("يجب ادخال تاريح بدء جزء من الوقت");
        }
    }
}
