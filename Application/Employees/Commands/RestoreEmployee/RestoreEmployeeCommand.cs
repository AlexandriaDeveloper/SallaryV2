using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using MediatR;
namespace Domain.Employees.Commands.RestoreEmployee
{

    public record class RestorEmployeeCommand(int id) : ICommand<Unit>;
    public class RestoreEmployeeCommandHandler : ICommandHandler<RestorEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;

        public RestoreEmployeeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<Unit>> Handle(RestorEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.id);
            if (entity == null)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (entity != null)
            {


                await _uow.EmployeeRepository.Restore(request.id);
                var result = await _uow.SaveChangesAsync(cancellationToken);
                if (result != Enums.SaveState.Saved)
                {
                    return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
                }

            }
            return Result<Unit>.Success(Unit.Value);
        }
    }

}
