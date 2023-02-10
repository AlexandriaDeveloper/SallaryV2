using Application.Common.Messaging;
using Application.EmployeeBankAccount;
using AutoMapper;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.Banks.Commands.UpdateBank
{

    public record UpdateBankCommand(BankDto bank) : ICommand;
    public class UpdateBankCommandHandler : ICommandHandler<UpdateBankCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateBankCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateBankCommand request, CancellationToken cancellationToken)
        {
            if (!request.bank.Id.HasValue)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            Bank bankFromDb = await _uow.BankRepository.GetByIdAsync(request.bank.Id.Value);
            if (bankFromDb == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            Bank bankToUpdate = _mapper.Map<BankDto, Bank>(request.bank, bankFromDb);
            await _uow.BankRepository.Update(bankToUpdate);

            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();
        }
    }

    public class UpdateBankCommandValidator : AbstractValidator<UpdateBankCommand>
    {
        public UpdateBankCommandValidator()
        {
            RuleFor(p => p.bank.Id).NotEmpty().NotNull();
            RuleFor(p => p.bank.Name).NotEmpty().NotNull();
        }

    }
}
