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
    public class EmployeeOrderRepository : Repository<FormEmployeeOrder>, IFormEmployeeOrderRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeOrderRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
        }
        List<EmployeeTotalOrderDto> IFormEmployeeOrderRepository.GetEmployeeSumOrders(int employeeId)
        {


            List<EmployeeTotalOrderDto> employeeTotalOrderDtos
               = new List<EmployeeTotalOrderDto>();
            var result = _context.FormEmployeeOrders
                  .Include(x => x.FormEmployee)
                 .Where(x => x.FormEmployee.EmployeeId == employeeId)
                 .Include(x => x.FormEmployeeOrderExecuations)
                 .Include(x => x.Order)
                 .Include(x => x.FormEmployee.Form)
                .GroupBy(x => x.OrderId);
            foreach (var item in result)
            {
                EmployeeTotalOrderDto employeeTotalOrderDto = new EmployeeTotalOrderDto();
                employeeTotalOrderDto.OrderId = item.Key;
                foreach (FormEmployeeOrder employeeOrder in item)
                {
                    if (employeeOrder.CreditOrDebit == 'd')
                    {
                        employeeTotalOrderDto.OrderId = employeeOrder.OrderId;
                        employeeTotalOrderDto.OrderName = employeeOrder.Order.Name;
                        employeeTotalOrderDto.OrderTotal += employeeOrder.FormEmployeeOrderExecuations.Sum(x => x.Amount);
                    }
                    if (employeeOrder.CreditOrDebit == 'c')
                    {
                        employeeTotalOrderDto.DeductionTotal += employeeOrder.FormEmployeeOrderExecuations.Sum(x => x.Amount);
                        employeeTotalOrderDto.OrderDeductionName = employeeOrder.Order.Name;
                    }
                }
                employeeTotalOrderDtos.Add(employeeTotalOrderDto);
            }
            return employeeTotalOrderDtos;
        }


        public async Task<List<FormEmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId)
        {
            return await _context.FormEmployeeOrders
                   .Where(x => x.OrderId == orderId && x.FormEmployee.EmployeeId == employeeId)
                   .Include(x => x.FormEmployeeOrderExecuations)
                   .Include(x => x.FormEmployee.Form)
                   .ToListAsync();
        }
    }
 }
