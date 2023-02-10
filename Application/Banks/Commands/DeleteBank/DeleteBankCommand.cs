using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.Banks.Commands.DeleteBank
{
    public record DeleteBankCommand(int Id) : ICommand;
    public class DeleteBankCommandHandler : ICommandHandler<DeleteBankCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public DeleteBankCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(DeleteBankCommand request, CancellationToken cancellationToken)
        {
            if (!await _uow.BankRepository.CheckExistAsync(request.Id))
            {

                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            await _uow.BankRepository.Delete(request.Id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();

        }
    }

    public class DeleteBankCommandValidator : AbstractValidator<DeleteBankCommand>
    {
        public DeleteBankCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().NotNull();

        }
    }
}
