using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Calculations
{
    public class RoundEmployeeSallary
    {

        public EmployeeBasicSallaryDataDto RoundEmployeeReturn(EmployeeBasicSallaryDataDto empData)
        {

            empData.Wazifi = Math.Round(empData.Wazifi, 2);
            empData.Mokamel = Math.Round(empData.Mokamel, 2);
            empData.Taawidi = Math.Round(empData.Taawidi, 2);
            return empData;
        }
    }
}
