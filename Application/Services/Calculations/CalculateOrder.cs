using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Domain.Constants;
using Domain.Models;
using MediatR;

namespace Application.Services.Calculations
{
    public class CalculateOrder
    {
        private readonly IReadOnlyList<BudgetItem> _budgetItems;


  

        public CalculateOrder( IReadOnlyList<BudgetItem> budgetItems)
        {
            _budgetItems = budgetItems;

        }



       


        public async Task<List<EmployeeOrderTypeExecuation>> CalculateFixedEmployeeOrder(EmployeeBasicSallaryDataDto empSallary, Order order, DateTime formDate)
        {


            List<EmployeeOrderTypeExecuation> empExec = new List<EmployeeOrderTypeExecuation>();

            if (!empSallary.Amount.HasValue)
            {
                throw new Exception(" يجب ادخال قيمة المبلغ ");
            }
            if (order.Name == Constant.Model.OrderConstants.REPAY)
            {
                BudgetItem? repay = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.ISTRDAD);

                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    Amount = empSallary.Amount.Value,
                    BudgetItemId = repay.Id,
                });
            }
            if (order.Name == Constant.Model.OrderConstants.FIXED_AMOUNT_IRADAT)
            {
                BudgetItem? repay = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.IRADAT);

                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    Amount = empSallary.Amount.Value,
                    BudgetItemId = repay.Id,
                });
            }
            if (order.Name == Constant.Model.OrderConstants.FIXED_AMOUNT_MORTADAT)
            {
                BudgetItem? repay = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.MORTADAT);

                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    Amount = empSallary.Amount.Value,
                    BudgetItemId = repay.Id,
                });
            }
            return empExec;
        }
        public async Task<List<EmployeeOrderTypeExecuation>> CalculateEmployeeOrder(EmployeeBasicSallaryDataDto empSallary, Order order, DateTime formDate)
        {
            int totalMonthWorkingDays = DateTime.DaysInMonth(formDate.Year, formDate.Month);


            List<EmployeeOrderTypeExecuation> empExec = new List<EmployeeOrderTypeExecuation>();
            //عدد ايام الحضور
            if (!empSallary.Quantity.HasValue)
            {
                throw new Exception(" يجب ادخال عدد الايام ");
            }
            var workingDays = totalMonthWorkingDays - empSallary.Quantity.Value;
            //عدد ايام الاجازة خلال الشهر 
            int employeeVacationDays = totalMonthWorkingDays - workingDays;

            //اجازة بدون اذن
            if (order.Name == Constant.Model.OrderConstants.ABSENCE)
            {


                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    BudgetItemId = _budgetItems.Single(x => x.Name == Constant.Model.BudgetItems.WAZIFI).Id,
                    Amount = empSallary.Wazifi * employeeVacationDays / totalMonthWorkingDays,

                });
                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    BudgetItemId = _budgetItems.Single(x => x.Name == Constant.Model.BudgetItems.MOKAMEL).Id,
                    Amount = empSallary.Mokamel * employeeVacationDays / totalMonthWorkingDays
                });
                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    BudgetItemId = _budgetItems.Single(x => x.Name == Constant.Model.BudgetItems.TA3WIDI).Id,
                    Amount = empSallary.Taawidi * employeeVacationDays / totalMonthWorkingDays
                });


                //empSallary.Wazifi = empSallary.Wazifi * workingDays / totalMonthWorkingDays;
                //empSallary.Mokamel = empSallary.Mokamel * workingDays / totalMonthWorkingDays;
                //empSallary.Taawidi = empSallary.Taawidi * workingDays / totalMonthWorkingDays;
            }

            // خصم جزاء عدد ايام 
            if (order.Name == Constant.Model.OrderConstants.PUNISHMENT_ABSENCE)
            {

                empExec.Add(new EmployeeOrderTypeExecuation()
                {
                    BudgetItemId = _budgetItems.Single(x => x.Name == Constant.Model.BudgetItems.WAZIFI).Id,
                    Amount = empSallary.Wazifi * employeeVacationDays / totalMonthWorkingDays
                });
                // empSallary.Wazifi = empSallary.Wazifi * workingDays / totalMonthWorkingDays;

            }

            return empExec;

        }

       

  


    }




    public class EmployeeBasicSallaryDataDto
    {

        public decimal Wazifi { get; set; }
        public decimal Mokamel { get; set; }
        public decimal Taawidi { get; set; }


        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public bool Skip { get; set; } = false;

    }
}
