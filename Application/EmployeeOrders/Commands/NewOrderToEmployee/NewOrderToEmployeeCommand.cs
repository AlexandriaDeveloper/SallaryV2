using Application.Common.Messaging;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Commands.NewOrderToEmployee
{
    public record NewEmployeeOrderCommand(EmployeeOrderDto employeeOrder) : ICommand<Unit>;
    public class NewEmployeeOrderCommandHandler : ICommandHandler<NewEmployeeOrderCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public NewEmployeeOrderCommandHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            _authService = authService;
        }

        public async Task<Result<Unit>> Handle(NewEmployeeOrderCommand request, CancellationToken cancellationToken)
        {
            EmployeeBasicSallary? employeeSallary = await _uow.EmployeeBasicSallaryRepository.GetEmployeeBasicSallaryByFinancialIdAsync(request.employeeOrder.EmployeeId, request.employeeOrder.FinancialYearId);
        
            Form form = await _uow.FormRepository.GetByIdAsync(request.employeeOrder.FormId);



            decimal? wazifi = employeeSallary.Wazifi;
            decimal? ta3widi = employeeSallary.Taawidi;
            decimal? mokamel = employeeSallary.Mokamel;

            var formDate = DateTime.Parse(form.FormDate);
            int daysInMonth = DateTime.DaysInMonth(formDate.Year, formDate.Month);
            int numberOfMonths = 1;
            if (employeeSallary == null)
            {
                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }

            //check if Employee Is Part Time And Calculat Data Depend On That
            var employeeIsInPartTime = await _uow.EmployeePartTimeRepository.IsEmployeeInPartTime(request.employeeOrder.EmployeeId);
            if (employeeIsInPartTime.HasValue && employeeIsInPartTime.Value == true)
            {

                wazifi = Math.Round(wazifi.Value * 65 / 100, 2);
                mokamel = Math.Round(mokamel.Value * 65 / 100, 2);
                ta3widi = Math.Round(ta3widi.Value * 65 / 100, 2);
            }
            //Get Order Type
            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {
                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }
            // Assign Order To Employee
            EmployeeOrder employeeOrder = new EmployeeOrder();
            employeeOrder.EmployeeOrderExecuations = new List<EmployeeOrderExecuation>();
            employeeOrder.OrderNumber = request.employeeOrder.OrderNumber;
            employeeOrder.FormId= request.employeeOrder.FormId;
            employeeOrder.EmployeeId = request.employeeOrder.EmployeeId;
            employeeOrder.OrderId = request.employeeOrder.OrderId;
            employeeOrder.OrderFileId = request.employeeOrder.OrderFileId;
            employeeOrder.Quantity = request.employeeOrder.Quantity;
            employeeOrder.Details = request.employeeOrder.Details;
            employeeOrder.CreditOrDebit = request.employeeOrder.CreditOrDepit;
            employeeOrder.CreatedDate = DateTime.Now;
            employeeOrder.CreatedBy = _authService.GetCurrentLoggedInUser();

            // If Order Have Limited Duration
            // Clcualt number of days 
            //Calculat Total Months Days in case Order Contain MOre Than 1 Month 
            //

            if (request.employeeOrder.StartFrom.HasValue && request.employeeOrder.EndAt.HasValue)
            {

                employeeOrder.StartFrom = request.employeeOrder.StartFrom;
                employeeOrder.EndAt = request.employeeOrder.EndAt;

                DateTime startDate = request.employeeOrder.StartFrom.Value;
                DateTime endDate = request.employeeOrder.EndAt.Value;

                employeeOrder.Quantity = (endDate - startDate).Days + 1;
                request.employeeOrder.Quantity = employeeOrder.Quantity.Value;


                daysInMonth =
                    (new DateTime(endDate.Year, endDate.Month, DateTime.DaysInMonth(endDate.Year, endDate.Month))
                    - new DateTime(startDate.Year, startDate.Month, 1)).Days;

                if(daysInMonth> 30)
                {
                    numberOfMonths = daysInMonth / 30;
                }

               

            }

            // Clculat Sallary Logic depend on Order

            if (order.Name == Constant.Model.OrderConstants.ABSENCE || order.Name == Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY)
            {

                BudgetItem? wazifiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.WAZIFI);
                var WazifiAmount = Math.Round(wazifi.Value * numberOfMonths * request.employeeOrder.Quantity.Value / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(wazifiEntity.Id, WazifiAmount));


                BudgetItem? mokamelEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.MOKAMEL);
                decimal MokamelAmount = Math.Round(mokamel.Value * numberOfMonths * request.employeeOrder.Quantity.Value / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(mokamelEntity.Id, MokamelAmount));


                BudgetItem? TaawidiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.TA3WIDI);
                decimal TaawidiAmount = Math.Round(ta3widi.Value * numberOfMonths * request.employeeOrder.Quantity.Value / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(TaawidiEntity.Id, TaawidiAmount));

            }
            if (order.Name == Constant.Model.OrderConstants.PUNISHMENT_ABSENCE)
            {

                BudgetItem? wazifiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.WAZIFI);
                var WazifiAmount = Math.Round(wazifi.Value * numberOfMonths * request.employeeOrder.Quantity.Value / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(wazifiEntity.Id, WazifiAmount));

            }
            if (order.Name == Constant.Model.OrderConstants.REPAY && request.employeeOrder.Amount.HasValue)
            {
                BudgetItem? repay = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.REPAY);
                employeeOrder.CreditOrDebit = 'd';
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(repay.Id, request.employeeOrder.Amount.Value));

            }

            if (order.Name == Constant.Model.OrderConstants.FIXED_AMOUNT && request.employeeOrder.Amount.HasValue)
            {
                BudgetItem? repay = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.DEDUCTION);
                employeeOrder.CreditOrDebit = 'd';
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(repay.Id, request.employeeOrder.Amount.Value));

            }


            await _uow.EmployeeOrderRepository.AddItem(employeeOrder);



            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result == SaveState.Exception)
            {
                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);



        }




        private EmployeeOrderExecuation CalculateEmployeeOrderExecuation(int budgetItemId, decimal amount)
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
