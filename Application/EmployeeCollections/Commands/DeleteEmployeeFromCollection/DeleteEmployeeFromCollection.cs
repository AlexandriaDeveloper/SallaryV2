using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;


namespace Application.EmployeeCollections.Commands.DeleteEmployeeFromCollection
{
    public record DeleteEmployeeFromCollectionCommand(int id) : ICommand;
    public class DeleteEmployeeFromCollectionCommandHandler : ICommandHandler<DeleteEmployeeFromCollectionCommand>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeFromCollectionCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(DeleteEmployeeFromCollectionCommand request, CancellationToken cancellationToken)
        {
            await _uow.EmployeeCollectionsRepository.HardDelete(request.id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result.Success();
        }
    }
}
