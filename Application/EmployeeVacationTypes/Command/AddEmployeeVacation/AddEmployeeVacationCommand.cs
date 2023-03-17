using Application.Common.Messaging;
using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Application.Services.Calculations;
using AutoMapper;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using FluentValidation;
using MediatR;

namespace Application.EmployeeVacationTypes.Command.AddEmployeeVacation
{

    public record AddEmployeeVacationCommand(EmployeeVacationTypeDto employeeVacationDto) : ICommand;
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
           Domain.Models.Form form = await _uow.FormRepository.GetByIdAsync(request.employeeVacationDto.FormId);
            var formDate = DateTime.Parse(form.FormDate);


            IReadOnlyList<BudgetItem> budgetItems =await _uow.BudgetItemRepository.GetAllAsync();

            var empData2 = await _mediator.Send(new GetEmployeeFinincialDataQuery(request.employeeVacationDto.EmployeeId.Value, DateTime.Now));

            EmployeeBasicSallaryDataDto empData = new EmployeeBasicSallaryDataDto();
            //AutoMapper Later
            empData.Wazifi = empData2.Value.Wazifi;
            empData.Mokamel = empData2.Value.Mokamel;
            empData.Taawidi = empData2.Value.Tawidi;



            EmployeeVacationType employeeVactaion = _mapper.Map<EmployeeVacationType>(request.employeeVacationDto);

            employeeVactaion.Vacation =await _uow.VacationTypeRepository.GetByIdAsync(employeeVactaion.VacationId);

            if (employeeVactaion == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            EmployeeOrder order = new EmployeeOrder();
            order.EmployeeId = request.employeeVacationDto.EmployeeId.Value;
            order.Details = request.employeeVacationDto.Details;
            order.CreatedDate = DateTime.Now;
            order.CreatedBy = _authService.GetCurrentLoggedInUser();
            employeeVactaion.CreatedDate = DateTime.Now;
            order.CreatedBy = _authService.GetCurrentLoggedInUser();
            //CalculateVacataion calcVacation = new CalculateVacataion(budgetItems);
            //employeeVactaion.EmployeeVacationTypeExecuation =await calcVacation.CalculateVacation(empData, employeeVactaion, formDate);
            order.EmployeeVacationType = employeeVactaion;

           


            await _uow.EmployeeOrderRepository.AddItem(order);
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
