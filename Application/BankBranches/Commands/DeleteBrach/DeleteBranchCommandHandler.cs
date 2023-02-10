using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.BankBranches.Commands.DeleteBrach
{

    public record DeleteBranchCommand(int Id) : ICommand;
    public class DeleteBranchCommandHandler : ICommandHandler<DeleteBranchCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeleteBranchCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            if (!await _uow.BranchRepository.CheckExistAsync(request.Id))
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.BranchRepository.HardDelete(request.Id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }


    public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
    {
        public DeleteBranchCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
