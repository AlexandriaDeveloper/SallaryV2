using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FormEmployeeVacations.Queries.GetFormEmployeeVacationsBy;

public record GetFormEmployeeVacationsByQuery (GetFormEmployeeVacationsByQueryParam param) :IQuery<List< FormEmployeeVacationDto>>;
public class GetFormEmployeeVacationsByQueryHandler : IQueryHandler<GetFormEmployeeVacationsByQuery, List<FormEmployeeVacationDto>>
{
    private readonly IUOW _uow;
    private readonly IMapper _mapper;

    public GetFormEmployeeVacationsByQueryHandler(IUOW uow , IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }
    public async Task<Result<List<FormEmployeeVacationDto>>> Handle(GetFormEmployeeVacationsByQuery request, CancellationToken cancellationToken)
    {
        GetFormEmployeeVacationsByQuerySpecification spec = new GetFormEmployeeVacationsByQuerySpecification(request.param);
        var vacationsFromDb = await _uow.FormEmployeeVacationTypeRepository.GetAllBySpecAsync(spec);
     
      List<  FormEmployeeVacationDto> vactionsToReturn = _mapper.Map<List< FormEmployeeVacationDto>>(vacationsFromDb.Data);
        return Result.Success(vactionsToReturn);

    }
}
public class GetFormEmployeeVacationsByQuerySpecification : Specification<FormEmployeeVacation> {

    public GetFormEmployeeVacationsByQuerySpecification(GetFormEmployeeVacationsByQueryParam param)
    {
        AddInclude(x => x.FormEmployee);
        AddInclude(x => x.FormEmployee.Employee);
        AddInclude(x => x.Vacation);
        if (param.FormId.HasValue) { 
            AddCriteries( x=> x.FormEmployee.FormId==param.FormId );
        }
        if (param.EmployeeId.HasValue)
        {
            AddCriteries(x => x.FormEmployee.EmployeeId == param.EmployeeId);
        }
        if (param.Id.HasValue)
        {
            AddCriteries(x => x.Id == param.Id);
        }
        if (param.StartAt.HasValue)
        {
            AddCriteries(x => x.StartAt <= param.StartAt);
        }
        if (param.EndAt.HasValue)
        {
            AddCriteries(x => x.EndAt >= param.EndAt);
        }
    }
}

public class GetFormEmployeeVacationsByQueryParam{
    public int? Id { get; set; }
    public int? FormId { get; set; }
    public int? EmployeeId { get; set; }

    public DateTime? StartAt { get; set; }
    public DateTime? EndAt { get; set; }
}


