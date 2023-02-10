using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeOrderRepository : IRepository<EmployeeOrder>
    {
        List<EmployeeTotalOrderDto> GetEmployeeSumOrders(int employeeId);
        Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId);

    }
}
