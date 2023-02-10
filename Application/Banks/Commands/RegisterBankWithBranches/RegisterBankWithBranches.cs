using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.Banks.Commands.RegisterBankWithBranches
{

    public record RegisterBankWithBranchesCommand(BankDto bank) : ICommand;
    public class RegisterBankWithBranchesCommandHandler : ICommandHandler<RegisterBankWithBranchesCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public RegisterBankWithBranchesCommandHandler(IUOW uow, IMapper mapper, IAuthService authService)
        {
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
        }
        public async Task<Result> Handle(RegisterBankWithBranchesCommand request, CancellationToken cancellationToken)
        {
            var bank = await _uow.BankRepository.GetByNameAsync(request.bank.Name);
            if (bank != null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_AlREDY_EXIST);
            }
            var bankToDb = new Domain.Models.Bank() { Name = request.bank.Name };
            if (request.bank.Branches != null)
            {

                bankToDb.Branches = new List<Domain.Models.Branch>();
                foreach (var branch in request.bank.Branches)
                {
                    bankToDb.Branches.Add(

                        new Domain.Models.Branch() { Name = branch.Name, Bank = bankToDb, CreatedBy = _authService.GetCurrentLoggedInUser(), CreatedDate = DateTime.Now });
                }
            }

            await _uow.BankRepository.AddItem(bankToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {

                return Result.Failure(result);
            }
            return Result.Success();
        }
    }
}
