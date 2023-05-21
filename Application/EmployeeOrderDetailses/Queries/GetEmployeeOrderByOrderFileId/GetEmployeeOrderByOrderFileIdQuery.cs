using Application.Common.Messaging;
using Domain.EmployeeOrders;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeOrderDetailses.Queries.GetEmployeeOrderByOrderFileId;

public record GetEmployeeOrderByOrderFileIdQuery(GetEmployeeOrderByFormIdQueryParams param) : IQuery<PagedList<EmployeeOrderDetailsByOrderFileIdDto>>;
public class GetEmployeeOrderByOrderFileIdQueryHandler :
    IQueryHandler<GetEmployeeOrderByOrderFileIdQuery, PagedList<EmployeeOrderDetailsByOrderFileIdDto>>
{
    private readonly IUOW _uow;

    public GetEmployeeOrderByOrderFileIdQueryHandler(IUOW uow)
    {
        _uow = uow;
    }
    public async Task<Result<PagedList<EmployeeOrderDetailsByOrderFileIdDto>>> Handle(GetEmployeeOrderByOrderFileIdQuery request, CancellationToken cancellationToken)
    {
        var employeeOrderDetails = await _uow.FormEmployeeOrderRepository.GetAllBySpecAsync(new GetEmployeeOrderByFormIdQuerySpecification(request.param));
        var employeeOrderVacationsDetails = await _uow.FormEmployeeVacationTypeRepository.GetAllBySpecAsync(new GetEmployeeVacationByFormIdQuerySpecification(request.param));
        List<EmployeeOrderDetailsByOrderFileIdDto> employeeOrderDetailsByOrderFileIdList = new List<EmployeeOrderDetailsByOrderFileIdDto>();
        foreach (var employeeOrderDetail in employeeOrderDetails.Data)
        {
            employeeOrderDetailsByOrderFileIdList.Add(new EmployeeOrderDetailsByOrderFileIdDto(
                employeeOrderDetail.Id,
                employeeOrderDetail.FormEmployee.Employee.TabCode,
                employeeOrderDetail.FormEmployee.Employee.TegaraCode,
                 employeeOrderDetail.FormEmployee.Employee.Name,
                 employeeOrderDetail.Order.Name,
                 employeeOrderDetail.Details,
                 employeeOrderDetail.Quantity,
                 employeeOrderDetail.FormEmployeeOrderExecuations.Sum(x => x.Amount)
                ));


        }



        PagedList<EmployeeOrderDetailsByOrderFileIdDto> returnValue = new PagedList<EmployeeOrderDetailsByOrderFileIdDto>(employeeOrderDetailsByOrderFileIdList, employeeOrderDetails.Pagination);

        return Result.Success(returnValue);
    }
}
public class GetEmployeeOrderByFormIdQuerySpecification : Specification<FormEmployeeOrder>
{

    public GetEmployeeOrderByFormIdQuerySpecification(GetEmployeeOrderByFormIdQueryParams param)
    {

        AddInclude(x => x.FormEmployee);
        AddInclude(x => x.FormEmployee.Employee);
        AddInclude(x => x.Order);
        AddInclude(x => x.FormEmployeeOrderExecuations);


        if (param.FormId.HasValue)
            AddCriteries(x => x.FormEmployee.FormId.Equals(param.FormId.Value));
        if (param.FormEmployeeId.HasValue)
            AddCriteries(x => x.FormEmployeeId.Equals(param.FormEmployeeId.Value));
        if (!string.IsNullOrEmpty(param.TabCode))
            AddCriteries(x => x .FormEmployee.Employee.TabCode == param.TabCode);
        if (!string.IsNullOrEmpty(param.TegaraCode))
            AddCriteries(x => x.FormEmployee.Employee.TegaraCode == param.TegaraCode);
        if (!string.IsNullOrEmpty(param.EmployeeName))
            AddCriteries(x => x.FormEmployee.Employee.Name.StartsWith(param.EmployeeName));
        if (!string.IsNullOrEmpty(param.OrderName))
            AddCriteries(x => x.Order.Name.StartsWith(param.OrderName));
        if (!string.IsNullOrEmpty(param.Details))
            AddCriteries(x => x.Details.StartsWith(param.Details));
        if (param.Amount.HasValue)
            AddCriteries(x => x.FormEmployeeOrderExecuations.Sum(t => t.Amount).Equals(param.Amount));

        AddOrderBy(x => x.Id);

        ApplyPaging(param.pageIndex, param.PageSize);
    }
}



public class GetEmployeeVacationByFormIdQuerySpecification : Specification<FormEmployeeVacation>
{

    public GetEmployeeVacationByFormIdQuerySpecification(GetEmployeeOrderByFormIdQueryParams param)
    {

        AddInclude(x => x.FormEmployee);
        AddInclude(x => x.FormEmployee.Employee);
        AddInclude(x => x.Vacation);
        AddInclude(x => x.EmployeeVacationTypeExecuation);


        if (param.FormId.HasValue)
            AddCriteries(x => x.FormEmployee.FormId.Equals(param.FormId.Value));
        if (param.FormEmployeeId.HasValue)
            AddCriteries(x => x.FormEmployeeId.Equals(param.FormEmployeeId.Value));
        if (!string.IsNullOrEmpty(param.TabCode))
            AddCriteries(x => x.FormEmployee.Employee.TabCode == param.TabCode);
        if (!string.IsNullOrEmpty(param.TegaraCode))
            AddCriteries(x => x.FormEmployee.Employee.TegaraCode == param.TegaraCode);
        if (!string.IsNullOrEmpty(param.EmployeeName))
            AddCriteries(x => x.FormEmployee.Employee.Name.StartsWith(param.EmployeeName));
        if (!string.IsNullOrEmpty(param.OrderName))
            AddCriteries(x => x.Vacation.Name.StartsWith(param.OrderName));
        if (!string.IsNullOrEmpty(param.Details))
            AddCriteries(x => x.Details.StartsWith(param.Details));
        if (param.Amount.HasValue)
            AddCriteries(x => x.EmployeeVacationTypeExecuation.Sum(t => t.Amount).Equals(param.Amount));

        AddOrderBy(x => x.Id);

        ApplyPaging(param.pageIndex, param.PageSize);
    }
}


public class GetEmployeeOrderByFormIdQueryParams : Param
{
    public string TabCode { get; set; }
    public string TegaraCode { get; set; }
    public int? FormId { get; set; }
    public int? FormEmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string OrderName { get; set; }
    public string Details { get; set; }
    public DateTime? StartFrom { get; set; }
    public DateTime? EndAt { get; set; }
    public decimal? Amount { get; set; }
}


