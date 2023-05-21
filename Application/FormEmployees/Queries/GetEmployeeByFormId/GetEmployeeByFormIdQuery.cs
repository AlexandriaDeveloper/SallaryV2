using Application.Common.Messaging;
using Application.Form;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using static Application.EmployeesForm.Queries.GetEmployeeByFormId.GetEmployeeByFormIdQuerySpec;

namespace Application.EmployeesForm.Queries.GetEmployeeByFormId
{
    public record GetEmployeeByFormIdQuery(GetEmployeeByFormIdQueryParam param) : IQuery<PagedList<FormEmployeeDto>>;
    public class GetEmployeeByFormIdQueryHandler : IQueryHandler<GetEmployeeByFormIdQuery, PagedList<FormEmployeeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeByFormIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<PagedList<FormEmployeeDto>>> Handle(GetEmployeeByFormIdQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeByFormIdQuerySpec(request.param);
            PagedList<Domain.Models.FormEmployee> emps = await _uow.FormEmployeeRepository.GetAllBySpecAsync(spec);
            if (emps == null)
            {
                return Result<PagedList<FormEmployeeDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<PagedList<FormEmployeeDto>>(emps);
            return Result<PagedList<FormEmployeeDto>>.Success(empToReturn).Value;
        }
    }
    


    public class GetEmployeeByFormIdQuerySpec : Specification<Domain.Models.FormEmployee>
    {

        public GetEmployeeByFormIdQuerySpec(GetEmployeeByFormIdQueryParam param)
        {
            AddInclude(x => x.Employee);

            if (param.FormId.HasValue)
                AddCriteries(x => x.FormId == param.FormId);


            if (param.EmployeeId.HasValue)
                AddCriteries(x => x.EmployeeId == param.EmployeeId);

            if (!string.IsNullOrEmpty(param.EmployeeName))

                AddCriteries(x => x.Employee.Name.Contains(param.EmployeeName));

            if (!string.IsNullOrEmpty(param.EmployeeTabCode))
                AddCriteries(x => x.Employee.TabCode == param.EmployeeTabCode);

            if (!string.IsNullOrEmpty(param.EmployeeTegaraCode))
                AddCriteries(x => x.Employee.TegaraCode == param.EmployeeTegaraCode);

            if (!string.IsNullOrEmpty(param.EmployeeNationalId))
                AddCriteries(x => x.Employee.NationalId == param.EmployeeNationalId);

            if (!string.IsNullOrEmpty(param.EmployeeSection))
                AddCriteries(x => x.Employee.Section == param.EmployeeSection);

            if (!string.IsNullOrEmpty(param.EmployeeCollageName))
                AddCriteries(x => x.Employee.CollageName == param.EmployeeCollageName);

            AddOrderBy(x => x.EmployeeOrderNumber);

            ApplyPaging(param.pageIndex, param.PageSize);



        }
        public class GetEmployeeByFormIdQueryParam : Param
        {
            public int? FormId { get; set; }
            public int? EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeTabCode { get; set; }
            public string EmployeeTegaraCode { get; set; }
            public string EmployeeNationalId { get; set; }
            public string EmployeeSection { get; set; }
            public string EmployeeCollageName { get; set; }

        }
    }

}
