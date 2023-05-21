using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using FluentValidation;

namespace Application.EmployeesForm.Commands.AddEmployeeToForm
{
    public record AddEmployeeToFormCommand(AddEmployeeToFormParam param) : ICommand;

    public class AddEmployeeToFormCommandHandler : ICommandHandler<AddEmployeeToFormCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public AddEmployeeToFormCommandHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result> Handle(AddEmployeeToFormCommand request, CancellationToken cancellationToken)
        {
            if (!await _uow.EmployeeRepository.CheckExistAsync(request.param.employeeId))
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            var maxOrder = _uow.FormEmployeeRepository.GetMaxOrderInFile(request.param.formId);

            await _uow.FormEmployeeRepository.AddItem(new Domain.Models.FormEmployee()
            {
                EmployeeId = request.param.employeeId,
                FormId = request.param.formId,
                EmployeeOrderNumber = maxOrder + 1
            });

            var result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != Domain.Enums.SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();

        }
    }


    public class AddEmployeeToFormCommandValidator : AbstractValidator<AddEmployeeToFormCommand>
    {
        public AddEmployeeToFormCommandValidator()
        {
            RuleFor(p => p.param.employeeId).NotEmpty();
            RuleFor(p => p.param.formId).NotEmpty();
        }
    }
}
