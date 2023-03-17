using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Calculations
{
    public class CalculateWorkingDays
    {



        public int CaluctaeWorkingDays(DateTime formDate, EmployeeVacationType dateToCalculate)
        {

            int totalWorkingDays = DateTime.DaysInMonth(formDate.Year, formDate.Month);

            DateTime firstDayInMonth = new DateTime(formDate.Year, formDate.Month, 1);
            DateTime lastDayInMonth = new DateTime(formDate.Year, formDate.Month, totalWorkingDays);
            int employeeWorkingDays = 0;


            //مثال احتساب مرتب مايو 
            //ماذا لو الاجازة من 25  ابريل حتى 10 مايو ؟؟؟
            //ماذا لو الاجازة من 5  مايو حتى 10 مايو 
            //ماذا لو الاجازو من 5 مايو حتى 20 يونيو 
            //ماذا لو الاجازة من 10 مارس حتى 20 يونيو 
            if (dateToCalculate.StartAt > firstDayInMonth && dateToCalculate.StartAt < lastDayInMonth.Date)
            {

                employeeWorkingDays += dateToCalculate.StartAt.Day - firstDayInMonth.Day;
            }

            if (dateToCalculate.StartAt <= firstDayInMonth)
            {

                employeeWorkingDays = 0;
            }
            if (dateToCalculate.EndAt.HasValue)
            {
                if (dateToCalculate.EndAt.Value <= lastDayInMonth && dateToCalculate.EndAt.Value >= firstDayInMonth)
                {
                    employeeWorkingDays += lastDayInMonth.Day - dateToCalculate.EndAt.Value.Day;
                }
                if (dateToCalculate.EndAt.Value < firstDayInMonth)
                {
                    employeeWorkingDays += totalWorkingDays;
                }
            }






            return employeeWorkingDays;
        }
    }
}
