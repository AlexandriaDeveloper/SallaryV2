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
                .Include(x => x.EmployeeOrderExecuations)
                // .Include(x => x.PeriodicSubscriptions)
                //  .Include(x => x.OrderFile)
                .Where(x => x.EmployeeId == employeeId)
                .Include(x => x.Order)
                .Include(x => x.Form)
                .GroupBy(x => x.OrderId);



            foreach (var item in result)
            {
                EmployeeTotalOrderDto employeeTotalOrderDto = new EmployeeTotalOrderDto();

                employeeTotalOrderDto.OrderId = item.Key;


                foreach (EmployeeOrder employeeOrder in item)
                {
                    if (employeeOrder.CreditOrDebit == 'd')
                    {
                        employeeTotalOrderDto.OrderId = employeeOrder.OrderId;

                        employeeTotalOrderDto.OrderName = employeeOrder.Order.Name;
                        employeeTotalOrderDto.OrderTotal += employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount);
                        // employeeTotalOrderDto.OrderTotal += employeeOrder.PeriodicSubscriptions.Sum(x => x.Amount);
                    }
                    if (employeeOrder.CreditOrDebit == 'c')
                    {

                        employeeTotalOrderDto.DeductionTotal += employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount);
                        employeeTotalOrderDto.OrderDeductionName = employeeOrder.Order.Name;


                    }
                }


                employeeTotalOrderDtos.Add(employeeTotalOrderDto);

            }


            return employeeTotalOrderDtos;
        }


        public async Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId)
        {


            return await _context.EmployeeOrders
                   .Where(x => x.OrderId == orderId && x.EmployeeId == employeeId)
                   .Include(x => x.EmployeeOrderExecuations)
                   //  .Include(x => x.OrderFile)
                   .Include(x => x.Form)
                   .ToListAsync();
        }
    }
}
