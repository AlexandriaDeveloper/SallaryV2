using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeCollections.Commands.UpdateEmployeeRowOrder
{
    public record UpdateEmployeeFormRowOrderCommand(int[] ids) : ICommand;
    public class UpdateEmployeeFormRowOrderCommandHandler : ICommandHandler<UpdateEmployeeFormRowOrderCommand>
    {
        private readonly IUOW _uow;

        public UpdateEmployeeFormRowOrderCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(UpdateEmployeeFormRowOrderCommand request, CancellationToken cancellationToken)
        {
            int counter = 0;
            foreach (var id in request.ids)
            {
                Domain.Models.FormEmployee getElementToUpdate = await _uow.FormEmployeeRepository.GetByIdAsync(id);
                if (getElementToUpdate != null)
                {
                    getElementToUpdate.EmployeeOrderNumber = counter;
                    counter++;
                }
            }
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }
}
