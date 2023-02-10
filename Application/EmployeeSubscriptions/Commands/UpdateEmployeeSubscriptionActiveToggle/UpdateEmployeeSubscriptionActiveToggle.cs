using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeeSubscriptions.Commands.UpdateEmployeeSubscriptionActiveToggle
{
    public record UpdateEmployeeSubscriptionActiveToggleCommand(int employeeSubscriptionId) : ICommand<bool>;
    public class UpdateEmployeeSubscriptionActiveToggleCommandHandler : ICommandHandler<UpdateEmployeeSubscriptionActiveToggleCommand, bool>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateEmployeeSubscriptionActiveToggleCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<bool>> Handle(UpdateEmployeeSubscriptionActiveToggleCommand request, CancellationToken cancellationToken)
        {
            var employeeSubscription = await _uow.EmployeeSubscriptionRepository.GetByIdAsync(request.employeeSubscriptionId);
            if (employeeSubscription == null)
            {
                return Result<bool>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            employeeSubscription.IsActive = !employeeSubscription.IsActive;
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result<bool>.Failure(result);
            }
            return Result<bool>.Success(employeeSubscription.IsActive);

        }


    }
}
