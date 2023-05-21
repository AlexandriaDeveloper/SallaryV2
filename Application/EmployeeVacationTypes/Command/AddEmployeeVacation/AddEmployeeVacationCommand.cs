using Application.Common.Messaging;
using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Application.Services.Calculations;
using AutoMapper;
using Domain.Constants;
using Domain.Employees.Queries.GetEmployeeById;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;
using MediatR;

namespace Application.EmployeeVacationTypes.Command.AddEmployeeVacation
{

    public record AddEmployeeVacationCommand(FormEmployeeVacationTypeDto employeeVacationDto) : ICommand;
    public class AddEmployeeVacationCommandHandler : ICommandHandler<AddEmployeeVacationCommand>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly IAuthService _authService;

        public AddEmployeeVacationCommandHandler(IUOW uow, IMapper mapper, IMediator mediator, IAuthService authService)
        {
            _uow = uow;
            _mapper = mapper;
            _mediator = mediator;
            _authService = authService;
        }
        public async Task<Result> Handle(AddEmployeeVacationCommand request, CancellationToken cancellationToken)
        {
           Domain.Models.FormEmployee formEmployee =await _uow.FormEmployeeRepository.GetByIdAsync(request.employeeVacationDto.FormEmployeeId.Value);
           Domain.Models.Form form = await _uow.FormRepository.GetByIdAsync(formEmployee.FormId);
            var formDate = DateTime.Parse(form.FormDate);


            IReadOnlyList<BudgetItem> budgetItems =await _uow.BudgetItemRepository.GetAllAsync();

            var empData2 = await _mediator.Send(new GetEmployeeFinincialDataQuery(formEmployee.EmployeeId, DateTime.Now));

            EmployeeBasicSallaryDataDto empData = new EmployeeBasicSallaryDataDto();
            //AutoMapper Later
            empData.Wazifi = empData2.Value.Wazifi;
            empData.Mokamel = empData2.Value.Mokamel;
            empData.Taawidi = empData2.Value.Tawidi;



            FormEmployeeVacation employeeVactaion = _mapper.Map<FormEmployeeVacation>(request.employeeVacationDto);

            employeeVactaion.Vacation =await _uow.VacationTypeRepository.GetByIdAsync(employeeVactaion.VacationId);

            if (employeeVactaion == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            FormEmployeeVacation formEmployeeVacataion = _mapper.Map<FormEmployeeVacation>(request.employeeVacationDto);

            await _uow.FormEmployeeVacationTypeRepository.AddItem(formEmployeeVacataion);
            SaveState result = await _uow.SaveChangesAsync(cancellationToken);
            if (result != SaveState.Saved)
            {
                return Result.Failure(result);
            }
            return Result.Success();

        }
    }


    public class AddEmployeeVacationCommandValidator : AbstractValidator<AddEmployeeVacationCommand>
    {
        public AddEmployeeVacationCommandValidator()
        {
            RuleFor(p => p.employeeVacationDto.VacationId).NotNull().NotEmpty();
            RuleFor(p => p.employeeVacationDto.StartAt).NotNull().NotEmpty();
        }
    }


}
