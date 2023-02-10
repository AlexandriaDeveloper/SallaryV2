using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Employees;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeOrders.Queries.GetEmployeeByTabCodeOrTegaraCode
{
    public record GetEmployeeByTabCodeOrTegaraCodeQuery(string? tabCode, string? tegaraCode) : IQuery<EmployeeDto>;
    public class GetEmployeeByTabCodeOrTegaraCodeQueryHandler : IQueryHandler<GetEmployeeByTabCodeOrTegaraCodeQuery, EmployeeDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeByTabCodeOrTegaraCodeQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<EmployeeDto>> Handle(GetEmployeeByTabCodeOrTegaraCodeQuery request, CancellationToken cancellationToken)
        {
            var employeeSpec = new GetEmployeeByTabCodeOrTegaraCodeQuerySpecification(request.tabCode, request.tegaraCode);


            var employee = await _uow.EmployeeRepository.GetBySingleOrDefaultAsync(employeeSpec, false);
            if (employee == null)
            {
                return Result<EmployeeDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var employeeToReturn = _mapper.Map<EmployeeDto>(employee);
            return Result<EmployeeDto>.Success(employeeToReturn);
        }
    }

    public class GetEmployeeByTabCodeOrTegaraCodeQuerySpecification : Specification<Employee>
    {

        public GetEmployeeByTabCodeOrTegaraCodeQuerySpecification(string? tabCode = "", string? tegaraCode = "")
        {
            if (!string.IsNullOrEmpty(tabCode))
            {

                AddCriteries(x => x.TabCode.Equals(tabCode));
            }
            if (!string.IsNullOrEmpty(tegaraCode))
            {

                AddCriteries(x => x.TegaraCode.Equals(tegaraCode));
            }

        }

    }
}
