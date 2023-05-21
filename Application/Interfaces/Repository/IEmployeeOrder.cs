using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IFormEmployeeOrderRepository : IRepository<FormEmployeeOrder>
    {
        List<EmployeeTotalOrderDto> GetEmployeeSumOrders(int employeeId);
        Task<List<FormEmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId);

    }
}
