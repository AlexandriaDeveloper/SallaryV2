using FluentValidation;

namespace Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance
{
    public class EmployeeOrderDeductionBalanceQueryValidator : AbstractValidator<EmployeeOrderDeductionBalanceQuery>
    {
        public EmployeeOrderDeductionBalanceQueryValidator()
        {
            RuleFor(p => p.employeeId).NotEmpty().NotNull();
        }
    }
}
