using Application.Interfaces.Repository;
using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeeOrderRepository : Repository<EmployeeOrder>, IEmployeeOrderRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeOrderRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
        }
        List<EmployeeTotalOrderDto> IEmployeeOrderRepository.GetEmployeeSumOrders(int employeeId)
        {


            List<EmployeeTotalOrderDto> employeeTotalOrderDtos
               = new List<EmployeeTotalOrderDto>();
            var result = _context.EmployeeOrders
                 .Where(x => x.EmployeeId == employeeId)
                 .Include(x => x.EmployeeOrderType)
                 .ThenInclude(x => x.EmployeeOrderExecuations)
                 .Include(x => x.EmployeeOrderType.Order)
                 .Include(x => x.EmployeeOrderType.Form)
                .GroupBy(x => x.EmployeeOrderType.OrderId);
            foreach (var item in result)
            {
                EmployeeTotalOrderDto employeeTotalOrderDto = new EmployeeTotalOrderDto();
                employeeTotalOrderDto.OrderId = item.Key;
                foreach (EmployeeOrder employeeOrder in item)
                {
                    if (employeeOrder.EmployeeOrderType.CreditOrDebit == 'd')
                    {
                        employeeTotalOrderDto.OrderId = employeeOrder.EmployeeOrderType.OrderId;
                        employeeTotalOrderDto.OrderName = employeeOrder.EmployeeOrderType.Order.Name;
                        employeeTotalOrderDto.OrderTotal += employeeOrder.EmployeeOrderType.EmployeeOrderExecuations.Sum(x => x.Amount);
                    }
                    if (employeeOrder.EmployeeOrderType.CreditOrDebit == 'c')
                    {
                        employeeTotalOrderDto.DeductionTotal += employeeOrder.EmployeeOrderType.EmployeeOrderExecuations.Sum(x => x.Amount);
                        employeeTotalOrderDto.OrderDeductionName = employeeOrder.EmployeeOrderType.Order.Name;
                    }
                }
                employeeTotalOrderDtos.Add(employeeTotalOrderDto);
            }
            return employeeTotalOrderDtos;
        }


        public async Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId)
        {
            return await _context.EmployeeOrders
                   .Where(x => x.EmployeeOrderType.OrderId == orderId && x.EmployeeId == employeeId).
                   Include(x => x.EmployeeOrderType)
                   .ThenInclude(x => x.EmployeeOrderExecuations)
                   .Include(x => x.EmployeeOrderType.Form)
                   .ToListAsync();
        }
    }
}
