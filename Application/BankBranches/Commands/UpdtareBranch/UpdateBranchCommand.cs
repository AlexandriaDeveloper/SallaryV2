using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.BankBranches.Commands.UpdtareBranch
{
    public record UpdateBranchCommand(BrancheDto branch) : ICommand;

    public class UpdateBranchCommandHandler : ICommandHandler<UpdateBranchCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateBranchCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            Branch brnachToUpdate = await _uow.BranchRepository.GetByIdAsync(request.branch.Id.Value);
            if (brnachToUpdate == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            _mapper.Map<BrancheDto, Branch>(request.branch, brnachToUpdate);
            await _uow.BranchRepository.Update(brnachToUpdate);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();

        }
    }

    public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
    {
        public UpdateBranchCommandValidator()
        {
            RuleFor(x => x.branch.BankId).NotEmpty().NotNull();
            RuleFor(x => x.branch.Name).NotEmpty().NotNull();

        }
    }
}
