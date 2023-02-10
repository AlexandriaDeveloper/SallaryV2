using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Shared;

namespace Domain.EmployeeGrades.Query.GetEmployeeCurrentGrade
{
    public record GetEmployeeCurrentGradeQuery(int employeeId) : IQuery<EmployeeGradeDto>;
    public class GetEmployeeCurrentGradeQueryHandler : IQueryHandler<GetEmployeeCurrentGradeQuery, EmployeeGradeDto>
    {
        private readonly IUOW _uow;

        public GetEmployeeCurrentGradeQueryHandler(IUOW uow)
        {
            _uow = uow;
        }


        public async Task<Result<EmployeeGradeDto>> Handle(GetEmployeeCurrentGradeQuery request, CancellationToken cancellationToken)
        {

            var validation = new GetEmployeeCurrentGradeQueryHandlerValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<EmployeeGradeDto>.Failure<EmployeeGradeDto>(new Error("", validate.Errors.First().ErrorMessage));
            }
            var grade = await _uow.EmployeeGradeRepository.GetEmployeeCurrentGrade(request.employeeId);
            if (grade == null)
            {
                return Result<EmployeeGradeDto>.Failure<EmployeeGradeDto>(new Error("", "Employee Dosent Containe Grade Yet"));
            }

            EmployeeGradeDto employeeGrade = new EmployeeGradeDto();

            employeeGrade.EmployeeName = grade.Employees.Name;
            employeeGrade.GradeName = grade.Grade.Name;
            employeeGrade.StartFrom = grade.StartFrom;
            employeeGrade.EndAt = grade.EndAt;
            return Result<EmployeeGradeDto>.Success(employeeGrade);
        }
    }
}
