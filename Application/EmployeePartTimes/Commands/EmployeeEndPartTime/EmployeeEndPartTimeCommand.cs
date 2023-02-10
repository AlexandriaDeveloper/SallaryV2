using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;

namespace Application.EmployeePartTimes.Commands.EmployeeEndPartTime
{
    public record class EmployeeEndPartTimeCommand(EmployeePartTimeDto employeePartTimeDto) : ICommand<Unit>;
    public class EmployeeEndPartTimeCommandHandler : ICommandHandler<EmployeeEndPartTimeCommand, Unit>
    {
        private readonly IUOW _uow;



        public EmployeeEndPartTimeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<Unit>> Handle(EmployeeEndPartTimeCommand request, CancellationToken cancellationToken)
        {


            EmployeePartTime selectedPartTime = await _uow.EmployeePartTimeRepository.GetByIdAsync(request.employeePartTimeDto.Id.Value);

            if (selectedPartTime == null)
            {

                return Result<Unit>.Failure(new Error("", " عفوا لم يتم العثور على المدة المحددة"));
            }
            selectedPartTime.StartFrom = request.employeePartTimeDto.StartFrom;
            selectedPartTime.EndAt = request.employeePartTimeDto.EndAt;
            if (string.IsNullOrEmpty(request.employeePartTimeDto.Details))
                selectedPartTime.Details += "/n" + request.employeePartTimeDto.Details;

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result == Domain.Enums.SaveState.Exception)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }

            return Result.Success(Unit.Value);
        }


    }


}
