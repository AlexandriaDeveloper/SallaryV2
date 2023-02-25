using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
namespace Domain.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdQuery(int Id, int? formId) : IQuery<EmployeeDetailsDto>;

    public class GetEmployeesByIdQueryHandler : IQueryHandler<GetEmployeesByIdQuery, EmployeeDetailsDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesByIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<EmployeeDetailsDto>> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {

            GetEmployeesByIdQuerySpecification spec = new GetEmployeesByIdQuerySpecification(request.Id);
            Employee Employee = await _uow.EmployeeRepository.GetBySingleOrDefaultAsync(spec);
            if (Employee == null)
            {
                return Result<EmployeeDetailsDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<EmployeeDetailsDto>(Employee);
            empToReturn.Grade = _uow.EmployeeGradeRepository.GetEmployeeCurrentGrade(request.Id).Result.Grade.Name;
            if (request.formId.HasValue)
            {

                var employeeForm = await _uow.EmployeeFormRepository.GetByExpressionAsync(x => x.EmployeeId == request.Id && x.FormId == request.formId);

                if (employeeForm == null)
                {

                    return Result<EmployeeDetailsDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
                }

               
                empToReturn.Next = await _uow.EmployeeFormRepository.NextEmployeeInForm(employeeForm.EmployeeOrderNumber, request.formId.Value);
                empToReturn.Previous = await _uow.EmployeeFormRepository.PreviousEmployeeInForm(employeeForm.EmployeeOrderNumber, request.formId.Value);
            }
            else
            {

                empToReturn.Next = await _uow.EmployeeRepository.Next(x => x.Id, empToReturn.Id);
                empToReturn.Previous = await _uow.EmployeeRepository.Previous(x => x.Id, empToReturn.Id);
            }

            return Result<EmployeeDetailsDto>.Success(empToReturn);
        }


        public class GetEmployeesByIdQuerySpecification : Specification<Employee>
        {

            public GetEmployeesByIdQuerySpecification(int id)
            {
                AddInclude(x => x.PartTimeDurations);
                AddInclude(x => x.EmployeeGrades);
                
                AddCriteries(x => x.Id == id);
            }


        }
    }
}
