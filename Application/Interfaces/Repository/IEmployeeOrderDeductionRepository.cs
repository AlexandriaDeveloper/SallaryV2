using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeBalanceRepository : IRepository<FormEmployeeOrder>
    {

        List<EmployeeTotalOrderDeductionDto> GetEmployeeDeductionOrders(int employeeId);
        Task<List<FormEmployeeOrder>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId);

    }
}
