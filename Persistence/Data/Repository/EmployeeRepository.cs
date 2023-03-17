using Application.Interfaces.Repository;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }


        // public async Task<Result<int>> EmployeeStartPartTimeDuration(int employeeId, DateTime startDate, string? details)
        //{

        // Result<int?> response = new Result<int?>();

        //var employee = _context.Employees.Include(x => x.PartTimeDurations).SingleOrDefault(x => x.Id == employeeId);
        //if (employee == null)
        //{
        //    return Result<int>.Failure(new Error("", "Employee Not Found"));

        //}
        //if (employee.PartTimeDurations == null)
        //{
        //    employee.PartTimeDurations = new List<EmployeePartTime>();
        //}
        //if (employee.PartTimeDurations.Any(x => x.IsPartTimeActive))
        //{
        //    return Result<int>.Failure(new Error("", "Employee Alredy In PartTime"));

        //}

        //EmployeePartTime createdEmployeePartTime = new EmployeePartTime()
        //{
        //    Employee = employee,
        //    CreatedDate = DateTime.UtcNow,
        //    CreatedBy = _authService.GetCurrentLoggedInUser(),
        //    Details = details,
        //    StartFrom = startDate
        //};
        //employee.PartTimeDurations.Add(createdEmployeePartTime);
        //await _context.SaveChangesAsync();

        //return Result<int>.Success(createdEmployeePartTime.Id);
        //   return 0;
        //}


        //public async Task EmployeeEndtPartTimeDuration(int partTimeId, DateTime endDate, string? details)
        //{

        //    var existPartTime = await _context.EmployeesPartTimes.FindAsync(partTimeId);
        //    if (existPartTime == null)
        //    {
        //        throw new Exception("Not Found");
        //    }

        //    existPartTime.EndAt = endDate;

        //    if (string.IsNullOrEmpty(details))
        //    {
        //        existPartTime.Details = details;
        //    }

        //    existPartTime.ModifiedBy = _authService.GetCurrentLoggedInUser();
        //    existPartTime.ModifiedDate = DateTime.UtcNow;


        //    _context.EmployeesPartTimes.Update(existPartTime);
        //    await _context.SaveChangesAsync();
        //}
        public async Task EmployeeAddBankAccount(int employeeId, EmployeeBank employeeBank)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee == null)
            {
                throw new Exception("Not Found");
            }
            employee.EmployeeBank = employeeBank;


        }
        public async Task EmployeeRemoveBankAccount(Employee employee)
        {
            if (employee == null)
            {
                throw new Exception("Not Found");
            }
            _context.EmployeeBanks.Remove(employee.EmployeeBank);


        }


    }


}
//YL2PXXTJPB