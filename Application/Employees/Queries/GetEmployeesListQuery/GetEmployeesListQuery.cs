using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Domain.Employees.Queries.GetEmployeesListQuery
{
    public record GetEmployeesListQuery(GetEmployeeListQueryParam param) : IQuery<PagedList<EmployeeDto>>;
    public class GetEmployeesListQueryHandler : IQueryHandler<GetEmployeesListQuery, PagedList<EmployeeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        async Task<Result<PagedList<EmployeeDto>>> IRequestHandler<GetEmployeesListQuery, Result<PagedList<EmployeeDto>>>.Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeListQuerySpecification(request.param);

            var data = await _uow.EmployeeRepository.GetAllBySpecAsync(spec, false);
            var EmployeeToReturn = _mapper.Map<List<EmployeeDto>>(data.Data);


            return Result<EmployeeDto>.Success(new PagedList<EmployeeDto>(EmployeeToReturn, data.Pagination));
        }
    }



}
