using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
namespace Domain.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdAndFormQuery(int employeeId, int formId) : IQuery<EmployeeDetailsDto>;

    public class GetEmployeesByIdAndFormQueryHandler : IQueryHandler<GetEmployeesByIdAndFormQuery, EmployeeDetailsDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesByIdAndFormQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<EmployeeDetailsDto>> Handle(GetEmployeesByIdAndFormQuery request, CancellationToken cancellationToken)
        {

            var spec = new GetEmployeesByIdAndFormQuerySpecification(request.employeeId, request.formId);
            var Employee = await _uow.EmployeeFormRepository.GetBySingleOrDefaultAsync(spec);
            if (Employee == null)
            {
                return Result<EmployeeDetailsDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<EmployeeDetailsDto>(Employee);

            empToReturn.Next = await _uow.EmployeeRepository.Next(x => x.Id, empToReturn.Id);
            empToReturn.Previous = await _uow.EmployeeRepository.Previous(x => x.Id, empToReturn.Id);
            return Result<EmployeeDetailsDto>.Success(empToReturn);
        }
    }

    public class GetEmployeesByIdAndFormQuerySpecification : Specification<EmployeeForm>
    {
        public GetEmployeesByIdAndFormQuerySpecification(int employeeId, int formId)
        {

            AddCriteries(x => x.EmployeeId == employeeId);
            AddCriteries(x => x.FormId == formId);
        }

    }
    public class GetEmployeesByIdAndFormQueryParam
    {
        public int? EmployeeId { get; set; }
        public int? FormId { get; set; }
    }
}
