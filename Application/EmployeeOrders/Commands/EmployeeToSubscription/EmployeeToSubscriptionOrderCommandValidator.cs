using FluentValidation;

namespace Domain.EmployeeOrders.Commands.EmployeeToSubscription
{
    public class EmployeeToSubscriptionOrderCommandValidator : AbstractValidator<EmployeeToSubscriptionOrderCommand>
    {
        public EmployeeToSubscriptionOrderCommandValidator()
        {
            RuleFor(p => p.subscriptionId).NotNull().NotEmpty();
            RuleFor(p => p.formId).NotNull().NotEmpty();
        }
    }
}
