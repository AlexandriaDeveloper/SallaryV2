//using Application.Common.Messaging;
//using Domain.Constants;
//using Domain.Interfaces;
//using Domain.Shared;
//using MediatR;
//namespace Domain.EmployeesSallaries.Commands.EmployeesGetRaiseByGrade
//{
//    public record EmployeesGetRaiseByGradeCommand(
//            int gradeId,
//            int newFinancialYearId,
//            decimal? wazifiPercentage,
//            decimal? wazifiAmount,
//            decimal? wazifiMinAmount,
//            decimal? wazifiMaxAmount,
//            decimal? mokamelPercentage,
//            decimal? mokamelAmount,
//            decimal? mokamelMinAmount,
//            decimal? mokamelMaxAmount

//        ) : ICommand<Unit>;

//    public class EmployeesGetRaiseByGradeCommandHandler : ICommandHandler<EmployeesGetRaiseByGradeCommand, Unit>
//    {
//        private readonly IUOW _uow;

//        public EmployeesGetRaiseByGradeCommandHandler(IUOW uow)
//        {
//            _uow = uow;
//        }

//        public async Task<Result<Unit>> Handle(EmployeesGetRaiseByGradeCommand request, CancellationToken cancellationToken)
//        {
//            var employees = await _uow.EmployeeGradeRepository.GetEmployeeInSpecificGradeId(request.gradeId);
//            if (employees == null)
//            {
//                Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
//            }
//            foreach (var employee in employees)
//            {
//                var employeeNewSallary = await _uow.EmployeeBasicSallaryRepository.EmployeeGetRaise(employee.Id, request.newFinancialYearId, request.wazifiPercentage, request.wazifiAmount, request.wazifiMinAmount
//                       , request.wazifiMaxAmount, request.mokamelPercentage, request.mokamelAmount, request.mokamelMinAmount, request.mokamelMaxAmount);

//                await _uow.EmployeeBasicSallaryRepository.AddItem(employeeNewSallary);
//            }
//            var saveResult = await _uow.SaveChangesAsync(cancellationToken);

//            if (saveResult != Enums.SaveState.Saved)
//            {
//                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
//            }
//            return Result<Unit>.Success(Unit.Value);
//        }
//    }
//}
