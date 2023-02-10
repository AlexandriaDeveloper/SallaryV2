using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.Employees.Queries.GetDeletedEmployee
{
    public class GetDeltetdEmployeeListQueryParam : Param
    {
        public string? Name { get; set; }
        public string? TabCode { get; set; }
        public string? TegaraCode { get; set; }

        public string? NationalId { get; set; }
    };
    public record GetDeletedEmployeesQuery(GetDeltetdEmployeeListQueryParam param) : IQuery<PagedList<Employee>>;
    public partial class GetDeletedEmployeesQueryHandler : IQueryHandler<GetDeletedEmployeesQuery, PagedList<Employee>>
    {
        private new readonly IUOW _uow;

        public GetDeletedEmployeesQueryHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result<PagedList<Employee>>> Handle(GetDeletedEmployeesQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetDeletedEmployeeListQuerySpecification(request.param);
            return Result<PagedList<Employee>>.Success(await _uow.EmployeeRepository.GetAlDeletedlAsync(spec));
        }
    }


}
