using FluentValidation;

namespace Domain.Employees.Commands.RegisterEmployee
{
    public class RegisterNewEmployeeCommandValidator : AbstractValidator<RegisterNewEmployeeCommand>
    {
        public RegisterNewEmployeeCommandValidator()
        {
            //this.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(p => p.employee.Name)
                .NotEmpty().WithMessage("لا يمكن ترك الخانه فارغه")
                .NotNull()
                .MaximumLength(150);

            RuleFor(p => p.employee.TabCode)
            .NotEmpty()
            .NotNull();


            RuleFor(p => p.employee.NationalId)
            .NotEmpty()
            .NotNull()
            .Length(14).WithMessage("يجب عليك ادخال 14 رقم ");



            RuleFor(p => p)
               .Must(x => x.employee.Name != null && x.employee.NationalId != null).WithMessage("لا يمكن ترك الخليه فارغه");
            RuleFor(p => p.employee.Name)
                .MaximumLength(150).WithMessage("لا يمكن ان يزيد عن 150 حرف");

            RuleFor(p => p.employee.TabCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.employee.TegaraCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.employee.CollageName)
                .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");

            RuleFor(p => p.employee.Section)
              .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");

        }
    }
}
