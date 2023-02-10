﻿using Application.Common.Messaging;
using Application.Form;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using static Application.EmployeesForm.Queries.GetEmployeeByFormId.GetEmployeeByFormIdQuerySpec;

namespace Application.EmployeesForm.Queries.GetEmployeeByFormId
{
    public record GetEmployeeByFormIdQuery(GetEmployeeByFormIdQueryParam param) : IQuery<PagedList<EmployeeFormDto>>;
    public class GetEmployeeByFormIdQueryHandler : IQueryHandler<GetEmployeeByFormIdQuery, PagedList<EmployeeFormDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeByFormIdQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<PagedList<EmployeeFormDto>>> Handle(GetEmployeeByFormIdQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeByFormIdQuerySpec(request.param);
            PagedList<EmployeeForm> emps = await _uow.EmployeeFormRepository.GetAllBySpecAsync(spec);
            if (emps == null)
            {
                return Result<PagedList<EmployeeFormDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            var empToReturn = _mapper.Map<PagedList<EmployeeFormDto>>(emps);

            ///   var formToReturn = _mapper.Map<PagedList< FormDto>>(formsFromDb);
            return Result<PagedList<EmployeeFormDto>>.Success(empToReturn).Value;


        }
    }
    public class GetEmployeeByFormIdQuerySpec : Specification<EmployeeForm>
    {

        public GetEmployeeByFormIdQuerySpec(GetEmployeeByFormIdQueryParam param)
        {
            AddInclude(x => x.Employee);

            if (param.FormId.HasValue)
                AddCriteries(x => x.FormId == param.FormId);

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
            public string EmployeeName { get; set; }
            public string EmployeeTabCode { get; set; }
            public string EmployeeTegaraCode { get; set; }
            public string EmployeeNationalId { get; set; }
            public string EmployeeSection { get; set; }
            public string EmployeeCollageName { get; set; }

        }
    }

}
