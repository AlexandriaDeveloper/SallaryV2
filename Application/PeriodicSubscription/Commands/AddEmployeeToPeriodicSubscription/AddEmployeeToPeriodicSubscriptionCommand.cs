using Application.Common.Messaging;
using AutoMapper;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Commands.AddEmployeeToPeriodicSubscription
{
    public record AddEmployeeToPeriodicSubscriptionCommand(PeriodicSubscriptionDto PeriodicSubscription) : ICommand;
    public class AddEmployeeToPeriodicSubscriptionCommandHandler : ICommandHandler<AddEmployeeToPeriodicSubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeeToPeriodicSubscriptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddEmployeeToPeriodicSubscriptionCommand request, CancellationToken cancellationToken)
        {
            PeriodicSubscription periodicSubscriptionToSave = _mapper.Map<PeriodicSubscription>(request.PeriodicSubscription);
            periodicSubscriptionToSave.CreditOrDebit = 'd';
            await _uow.PeriodicSubscriptionRepository.AddItem(periodicSubscriptionToSave);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }

    public class AddEmployeeToPeriodicSubscriptionCommandValidator : AbstractValidator<AddEmployeeToPeriodicSubscriptionCommand>
    {
        public AddEmployeeToPeriodicSubscriptionCommandValidator()
        {
            RuleFor(x => x.PeriodicSubscription.Amount).NotEmpty();
            RuleFor(x => x.PeriodicSubscription.EmployeeId).NotNull().NotEmpty();
            RuleFor(x => x.PeriodicSubscription.FormId).NotNull().NotEmpty();
            RuleFor(x => x.PeriodicSubscription.SubscriptionId).NotNull().NotEmpty();

        }

    }
}
