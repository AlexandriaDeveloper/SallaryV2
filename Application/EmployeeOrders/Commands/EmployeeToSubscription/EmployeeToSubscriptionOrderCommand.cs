using Application.Common.Messaging;
using Domain.Constants;
using Domain.Employees.Queries.GetEmployeeById;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Commands.EmployeeToSubscription
{

    public record EmployeeToSubscriptionOrderCommand(int subscriptionId, int formId) : ICommand<Unit>;
    public class EmployeeToSubscriptionOrderCommandHandler : ICommandHandler<EmployeeToSubscriptionOrderCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public EmployeeToSubscriptionOrderCommandHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            _authService = authService;
        }

        public async Task<Result<Unit>> Handle(EmployeeToSubscriptionOrderCommand request, CancellationToken cancellationToken)
        {
            if (!await _uow.SubscriptionRepository.CheckExistAsync(request.subscriptionId))
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
   
            var employeesInSubscription = await _uow.EmployeeSubscriptionRepository.GetEmployeeSubscriptionBySubscriptionId(request.subscriptionId);

            foreach (var employee in employeesInSubscription)
            {
                var empFormSpec = new GetEmployeesByIdAndFormQuerySpecification(employee.Id, request.formId);
               var empForm = _uow.FormEmployeeRepository.GetBySingleOrDefaultAsync(empFormSpec);
                if (empForm != null)
                {
                    var employeeOrder = new Domain.Models.FormEmployeeSubscription()
                    {
                        SubscriptionId=request.subscriptionId,
                        Amount=employee.Amount,
                        FormEmployeeId = empForm.Id,
                        CreatedDate = DateTime.Now,
                        CreatedBy = _authService.GetCurrentLoggedInUser(),
                        CreditOrDebit='d'
                    
                    };


                    await _uow.FormEmployeeSubscriptionRepository.AddItem(employeeOrder);

                }

              

            }

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Enums.SaveState.Saved)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
