using FluentValidation;

namespace Domain.EmployeeOrders.Queries.GetEmployeeOrderData
{
    public class GetEmployeeOrderDataQueryValidator : AbstractValidator<GetEmployeeOrdersDataQuery>
    {
        public GetEmployeeOrderDataQueryValidator()
        {
            RuleFor(x => x.EmployeeId).NotNull().NotEmpty();
            RuleFor(x => x.OrderId).NotNull().NotEmpty();
        }
    }
}
