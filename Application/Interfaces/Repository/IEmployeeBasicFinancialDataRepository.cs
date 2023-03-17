using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeBasicFinancialDataRepository : IRepository<EmployeeBasicFinancialData>
    {
        // void AddItem(Domain.Models.EmployeeBasicFinancialData employeeBasicFinancialData);
     Task<   List<EmployeeBasicFinancialData>> GetEmployeeDataWithSpecificDate(int employeeId, DateTime? date);
    }
}
