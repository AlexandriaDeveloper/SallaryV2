using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;
using static Domain.Constants.Constant.Model;

namespace Domain.EmployeeOrders.Commands.PayDeductionEmployee
{

    public record PayDeductionEmployeeCommand(FormEmployeeOrderDto employeeOrder) : ICommand<Unit>;

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

            FormEmployeeOrder FormEmployeeOrder = new FormEmployeeOrder();
         
            FormEmployeeOrder.FormEmployeeOrderExecuations = new List<FormEmployeeOrderExecuation>();
            FormEmployeeOrder.OrderId = request.employeeOrder.OrderId;
            FormEmployeeOrder.CreditOrDebit = request.employeeOrder.CreditOrDebit;
            FormEmployeeOrder.FormEmployeeId = request.employeeOrder.FormEmployeeId;
            FormEmployeeOrder.Details = request.employeeOrder.Details;


            // BudgetItem budgetItem = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.IRADAT);
            foreach (var item in request.employeeOrder.FormEmployeeOrderExecutions)
            {
                if(item.Amount.HasValue || item.Amount.HasValue && item.Amount.Value != 0)
                    FormEmployeeOrder.FormEmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(item.BudgetItemId, item.Amount.Value));
            }
         


            await _uow.FormEmployeeOrderRepository.AddItem(FormEmployeeOrder);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result == Enums.SaveState.Exception)
            {

                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);
        }

        private FormEmployeeOrderExecuation CalculateEmployeeOrderExecuation(int budgetItemId, decimal amount, int? subscriptionId = null)
        {

            FormEmployeeOrderExecuation ex = new FormEmployeeOrderExecuation();
            ex.BudgetItemId = budgetItemId;
            ex.Amount = amount;
            ex.CreatedBy = _authService.GetCurrentLoggedInUser();
            ex.CreatedDate = DateTime.Now;

            return ex;

        }


    }


    public class FormEmployeeOrderDto {
        public string Details  { get; set; }
        public DateTime SelectedDate { get; set; }=DateTime.Now;
        public int FormEmployeeId { get; set; }
       // public int EmployeeOrderId { get; set; }
        public int OrderId { get; set; }
   
        public char CreditOrDebit { get; set; } = 'c';

        public List<FormEmployeeOrderExecution> FormEmployeeOrderExecutions { get; set; }
    }

    public class FormEmployeeOrderExecution
    { 

        public decimal? Amount { get; set; }

        public int BudgetItemId { get; set; }

        public int FormEmployeeOrderId { get; set; }
    }
}

   