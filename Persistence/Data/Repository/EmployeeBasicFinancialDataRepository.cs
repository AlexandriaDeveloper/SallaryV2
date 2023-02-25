using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Data.Repository
{
    public class EmployeeBasicFinancialDataRepository : Repository<EmployeeBasicFinancialData>, IEmployeeBasicFinancialDataRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeBasicFinancialDataRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }


        public List<EmployeeBasicFinancialData> GetEmployeeDataWithSpecificDate(int employeeId, DateTime? date) { 
        
            if(date.HasValue)
            {

                return _context.EmployeeBasicFinancialData.Include(x => x.FinancialDataTypes).Where( t => t.FinancialDataTypes.ReservationDate<= date.Value && t.EmployeeId==employeeId).ToList();
            }
            return _context.EmployeeBasicFinancialData.Include(x => x.FinancialDataTypes).Where(t =>  t.EmployeeId == employeeId).ToList();
        }
    }
}
