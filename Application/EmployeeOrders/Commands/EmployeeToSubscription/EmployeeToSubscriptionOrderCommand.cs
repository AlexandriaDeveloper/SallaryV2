using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Commands.EmployeeToSubscription
{

    public record EmployeeToSubscriptionOrderCommand(int subscriptionId, int orderFileId) : ICommand<Unit>;
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
            //if (!await _uow.FormRepository.CheckExistAsync(request.subscriptionId))
            //{
            //    return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            //}
            var order = await _uow.OrderRepository.GetByNameAsync(Constant.Model.OrderConstants.SUBSCRIPTIONS);
            var budget = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.SUBSCRIPTIONS);

            if (order == null || budget == null)
            {
                Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }
            var employeesInSubscription = await _uow.EmployeeSubscriptionRepository.GetEmployeeSubscriptionBySubscriptionId(request.subscriptionId);

            foreach (var employee in employeesInSubscription)
            {
                var employeeOrder = new Domain.Models.EmployeeOrder()
                {

                    EmployeeId = employee.Id,
                    CreatedDate = DateTime.Now,
                    CreatedBy = _authService.GetCurrentLoggedInUser(),
                    OrderId = order.Id,
                    OrderFileId = request.orderFileId,
                    CreditOrDebit = 'd',
                    // PeriodicSubscriptions = new List<PeriodicSubscription>()


                };
                //employeeOrder.PeriodicSubscriptions = new List<PeriodicSubscription>
                //{
                //    new PeriodicSubscription()
                //    {

                //        Amount = employee.Amount,
                //        SubscriptionId = employee.SubscriptionId,
                //        CreatedDate = DateTime.Now,
                //        CreatedBy = _authService.GetCurrentLoggedInUser()
                //    }
                //};

                await _uow.EmployeeOrderRepository.AddItem(employeeOrder);

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
