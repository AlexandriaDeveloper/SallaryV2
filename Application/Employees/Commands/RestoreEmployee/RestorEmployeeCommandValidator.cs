using FluentValidation;

namespace Domain.Employees.Commands.RestoreEmployee
{
    public class RestorEmployeeCommandValidator : AbstractValidator<RestorEmployeeCommand>
    {
        public RestorEmployeeCommandValidator()
        {
            RuleFor(p => p.id)
                .NotEmpty().NotNull().WithMessage("يجب ادخال كود");
        }
    }
}
