using Application.Common.Messaging;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.EmployeesForm.Commands
{
    public record DeleteEmployeeFromCommand(int employeeFormId) : ICommand;
    public class DeleteEmployeeFromCommandHandler : ICommandHandler<DeleteEmployeeFromCommand>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeFromCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(DeleteEmployeeFromCommand request, CancellationToken cancellationToken)
        {
            await _uow.EmployeeFormRepository.HardDelete(request.employeeFormId);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }
}
