using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.EmployeeSubscriptions;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeSubscriptions.Commands.UpdateEmployeeSubscrtiption
{
    public record UpdateEmployeeSubscrtiptionCommand(EmployeeToSubscriptionDto employeeToSubscripe) : ICommand;
    public class UpdateEmployeeSubscrtiptionCommandHandler : ICommandHandler<UpdateEmployeeSubscrtiptionCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateEmployeeSubscrtiptionCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(UpdateEmployeeSubscrtiptionCommand request, CancellationToken cancellationToken)
        {

            EmployeeSubscription employeeToSubscripe = await _uow.EmployeeSubscriptionRepository.GetByIdAsync(request.employeeToSubscripe.Id.Value);
            if (employeeToSubscripe == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var updatedEntity = _mapper.Map<EmployeeToSubscriptionDto, EmployeeSubscription>(request.employeeToSubscripe, employeeToSubscripe);

            await _uow.EmployeeSubscriptionRepository.Update(updatedEntity);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();
        }
    }


    public class UpdateEmployeeSubscrtiptionCommandValidator : AbstractValidator<UpdateEmployeeSubscrtiptionCommand>
    {

        public UpdateEmployeeSubscrtiptionCommandValidator()
        {
            RuleFor(p => p.employeeToSubscripe.Id).NotEmpty().NotNull();
            RuleFor(p => p.employeeToSubscripe.Amount).NotEmpty().NotNull();
            RuleFor(p => p.employeeToSubscripe.SubscriptionId).NotEmpty().NotNull();
            RuleFor(p => p.employeeToSubscripe.EmployeeId).NotEmpty().NotNull();


        }
    }
}
