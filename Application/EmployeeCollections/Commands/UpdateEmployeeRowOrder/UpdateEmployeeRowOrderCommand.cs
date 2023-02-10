using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeCollections.Commands.UpdateEmployeeRowOrder
{
    public record UpdateEmployeeRowOrderCommand(int[] ids) : ICommand;
    public class UpdateEmployeeRowOrderCommandHandler : ICommandHandler<UpdateEmployeeRowOrderCommand>
    {
        private readonly IUOW _uow;

        public UpdateEmployeeRowOrderCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(UpdateEmployeeRowOrderCommand request, CancellationToken cancellationToken)
        {
            int counter = 0;
            foreach (var id in request.ids)
            {
                EmployeeCollection getElementToUpdate = await _uow.EmployeeCollectionsRepository.GetByIdAsync(id);
                if (getElementToUpdate != null)
                {
                    getElementToUpdate.EmployeeOrderInCollection = counter;
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
