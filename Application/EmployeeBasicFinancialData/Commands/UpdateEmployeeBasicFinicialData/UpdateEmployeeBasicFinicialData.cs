using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;
using static Application.EmployeeBasicFinancialDatas.Commands.UpdateEmployeeBasicFinicialData.UpdateEmployeeBasicFinicialDataCommandHandler;

namespace Application.EmployeeBasicFinancialDatas.Commands.UpdateEmployeeBasicFinicialData
{

    public record UpdateEmployeeBasicFinicialDataCommand(UpdateEmployeeBasicFinancialDataDtos model) : ICommand;
    public class UpdateEmployeeBasicFinicialDataCommandHandler : ICommandHandler<UpdateEmployeeBasicFinicialDataCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateEmployeeBasicFinicialDataCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateEmployeeBasicFinicialDataCommand request, CancellationToken cancellationToken)
        {
            EmployeeBasicFinancialData employeeBasicFinancialData = await _uow.EmployeeBasicFinancialDataRepository.GetByIdAsync(request.model.Id);

            if (employeeBasicFinancialData == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            employeeBasicFinancialData.Amount = request.model.Amount;

            await _uow.EmployeeBasicFinancialDataRepository.Update(employeeBasicFinancialData);
            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();
        }

        public class UpdateEmployeeBasicFinicialDataCommandValidator : AbstractValidator<UpdateEmployeeBasicFinicialDataCommand>
        {

            public UpdateEmployeeBasicFinicialDataCommandValidator()
            {
                RuleFor(x => x.model.Id).NotNull().NotEmpty();
                //RuleFor(x => x.model.EmployeeId).NotNull().NotEmpty();
                //RuleFor(x => x.model.FinancialDataTypeId).NotNull().NotEmpty();
                //  RuleFor(x => x.model.Amount).NotNull().NotEmpty();
            }
        }

        public class UpdateEmployeeBasicFinancialDataDtos
        {


            public int Id { get; set; }
            public decimal Amount { get; set; }

        }
    }
}
