using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Commands.DeletePeriodicSubscription
{
    public record DeletePeriodicSubscriptionCommand(int Id) : ICommand;
    public class DeletePeriodicSubscriptionCommandHandler : ICommandHandler<DeletePeriodicSubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeletePeriodicSubscriptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeletePeriodicSubscriptionCommand request, CancellationToken cancellationToken)
        {
            FormEmployeeSubscription periodicSubscription = await _uow.FormEmployeeSubscriptionRepository.GetByIdAsync(request.Id);
            if (periodicSubscription == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.FormEmployeeSubscriptionRepository.HardDelete(request.Id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }
    public class DeletePeriodicSubscriptionCommandValidator : AbstractValidator<DeletePeriodicSubscriptionCommand>
    {
        public DeletePeriodicSubscriptionCommandValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();

        }
    }
}
