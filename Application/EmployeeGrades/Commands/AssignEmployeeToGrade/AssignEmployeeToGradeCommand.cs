using Application.Common.Messaging;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeGrades.Commands.AssignEmployeeToGrade
{
    public record AssignEmployeeToGradeCommand(int employeeId, int gradeId, DateTime assignDate) : ICommand<Unit>;
    public partial class AssignEmployeeToGradeCommandHandler : ICommandHandler<AssignEmployeeToGradeCommand, Unit>
    {
        private readonly IUOW _uow;

        public AssignEmployeeToGradeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<Unit>> Handle(AssignEmployeeToGradeCommand request, CancellationToken cancellationToken)
        {
            if (!await _uow.EmployeeRepository.CheckExistAsync(request.employeeId))
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (!await _uow.GradeRepository.CheckExistAsync(request.employeeId))
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeGradeRepository.AssignEmployeeToGrade(request.employeeId, request.gradeId, request.assignDate);

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result == SaveState.SqlException)
            {
                return Result<Unit>.Failure<Unit>(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_DUBLICATION_EXCEPTION));

            }
            if (result != SaveState.Saved)
            {

                return Result<Unit>.Failure<Unit>(new Error("", Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
