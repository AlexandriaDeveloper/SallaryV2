using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeesForm.Commands.DeleteSubscriptionElement
{
    public record DeleteSubscriptionElementCommand(int formId, int subscriptionId) : ICommand;
    public class DeleteSubscriptionElementCommandHandler : ICommandHandler<DeleteSubscriptionElementCommand>
    {
        private readonly IUOW _uow;

        public DeleteSubscriptionElementCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(DeleteSubscriptionElementCommand request, CancellationToken cancellationToken)
        {
            List<PeriodicSubscription> periodicSubscriptions = await _uow.PeriodicSubscriptionRepository.GetAllByExpressionAsync(x => x.FormId == request.formId && x.SubscriptionId == request.subscriptionId);
            foreach (PeriodicSubscription periodicSubscription in periodicSubscriptions)
            {
                await _uow.PeriodicSubscriptionRepository.HardDelete(periodicSubscription.Id);
            }
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }


        public class DeleteSubscriptionElementCommandValidator : AbstractValidator<DeleteSubscriptionElementCommand>
        {

            public DeleteSubscriptionElementCommandValidator()
            {
                RuleFor(x => x.subscriptionId).NotEmpty();
                RuleFor(x => x.formId).NotEmpty();
            }
        }
    }
}
