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
            List<FormEmployeeSubscription> periodicSubscriptions = await _uow.FormEmployeeSubscriptionRepository
                .GetAllByExpressionAsync(x => x.FormEmployee.FormId == request.formId && x.SubscriptionId == request.subscriptionId);
            foreach (FormEmployeeSubscription periodicSubscription in periodicSubscriptions)
            {
                await _uow.FormEmployeeSubscriptionRepository.HardDelete(periodicSubscription.Id);
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
