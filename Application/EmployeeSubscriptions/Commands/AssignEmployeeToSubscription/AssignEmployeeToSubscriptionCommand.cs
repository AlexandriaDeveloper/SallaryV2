using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;
namespace Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription
{
    public record AssignEmployeeToSubscriptionCommand(EmployeeToSubscriptionDto employeeSubscriptionModel) : ICommand<Unit>;

    public class AssignEmployeeToSubscriptionCommandHandler : ICommandHandler<AssignEmployeeToSubscriptionCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public AssignEmployeeToSubscriptionCommandHandler(IUOW uow, IMapper mapper, IAuthService authService)
        {
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<Result<Unit>> Handle(AssignEmployeeToSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var employeeSubscripToDb = _mapper.Map<EmployeeSubscription>(request.employeeSubscriptionModel);

            await _uow.EmployeeSubscriptionRepository.AddItem(employeeSubscripToDb);

            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result != Enums.SaveState.Saved)
            {
                return Result<Unit>.Failure(result);
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
