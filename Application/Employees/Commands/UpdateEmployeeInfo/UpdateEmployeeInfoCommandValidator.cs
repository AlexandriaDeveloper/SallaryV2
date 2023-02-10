using FluentValidation;

namespace Domain.Employees.Commands.UpdateEmployeeInfo
{
    public class UpdateEmployeeInfoCommandValidator : AbstractValidator<EmployeeDto>
    {

        public UpdateEmployeeInfoCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(p => p.Id)
            .NotEmpty().NotNull().WithMessage("الموظف غير موجود");
            RuleFor(p => p)
                .Must(x => x.Name != null && x.NationalId != null).WithMessage("لا يمكن ترك الخليه فارغه");
            RuleFor(p => p.Name)
                .MaximumLength(150).WithMessage("لا يمكن ان يزيد عن 150 حرف");

            RuleFor(p => p.TabCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.TegaraCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.CollageName)
                .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");

            RuleFor(p => p.Section)
              .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");
        }

    }
}
