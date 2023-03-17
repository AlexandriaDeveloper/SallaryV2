using Application.Common.Messaging;
using Application.EmployeeBasicFinancialDatas.Commands.AddEmployeeWazifiElements;
using AutoMapper;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeeBasicFinancialDatas.Commands.AddEmployeeElement
{
    public record AddEmployeeElementCommand(EmployeeBasicFinancialDataDtos model) : ICommand;
    public class AddEmployeeElementCommandHandler : ICommandHandler<AddEmployeeElementCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeeElementCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result> Handle(AddEmployeeElementCommand request, CancellationToken cancellationToken)
        {

            await _uow.EmployeeBasicFinancialDataRepository.AddItem(new Domain.Models.EmployeeBasicFinancialData()
            {

                EmployeeId = request.model.EmployeeId,
                Amount = request.model.Amount,
                FinancialDataTypesId = request.model.FinancialDataTypeId

            });

            var result = await _uow.SaveChangesAsync(cancellationToken);

            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }

            return Result.Success();
        }


        public class AddEmployeeElementCommandValidator : AbstractValidator<AddEmployeeElementCommand>
        {
            public AddEmployeeElementCommandValidator()
            {
                RuleFor(p => p.model.Amount).NotNull().NotEmpty();
                RuleFor(p => p.model.EmployeeId).NotNull().NotEmpty();
                RuleFor(p => p.model.FinancialDataTypeId).NotNull().NotEmpty();

            }
        }
    }
}
