using Application.Common.Messaging;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormEmployeeOrderExecutions.Queries.GetFormEmployeeOrderExecutionByFormEmployeeOrderId;
public record GetFormEmployeeOrderExecutionByQuery(FormEmployeeOrderExecutionParam param):IQuery<List<FormEmployeeOrderExecutionsDto>>;
public class GetFormEmployeeOrderExecutionByQueryHandler : IQueryHandler<GetFormEmployeeOrderExecutionByQuery, List<FormEmployeeOrderExecutionsDto>>
{
    private readonly IUOW _uow;
    private readonly IMapper _mapper;

    public GetFormEmployeeOrderExecutionByQueryHandler(IUOW uow , IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<Result<List<FormEmployeeOrderExecutionsDto>>> Handle(GetFormEmployeeOrderExecutionByQuery request, CancellationToken cancellationToken)
    {
        GetFormEmployeeOrderExecutionByQuerySpecification spec = new GetFormEmployeeOrderExecutionByQuerySpecification(request.param);
        spec.Includes.Add(x => x.BudgetItem);
        spec.Includes.Add(x => x.FormEmployeeOrder);
        spec.Includes.Add(x => x.FormEmployeeOrder.FormEmployee);
        PagedList<FormEmployeeOrderExecuation> formEmployeeOrderExecutions = await _uow.FormEmployeeOrderExecutionRepository.GetAllBySpecAsync(spec);

        var items = formEmployeeOrderExecutions.Data
            .Where( t => t.FormEmployeeOrder.FormEmployee.EmployeeId==request.param.EmployeeId&& t.FormEmployeeOrder.OrderId ==request.param.OrderId)
            .GroupBy(k => k.BudgetItemId)
            .Select(x => 
            new FormEmployeeOrderExecutionsDto(){
            BudgetItemId=x.Key,
            BudgetItemName=x.FirstOrDefault().BudgetItem.Name,
            Amount=(x.Where(f => f.FormEmployeeOrder.CreditOrDebit=='d').Sum(x => x.Amount))-(x.Where(f => f.FormEmployeeOrder.CreditOrDebit == 'c').Sum(x => x.Amount)),
            FormEmployeeOrderId=x.FirstOrDefault().FormEmployeeOrderId
            
            }).ToList();
        return Result.Success(items);
    }
}

public class GetFormEmployeeOrderExecutionByQuerySpecification : Specification<FormEmployeeOrderExecuation> {

    public GetFormEmployeeOrderExecutionByQuerySpecification(FormEmployeeOrderExecutionParam param)
    {
      
        if (param.FormEmployeeOrderId.HasValue)
        {
            AddCriteries(x => x.FormEmployeeOrderId == param.FormEmployeeOrderId);
            
        }

        if (param.EmployeeId.HasValue) {
            AddInclude(x => x.FormEmployeeOrder.FormEmployee);
            AddCriteries(x => x.FormEmployeeOrder.FormEmployee.EmployeeId == param.EmployeeId);
        }
        if (param.CreditOrDebit.HasValue)
        {
            AddInclude(x => x.FormEmployeeOrder);
            AddCriteries(x => x.FormEmployeeOrder.CreditOrDebit == param.CreditOrDebit);
        }
        if (param.EmployeeId.HasValue)
        {
            AddInclude(x => x.FormEmployeeOrder.FormEmployee);
            AddCriteries(x => x.FormEmployeeOrder.FormEmployee.EmployeeId == param.EmployeeId);
        }
        if (param.FormId.HasValue)
        {
            AddInclude(x => x.FormEmployeeOrder.FormEmployee);
            AddCriteries(x => x.FormEmployeeOrder.FormEmployee.FormId == param.FormId);
        }
        if (param.OrderId.HasValue)
        {
            AddInclude(x => x.FormEmployeeOrder);
            AddCriteries(x => x.FormEmployeeOrder.OrderId == param.OrderId);
        }
        if (!string.IsNullOrEmpty( param.OrderNumber))
        {
            AddInclude(x => x.FormEmployeeOrder);
            AddCriteries(x => x.FormEmployeeOrder.OrderNumber.Contains( param.OrderNumber));
        }
    }
}

public class FormEmployeeOrderExecutionParam {
    public int? Id { get; set; }
    public int? FormEmployeeOrderId { get; set; }
    public int? EmployeeId { get; set; }
    public int? FormId { get; set; }
    public int? OrderId { get; set; }
    public char? CreditOrDebit { get; set; }
    public string OrderNumber { get; set; }
}


public class FormEmployeeOrderExecutionsDto {
    public int Id { get; set; }
    public string? BudgetItemName { get; set; }
    public int? BudgetItemId { get; set; }
    public decimal Amount { get; set; }
    public int FormEmployeeOrderId { get; set; }

}