using FluentValidation;

namespace Domain.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary
{
    public class UpdateEmployeeBasicSallaryCommandValidator : AbstractValidator<UpdateEmployeeBasicSallaryCommand>
    {
        public UpdateEmployeeBasicSallaryCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(P => P.FinancialYearId).NotEmpty().NotNull();
            RuleFor(P => P.Id).NotEmpty().NotNull();

        }
    }
}
