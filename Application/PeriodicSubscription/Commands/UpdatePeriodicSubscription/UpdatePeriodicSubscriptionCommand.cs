using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.PeriodicSubscriptions.Commands.UpdatePeriodicSubscription
{
    public record UpdatePeriodicSubscriptionCommand(FormEmployeeSubscriptionDto model) : ICommand;
    public class UpdatePeriodicSubscriptionCommandHandler : ICommandHandler<UpdatePeriodicSubscriptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdatePeriodicSubscriptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(UpdatePeriodicSubscriptionCommand request, CancellationToken cancellationToken)
        {
            FormEmployeeSubscription periodicSubscription = await _uow.FormEmployeeSubscriptionRepository.GetByIdAsync(request.model.Id.Value);
            if (periodicSubscription == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            FormEmployeeSubscription periodicSubscriptionDto = _mapper.Map<FormEmployeeSubscriptionDto, FormEmployeeSubscription>(request.model, periodicSubscription);
            await _uow.FormEmployeeSubscriptionRepository.Update(periodicSubscriptionDto);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {

                return Result.Failure(result);
            }

            return Result.Success();

        }
    }

    public class UpdatePeriodicSubscriptionCommandValidator : AbstractValidator<UpdatePeriodicSubscriptionCommand>
    {
        public UpdatePeriodicSubscriptionCommandValidator()
        {
            RuleFor(p => p.model.Id).NotNull().NotEmpty();
            RuleFor(p => p.model.Amount).NotNull().NotEmpty();
            RuleFor(p => p.model.FormEmployeeId).NotNull().NotEmpty();
            RuleFor(p => p.model.SubscriptionId).NotNull().NotEmpty();
            //RuleFor(p => p.model.FormId).NotNull().NotEmpty();

        }
    }
}
