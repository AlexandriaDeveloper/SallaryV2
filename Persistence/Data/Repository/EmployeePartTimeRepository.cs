using Application.Interfaces.Repository;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeePartTimeRepository : Repository<EmployeePartTime>, IEmployeePartTimeRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeePartTimeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }

        public async Task<EmployeePartTime?> EmployeeEndPartTime(int partTimeId, DateTime endDate)
        {
            EmployeePartTime? result = await _context.EmployeesPartTimes.FindAsync(partTimeId);
            if (result == null)
            {
                return null;
            }
            result.EndAt = endDate;
            result.ModifiedBy = _authService.GetCurrentLoggedInUser();
            result.ModifiedDate = DateTime.Now;
            return result;

        }

        public async Task<Result<int>> EmployeeStartPartTime(EmployeePartTime employeePartTime)
        {

            var employee = _context.Employees.Include(x => x.PartTimeDurations).SingleOrDefault(x => x.Id == employeePartTime.EmployeeId);
            if (employee == null)
            {

                return Result<int>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST); ;
            }
            if (employee.PartTimeDurations == null)
            {
                employee.PartTimeDurations = new List<EmployeePartTime>();
            }
            if (employee.PartTimeDurations.Any(x => x.IsPartTimeActive))
            {

                return Result<int>.Failure(new Error("", "Employee Alredy In PartTime"));
            }

            EmployeePartTime createdEmployeePartTime = new EmployeePartTime()
            {
                Employee = employee,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = _authService.GetCurrentLoggedInUser(),
                Details = employeePartTime.Details,
                StartFrom = employeePartTime.StartFrom
            };
            employee.PartTimeDurations.Add(createdEmployeePartTime);
            await _context.SaveChangesAsync();

            return Result<int?>.Success(createdEmployeePartTime.Id);
        }

        public async Task<bool?> IsEmployeeInPartTime(int employeeId)
        {
            var result = await _context.EmployeesPartTimes.Where(x => x.EmployeeId == employeeId).ToListAsync();
            if (result == null)
            {
                return false;
            }
            if (result.Any(x => x.IsPartTimeActive))
            {

                return true;
            }


            return false;

        }

        public async Task<EmployeePartTime?> GetCurrentEmployeeInPartTimeByEmployeeId(int employeeId)
        {
            return await _context.EmployeesPartTimes.Where(x => x.EmployeeId == employeeId).FirstOrDefaultAsync(x => x.EndAt == null);


        }
    }
}
