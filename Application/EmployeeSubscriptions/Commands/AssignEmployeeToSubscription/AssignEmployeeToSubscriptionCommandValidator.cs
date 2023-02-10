using FluentValidation;

namespace Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription
{
    public class AssignEmployeeToSubscriptionCommandValidator : AbstractValidator<EmployeeSubscriptionDto>
    {
        public AssignEmployeeToSubscriptionCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(p => p.EmployeeId).NotNull().NotEmpty();
            RuleFor(p => p.SubscriptionId).NotNull().NotEmpty();
            RuleFor(p => p.Details).MaximumLength(200);
            RuleFor(p => p.Amount).NotNull().NotEmpty();
        }

    }
}
