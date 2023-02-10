using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Commands.PayDeductionEmployee
{

    public record PayDeductionEmployeeCommand(EmployeeOrderDeductionDto employeeOrder) : ICommand<Unit>;

    public class PayDeductionEmployeeCommandHandler : ICommandHandler<PayDeductionEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public PayDeductionEmployeeCommandHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            _authService = authService;
        }

        public async Task<Result<Unit>> Handle(PayDeductionEmployeeCommand request, CancellationToken cancellationToken)
        {

            if (request == null || request.employeeOrder == null)
            {
                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }

            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {

                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }

            EmployeeOrder employeeOrderDeduction = new EmployeeOrder();
            employeeOrderDeduction.EmployeeOrderExecuations = new List<EmployeeOrderExecuation>();
            employeeOrderDeduction.OrderId = request.employeeOrder.OrderId;
            employeeOrderDeduction.EmployeeId = request.employeeOrder.EmployeeId;
            employeeOrderDeduction.CreditOrDebit = request.employeeOrder.CreditOrDepit;
            employeeOrderDeduction.FormId = request.employeeOrder.FormId;
            employeeOrderDeduction.Details = request.employeeOrder.Details;


            BudgetItem budgetItem = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.DEDUCTION);

            employeeOrderDeduction.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(budgetItem.Id, request.employeeOrder.Amount));


            await _uow.EmployeeOrderRepository.AddItem(employeeOrderDeduction);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result == Enums.SaveState.Exception)
            {

                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);
        }

        private EmployeeOrderExecuation CalculateEmployeeOrderExecuation(int budgetItemId, decimal amount, int? subscriptionId = null)
        {

            EmployeeOrderExecuation ex = new EmployeeOrderExecuation();
            ex.BudgetItemId = budgetItemId;
            ex.Amount = amount;
            ex.CreatedBy = _authService.GetCurrentLoggedInUser();
            ex.CreatedDate = DateTime.Now;

            return ex;

        }


    }
}
