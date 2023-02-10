using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.Interfaces.Repository
{
    public interface IEmployeePartTimeRepository : IRepository<EmployeePartTime>
    {

        Task<bool?> IsEmployeeInPartTime(int employeeId);
        Task<Result<int>> EmployeeStartPartTime(EmployeePartTime employeePartTime);
        Task<EmployeePartTime> EmployeeEndPartTime(int partTimeId, DateTime endDate);
        Task<EmployeePartTime?> GetCurrentEmployeeInPartTimeByEmployeeId(int employeeId);

    }
}
