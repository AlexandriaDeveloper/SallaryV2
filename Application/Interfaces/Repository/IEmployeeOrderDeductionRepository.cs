using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeBalanceRepository : IRepository<EmployeeOrder>
    {

        List<EmployeeTotalOrderDeductionDto> GetEmployeeDeductionOrders(int employeeId);
        Task<List<EmployeeOrder>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId);

    }
}
