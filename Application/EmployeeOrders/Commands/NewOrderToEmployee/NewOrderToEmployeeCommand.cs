using Application.Common.Messaging;
using Application.EmployeeBasicFinancialsDatas.Queries.GetEmployeeFinincialData;
using Application.Services.Calculations;
using AutoMapper;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;

namespace Domain.EmployeeOrders.Commands.NewOrderToEmployee
{
    public record NewEmployeeOrderCommand(EmployeeOrderDto employeeOrder) : ICommand<Unit>;
    public class NewEmployeeOrderCommandHandler : ICommandHandler<NewEmployeeOrderCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        private readonly IMediator _mediator;


        public NewEmployeeOrderCommandHandler(IUOW uow, IMapper mapper, IAuthService authService, IMediator mediator)
        {
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
            _mediator = mediator;

        }

        public IMediator Mediator { get; }

        public async Task<Result<Unit>> Handle(NewEmployeeOrderCommand request, CancellationToken cancellationToken)
        {

            Form form = await _uow.FormRepository.GetByIdAsync(request.employeeOrder.EmployeeOrderType.FormId);
            var formDate = DateTime.Parse(form.FormDate);

            IReadOnlyList<BudgetItem> budgetItems = await _uow.BudgetItemRepository.GetAllAsync();

            var empData2 = await _mediator.Send(new GetEmployeeFinincialDataQuery(request.employeeOrder.EmployeeId,request.employeeOrder.SelectedDate));

            EmployeeBasicSallaryDataDto empData =new EmployeeBasicSallaryDataDto();
          //AutoMapper Later
            empData.Wazifi = empData2.Value.Wazifi;
            empData.Mokamel = empData2.Value.Mokamel;
            empData.Taawidi = empData2.Value.Tawidi;
           
            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.EmployeeOrderType.OrderId);
            if (order == null)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            EmployeeOrder employeeOrder = _mapper.Map<EmployeeOrder>(request.employeeOrder);
            CalculateOrder calcService = new CalculateOrder( budgetItems);
            if (request.employeeOrder.EmployeeOrderType.Quantity.HasValue)
            {
                empData.Quantity = request.employeeOrder.EmployeeOrderType.Quantity;
                employeeOrder.EmployeeOrderType.EmployeeOrderExecuations = await calcService.CalculateEmployeeOrder(empData, order, formDate);
            }
            else if (request.employeeOrder.EmployeeOrderType.Amount.HasValue)
            {
                empData.Amount = request.employeeOrder.EmployeeOrderType.Amount;
                employeeOrder.EmployeeOrderType.EmployeeOrderExecuations = await calcService.CalculateFixedEmployeeOrder(empData, order, formDate);
            }
            await _uow.EmployeeOrderRepository.AddItem(employeeOrder);
            var result2 = await _uow.SaveChangesAsync(cancellationToken);
            if (result2 != SaveState.Saved)
            {
                return Result<Unit>.Failure(result2);
            }
            return Result<Unit>.Success(Unit.Value);

        }

    }


}
