using Application.Common.Messaging;

using Application.PeriodicSubscriptions.Commands.EmployeePaySubscription;
using AutoMapper;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Commands.EmployeePaySubscription
{
    public record EmployeePaySubscriptionCommand(FormEmployeeSubscriptionDto PeriodicSubscriptionDto) : ICommand;
    public class EmployeePaySubscriptionCommandHandler : ICommandHandler<EmployeePaySubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public EmployeePaySubscriptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(EmployeePaySubscriptionCommand request, CancellationToken cancellationToken)
        {
            FormEmployeeSubscription subscription = _mapper.Map<FormEmployeeSubscription>(request.PeriodicSubscriptionDto);
            subscription.CreditOrDebit = 'c';
            await _uow.FormEmployeeSubscriptionRepository.AddItem(subscription);

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();

        }
    }
}
public class EmployeePaySubscriptionCommandValidator : AbstractValidator<EmployeePaySubscriptionCommand>
{
    public EmployeePaySubscriptionCommandValidator()
    {
        RuleFor(p => p.PeriodicSubscriptionDto.Amount).NotEmpty();
        RuleFor(p => p.PeriodicSubscriptionDto.FormEmployeeId).NotEmpty();
       // RuleFor(p => p.PeriodicSubscriptionDto.EmployeeId).NotEmpty();
        RuleFor(p => p.PeriodicSubscriptionDto.SubscriptionId).NotEmpty();
    }
}

public class FormEmployeeSubscriptionDto
{
    public int? Id { get; set; }
    public int SubscriptionId { get; set; }
    public int FormEmployeeId { get; set; }
    //public int EmployeeId { get; set; }
    //public int FormId { get; set; }
    public decimal Amount { get; set; }

}
