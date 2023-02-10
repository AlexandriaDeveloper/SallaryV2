using Application.Common.Messaging;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeBankAccount.Commands.EmployeeAddBankAccount
{
    public record EmployeeAddBankAccountCommand(EmployeeBankAccountDto employeeAccount) : ICommand<int>;

    public class EmployeeAddBankAccountCommandHandler : ICommandHandler<EmployeeAddBankAccountCommand, int>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public EmployeeAddBankAccountCommandHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            _authService = authService;
        }
        public async Task<Result<int>> Handle(EmployeeAddBankAccountCommand request, CancellationToken cancellationToken)
        {
            var emp = await _uow.EmployeeRepository.GetByIdAsync(request.employeeAccount.EmployeeId);
            if (emp is null)
            {
                return Result<int>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (!await _uow.EmployeeRepository.CheckExistAsync(request.employeeAccount.BranchId))
            {
                return Result<int>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (emp.EmployeeHasBank)
            {
                return Result<int>.Failure(new Error("Account Exist", "الموظف مسجل له رقم حساب بالفعل لا يمكن ادخال اكثر من رقم حساب"));
            }


            var employeeBank = new EmployeeBank() { BranchId = request.employeeAccount.BranchId, AccountNumber = request.employeeAccount.AccountNumber, CreatedBy = _authService.GetCurrentLoggedInUser(), CreatedDate = DateTime.Now };
            await _uow.EmployeeRepository.EmployeeAddBankAccount(request.employeeAccount.EmployeeId, employeeBank
              );

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result<int>.Failure(result);

            }
            return Result<int>.Success(employeeBank.Id);
        }
    }
}
