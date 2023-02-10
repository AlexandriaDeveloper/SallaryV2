using FluentValidation;

namespace Application.EmployeeBankAccount.Commands.EmployeeAddBankAccount
{
    public class EmployeeAddBankAccountCommandValidator : AbstractValidator<EmployeeAddBankAccountCommand>

    {
        public EmployeeAddBankAccountCommandValidator()
        {
            RuleFor(p => p.employeeAccount.BranchId).NotEmpty().NotNull();
            RuleFor(p => p.employeeAccount.EmployeeId).NotEmpty().NotNull();
            RuleFor(p => p.employeeAccount.AccountNumber).NotEmpty().NotNull();
        }
    }
}
