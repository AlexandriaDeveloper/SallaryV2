using Application.Common.Messaging;
using Domain.EmployeeOrders;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeOrderDetailses.Queries.GetEmployeeOrderByOrderFileId;

public record GetEmployeeOrderByOrderFileIdQuery(GetEmployeeOrderByOrderFileIdQueryParams param) : IQuery<PagedList<EmployeeOrderDetailsByOrderFileIdDto>>;
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
        var employeeOrderDetails = await _uow.EmployeeOrderRepository.GetAllBySpecAsync(new GetEmployeeOrderByOrderFileIdQuerySpecification(request.param));
        List<EmployeeOrderDetailsByOrderFileIdDto> employeeOrderDetailsByOrderFileIdList = new List<EmployeeOrderDetailsByOrderFileIdDto>();
        foreach (var employeeOrderDetail in employeeOrderDetails.Data)
        {
            employeeOrderDetailsByOrderFileIdList.Add(new EmployeeOrderDetailsByOrderFileIdDto(
                employeeOrderDetail.Id,
                employeeOrderDetail.Employee.TabCode,
                employeeOrderDetail.Employee.TegaraCode,
                 employeeOrderDetail.Employee.Name,
                 employeeOrderDetail.Order.Name,
                 employeeOrderDetail.Details,
                 employeeOrderDetail.Quantity,
                 employeeOrderDetail.StartFrom,
                 employeeOrderDetail.EndAt,
                 employeeOrderDetail.EmployeeOrderExecuations.Sum(x => x.Amount)
                ));


        }
        PagedList<EmployeeOrderDetailsByOrderFileIdDto> returnValue = new PagedList<EmployeeOrderDetailsByOrderFileIdDto>(employeeOrderDetailsByOrderFileIdList, employeeOrderDetails.Pagination);

        return Result.Success(returnValue);
    }
}
public class GetEmployeeOrderByOrderFileIdQuerySpecification : Specification<EmployeeOrder>
{

    public GetEmployeeOrderByOrderFileIdQuerySpecification(GetEmployeeOrderByOrderFileIdQueryParams param)
    {

        AddInclude(x => x.Employee);
        AddInclude(x => x.Order);
        AddInclude(x => x.EmployeeOrderExecuations);
        //  AddInclude(x => x.OrderFile);


        if (param.FormId.HasValue)
            AddCriteries(x => x.FormId.Equals(param.FormId.Value));
        if (!string.IsNullOrEmpty(param.TabCode))
            AddCriteries(x => x.Employee.TabCode == param.TabCode);
        if (!string.IsNullOrEmpty(param.TegaraCode))
            AddCriteries(x => x.Employee.TegaraCode == param.TegaraCode);
        if (!string.IsNullOrEmpty(param.EmployeeName))
            AddCriteries(x => x.Employee.Name.StartsWith(param.EmployeeName));
        if (!string.IsNullOrEmpty(param.OrderName))
            AddCriteries(x => x.Order.Name.StartsWith(param.OrderName));
        if (!string.IsNullOrEmpty(param.Details))
            AddCriteries(x => x.Details.StartsWith(param.Details));
        if (param.StartFrom.HasValue)
            AddCriteries(x => x.StartFrom >= param.StartFrom);
        if (param.EndAt.HasValue)
            AddCriteries(x => x.StartFrom <= param.EndAt);

        if (param.Amount.HasValue)
            AddCriteries(x => x.EmployeeOrderExecuations.Sum(t => t.Amount).Equals(param.Amount));

        AddOrderBy(x => x.Id);

        ApplyPaging(param.pageIndex, param.PageSize);
    }
}

public class GetEmployeeOrderByOrderFileIdQueryParams : Param
{
   // public int? OrderFileId { get; set; }
    public string TabCode { get; set; }
    public string TegaraCode { get; set; }
    public int? FormId { get; set; }
    public string EmployeeName { get; set; }
    public string OrderName { get; set; }
    public string Details { get; set; }
    public DateTime? StartFrom { get; set; }
    public DateTime? EndAt { get; set; }
    public decimal? Amount { get; set; }
}


