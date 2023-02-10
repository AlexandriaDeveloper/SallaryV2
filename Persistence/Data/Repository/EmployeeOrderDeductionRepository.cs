//using Application.Interfaces.Repository;
//using Domain.DTOS.EmployeeOrderDeductionBalance;
//using Domain.Interfaces;
//using Domain.Models;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Persistence.Data.Repository
//{
//    public class EmployeeOrderBalanceRepository : Repository<EmployeeOrder>, IEmployeeBalanceRepository
//    {
//        private readonly SallaryCQRSAppContext _context;

//        public EmployeeOrderBalanceRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
//        {
//            _context = context;
//        }
//        List<EmployeeTotalOrderDeductionDto> GetEmployeeOrders(int employeeId)
//        {


//            List<EmployeeTotalOrderDeductionDto> employeeTotalOrderDeductionDtos
//               = new List<EmployeeTotalOrderDeductionDto>();
//            var result = _context.EmployeeOrders.Include(x => x.EmployeeOrderExecuations)
//                .Where(x => x.EmployeeId==employeeId)
//                .Include(x => x.Order)
//                .GroupBy(x => x.OrderId);



//            foreach (var item in result)
//            {
//                EmployeeTotalOrderDeductionDto employeeTotalOrderDeductionDto = new EmployeeTotalOrderDeductionDto();

//                employeeTotalOrderDeductionDto.OrderDeductionId = item.Key;


//                foreach (EmployeeOrderDeduction employeeOrder in item)
//                {

//                    employeeTotalOrderDeductionDto.OrderDeductionName = employeeOrder.Order.Name;
//                    employeeTotalOrderDeductionDto.Total += employeeOrder.EmployeeOrderDeductionExecuations.Sum(x => x.Amount);
//                    employeeTotalOrderDeductionDto.Total += employeeOrder.PeriodicSubscriptions.Sum(x => x.Amount);
//                }


//                employeeTotalOrderDeductionDtos.Add(employeeTotalOrderDeductionDto);

//            }


//            return employeeTotalOrderDeductionDtos;
//        }


//        public async Task<List<EmployeeOrder>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId)
//        {


//            return  await _context.EmployeeOrders.Where(x => x.OrderId == orderDeductionId && x.EmployeeId == employeeId).Include(x => x.EmployeeOrderExecuations).ToListAsync();
//        }
//    }
//}
