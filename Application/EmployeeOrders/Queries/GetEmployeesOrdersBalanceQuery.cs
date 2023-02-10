using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Queries
{
    public record GetEmployeesOrdersBalance : IRequest<Result<PagedList<EmployeeOrderBalanceDto>>>;

}
public class EmployeeOrderBalanceDto
{
    public int orderId { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeTabCode { get; set; }
    public string EmployeeTegaraCode { get; set; }
    public decimal? CurrentBalance { get; set; }


}