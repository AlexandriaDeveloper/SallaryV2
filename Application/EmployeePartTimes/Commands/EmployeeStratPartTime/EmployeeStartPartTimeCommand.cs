using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeePartTimes.Commands.EmployeeStratPartTime
{
    public record class EmployeeStartPartTimeCommand(EmployeePartTimeDto employeePartTime) : ICommand<int>;
    public class EmployeeStartPartTimeCommandHandler : ICommandHandler<EmployeeStartPartTimeCommand, int>
    {
        private readonly IUOW _uow;

        public EmployeeStartPartTimeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<int>> Handle(EmployeeStartPartTimeCommand request, CancellationToken cancellationToken)
        {
            var result = await _uow.EmployeeRepository.EmployeeStartPartTimeDuration(request.employeePartTime.EmployeeId, request.employeePartTime.StartFrom, request.employeePartTime.Details);

            return Result.Success(result.Value);
        }


    }


}
