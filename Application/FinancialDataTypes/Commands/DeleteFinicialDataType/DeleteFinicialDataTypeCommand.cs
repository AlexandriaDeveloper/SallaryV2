using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.FinancialDataTypes.Commands.DeleteFinicialDataType
{

    public record DeleteFinicialDataTypeCommand(int id) : ICommand;
    public class DeleteFinicialDataTypeCommandHandler : ICommandHandler<DeleteFinicialDataTypeCommand>
    {
        private readonly IUOW _uow;

        public DeleteFinicialDataTypeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result> Handle(DeleteFinicialDataTypeCommand request, CancellationToken cancellationToken)
        {
            FinancialDataType financialDataTypeFromDb = await _uow.FinancialDataTypesRepository.GetByIdAsync(request.id);
            if (financialDataTypeFromDb == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.FinancialDataTypesRepository.HardDelete(financialDataTypeFromDb.Id);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();

        }
    }

    public class DeleteFinicialDataTypeCommandValidator : AbstractValidator<DeleteFinicialDataTypeCommand>
    {

        public DeleteFinicialDataTypeCommandValidator()
        {
            RuleFor(x => x.id).NotEmpty();
        }
    }
}
