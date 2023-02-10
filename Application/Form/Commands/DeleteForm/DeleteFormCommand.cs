using Application.Common.Messaging;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Form.Commands.DeleteForm
{
    public record DeleteFormCommand(int id) : ICommand;
    public class DeleteFormCommandHandler : ICommandHandler<DeleteFormCommand>
    {
        private readonly IUOW _uow;

        public DeleteFormCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public async Task<Result> Handle(DeleteFormCommand request, CancellationToken cancellationToken)
        {
            await _uow.FormRepository.HardDelete(request.id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }
}
