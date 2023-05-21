using Domain.Constants;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Calculations
{
    public class CalculateVacataion
    {
        private readonly IReadOnlyList<BudgetItem> _budgetItems;

        public CalculateVacataion(IReadOnlyList<BudgetItem> budgetItems)
        {
            _budgetItems = budgetItems;
        }

        public async Task<List<EmployeeVacationExecuation>> CalculateVacation(EmployeeBasicSallaryDataDto empData, FormEmployeeVacation employeeVcationType, DateTime formDate)
        {

            int totalMonthWorkingDays = DateTime.DaysInMonth(formDate.Year, formDate.Month);
            //عدد ايام الحضور
            CalculateWorkingDays calculateWorkingDays= new CalculateWorkingDays();
            var workingDays = calculateWorkingDays.CaluctaeWorkingDays(formDate, employeeVcationType);
            //عدد ايام الاجازة خلال الشهر 
            int employeeVacationDays = totalMonthWorkingDays - workingDays;


            if (employeeVcationType.StartAt > new DateTime(formDate.Year, formDate.Month, totalMonthWorkingDays)) {
                return default;
            }

            EmployeeBasicSallaryDataDto empSallaryDataToReturn = new EmployeeBasicSallaryDataDto();

            if (employeeVcationType.Vacation.Name == Constant.Model.VacationTypesConstraint.INTADAB_KOLI)
            {
                empSallaryDataToReturn.Wazifi = (empData.Wazifi * (employeeVacationDays / totalMonthWorkingDays));
                empSallaryDataToReturn.Mokamel = (empData.Mokamel * (employeeVacationDays / totalMonthWorkingDays));
                empSallaryDataToReturn.Taawidi = (empData.Taawidi * (employeeVacationDays / totalMonthWorkingDays));
            }


            if (employeeVcationType.Vacation.Name == Constant.Model.VacationTypesConstraint.INTADAB_GOZ2I)
            {
                if (employeeVcationType.StartAt > formDate)
                {
                    //تم التنفيذ فى نفس الشهر 
                    empSallaryDataToReturn.Mokamel += (empData.Mokamel * (workingDays) / totalMonthWorkingDays);


                    //باقى استحقاق الشهر 
                    empSallaryDataToReturn.Mokamel += (empData.Mokamel * employeeVacationDays / totalMonthWorkingDays)
                        * employeeVcationType.Qunatity.Value / 30;
                }
                else
                {

                    empSallaryDataToReturn.Mokamel += (empData.Mokamel * workingDays / totalMonthWorkingDays)
                        * employeeVcationType.Qunatity.Value / 30;

                }
            }

            if (employeeVcationType.Vacation.Name == Constant.Model.VacationTypesConstraint.GOZAA_MN_EL_WAKT)
            {

                empSallaryDataToReturn.Wazifi += (empData.Wazifi * employeeVacationDays / totalMonthWorkingDays) * 35 / 100;
                empSallaryDataToReturn.Mokamel += (empData.Mokamel * employeeVacationDays / totalMonthWorkingDays) * .35m;
                empSallaryDataToReturn.Taawidi += (empData.Taawidi * employeeVacationDays / totalMonthWorkingDays) * .35m;

            }
            if (employeeVcationType.Vacation.Name == Constant.Model.VacationTypesConstraint.AGAZA_BEDON_MORATAB)
            {

                //تم التنفيذ فى نفس الشهر 
                empSallaryDataToReturn.Wazifi += (empData.Wazifi * employeeVacationDays / totalMonthWorkingDays);
                empSallaryDataToReturn.Mokamel += (empData.Mokamel * employeeVacationDays / totalMonthWorkingDays);
                empSallaryDataToReturn.Taawidi += (empData.Taawidi * employeeVacationDays / totalMonthWorkingDays);


            }

            RoundEmployeeSallary empSallary = new RoundEmployeeSallary();
          empSallaryDataToReturn=  empSallary.RoundEmployeeReturn(empSallaryDataToReturn);

             List <EmployeeVacationExecuation > empVacationsExec = new List<EmployeeVacationExecuation>();

            if (empSallaryDataToReturn.Wazifi >0) {
                empVacationsExec.Add(new EmployeeVacationExecuation()
                {
                    FormEmployeeVacationId= employeeVcationType.Id,
                    BudgetItemId = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.WAZIFI).Id,
                    Amount= empSallaryDataToReturn.Wazifi

                });
            }
            if (empSallaryDataToReturn.Mokamel > 0)
            {
                empVacationsExec.Add(new EmployeeVacationExecuation()
                {
                    FormEmployeeVacationId = employeeVcationType.Id,
                    BudgetItemId = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.MOKAMEL).Id,
                    Amount = empSallaryDataToReturn.Mokamel

                });
            }
            if (empSallaryDataToReturn.Taawidi > 0)
            {
                empVacationsExec.Add(new EmployeeVacationExecuation()
                {
                    FormEmployeeVacationId = employeeVcationType.Id,
                    BudgetItemId = _budgetItems.SingleOrDefault(x => x.Name == Constant.Model.BudgetItems.TA3WIDI).Id,
                    Amount = empSallaryDataToReturn.Taawidi

                });
            }

            return empVacationsExec;
        }
    }
}
