using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeBasicSallaryRepository : IRepository<EmployeeBasicSallary>
    {
        Task<EmployeeBasicSallary> EmployeeGetRaise(
           int employeeId,
           int newFinancialYear,
          decimal? wazifiPercentage,
          decimal? wazifiAmount,
          decimal? wazifiMinAmount,
          decimal? wazifiMaxAmount,
          decimal? mokamelPercentage,
          decimal? mokamelAmount,
          decimal? mokamelMinAmount,
          decimal? mokamelMaxAmount
          );
        Task<EmployeeBasicSallary> GetLastEmployeeBasicSallaryAsync(int employeeId);
        Task<EmployeeBasicSallary> GetEmployeeBasicSallaryByFinancialIdAsync(int employeeId, int financialYearId);
    }

}