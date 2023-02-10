using FluentValidation;

namespace Application.Subscriptions.Commands.AddSubscription
{
    public class AddSubscriptionCommandValidator : AbstractValidator<AddSubscriptionCommand>
    {
        public AddSubscriptionCommandValidator()
        {
            RuleFor(x => x.Subscription.Name).NotEmpty();
        }
    }
}
