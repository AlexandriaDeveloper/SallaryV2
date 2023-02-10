using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;

namespace Domain.Employees.Commands.DeleteEmployee
{
    public record class DeleteEmployeeCommand(int id) : ICommand<Unit>;
    public class DeleteEmployeeCommandHandler : ICommandHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }


        async Task<Result<Unit>> IRequestHandler<DeleteEmployeeCommand, Result<Unit>>.Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {

            if (!await _uow.EmployeeRepository.CheckExistAsync(request.id))
            {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeRepository.Delete(request.id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Enums.SaveState.Saved)
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
