using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.BankBranches.Commands.AddBranchToBank
{
    public record AddBranchToBankCommand(BrancheDto branch) : ICommand;

    public class AddBranchToBankCommandHandler : ICommandHandler<AddBranchToBankCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddBranchToBankCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddBranchToBankCommand request, CancellationToken cancellationToken)
        {

            if (!await _uow.BankRepository.CheckExistAsync(request.branch.BankId))
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            Branch branch = _mapper.Map<Branch>(request.branch);
            await _uow.BranchRepository.AddItem(branch);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }

        //UpdateBranchCommand



    }


}
