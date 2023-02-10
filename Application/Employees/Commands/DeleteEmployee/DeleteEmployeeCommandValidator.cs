using FluentValidation;

namespace Domain.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandValidator : AbstractValidator<DeleteEmployeeCommand>
    {

        public DeleteEmployeeCommandValidator()
        {
            RuleFor(p => p.id)
            .NotEmpty().WithMessage("يجب ادخال كود الموظف")
            .NotNull().WithMessage("يجب ادخال كود الموظف");
        }
    }
}
