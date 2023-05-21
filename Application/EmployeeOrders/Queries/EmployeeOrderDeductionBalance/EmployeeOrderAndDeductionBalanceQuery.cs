using Application.Common.Messaging;
using Domain.Constants;
using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance
{
    public record EmployeeOrderDeductionBalanceQuery(int employeeId) : IQuery<EmployeeOrderDeductionBalanceDto>;

    public class EmployeeOrderDeductionBalanceQueryHandler : IQueryHandler<EmployeeOrderDeductionBalanceQuery, EmployeeOrderDeductionBalanceDto>
    {
        private readonly IUOW _uow;

        public EmployeeOrderDeductionBalanceQueryHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            AuthService = authService;
        }

        public IAuthService AuthService { get; }

        public async Task<Result<EmployeeOrderDeductionBalanceDto>> Handle(EmployeeOrderDeductionBalanceQuery request, CancellationToken cancellationToken)
        {
            //GetEmployee Data
            Employee employee = await _uow.EmployeeRepository.GetByIdAsync(request.employeeId);
            if (employee == null)
            {
                return Result<EmployeeOrderDeductionBalanceDto>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }
            //Get Employee Orders Grouped
            EmployeeOrderDeductionBalanceDto employeeBalance = new EmployeeOrderDeductionBalanceDto();

            employeeBalance.EmployeeId = employee.Id;

            employeeBalance.EmployeeOrdersDtos = new List<EmployeeTotalOrderDto>();

            var employeeOrdes = _uow.FormEmployeeOrderRepository.GetEmployeeSumOrders(request.employeeId);


            employeeBalance.EmployeeOrdersDtos = employeeOrdes;
            return Result<EmployeeOrderDeductionBalanceDto>.Success(employeeBalance);
        }
    }

}
