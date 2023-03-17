using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;

namespace Application.FinancialDataTypes.Commands.UpdateFinincialDataType
{
    public record UpdateFinincialDataTypeCommand(FinancialDataTypeDto FinancialDataType) : ICommand;
    public class UpdateFinincialDataTypeCommandHandler : ICommandHandler<UpdateFinincialDataTypeCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateFinincialDataTypeCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(UpdateFinincialDataTypeCommand request, CancellationToken cancellationToken)
        {
            FinancialDataType financialDataType = await _uow.FinancialDataTypesRepository.GetByIdAsync(request.FinancialDataType.Id);
            if (financialDataType == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            _mapper.Map<FinancialDataTypeDto, FinancialDataType>(request.FinancialDataType, financialDataType);


            await _uow.FinancialDataTypesRepository.Update(financialDataType);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }
    }

    public class UpdateFinincialDataTypeCommandValidator : AbstractValidator<UpdateFinincialDataTypeCommand>
    {

        public UpdateFinincialDataTypeCommandValidator()
        {
            RuleFor(x => x.FinancialDataType.Id).NotEmpty();
            RuleFor(x => x.FinancialDataType.Name).NotEmpty();
            RuleFor(x => x.FinancialDataType.ReservationDate).NotEmpty().NotNull();
            RuleFor(x => x.FinancialDataType.ParentFinancialDataTypeId).NotEmpty();
        }
    }
}
