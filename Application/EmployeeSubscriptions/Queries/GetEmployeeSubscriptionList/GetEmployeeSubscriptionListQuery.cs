using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.EmployeeSubscriptions;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeSubscriptions.Queries.GetEmployeeSubscriptionList
{
    public record GetEmployeeSubscriptionListQuery(EmployeeSubscriptionParam param) : IQuery<PagedList<EmployeeSubscriptionDto>>;
    public class GetEmployeeSubscriptionListQueryHandler : IQueryHandler<GetEmployeeSubscriptionListQuery, PagedList<EmployeeSubscriptionDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeSubscriptionListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<PagedList<EmployeeSubscriptionDto>>> Handle(GetEmployeeSubscriptionListQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeSubscriptionListQuerySpecification(request.param);
            var employeeSubscription = await _uow.EmployeeSubscriptionRepository.GetAllBySpecAsync(spec);
            if (employeeSubscription == null)
            {
                return Result<PagedList<EmployeeSubscriptionDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var employeeSubscriptionToReturn = _mapper.Map<PagedList<EmployeeSubscriptionDto>>(employeeSubscription);

            return Result.Success(employeeSubscriptionToReturn);
        }
    }
    public class EmployeeSubscriptionParam : Param
    {
        public int? EmployeeId { get; set; }
        public string EmployeeTabCode { get; set; }
        public string EmployeeTegaraCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSection { get; set; }
        public string EmployeeNationalId { get; set; }
        public decimal? Amount { get; set; }
        public int? SubsriptionId { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetEmployeeSubscriptionListQuerySpecification : Specification<EmployeeSubscription>
    {
        public GetEmployeeSubscriptionListQuerySpecification(EmployeeSubscriptionParam param)
        {
            AddInclude(x => x.Employee);

            if (param.EmployeeId.HasValue)
            {
                AddCriteries(x => x.Employee.Id.Equals(param.EmployeeId.Value));
            }

            if (!string.IsNullOrEmpty(param.EmployeeTabCode))
            {
                AddCriteries(x => x.Employee.Name.Contains(param.EmployeeName));
            }

            if (!string.IsNullOrEmpty(param.EmployeeTabCode))
            {
                AddCriteries(x => x.Employee.TabCode.Equals(param.EmployeeTabCode));
            }
            if (!string.IsNullOrEmpty(param.EmployeeTegaraCode))
            {
                AddCriteries(x => x.Employee.TegaraCode.Equals(param.EmployeeTegaraCode));
            }

            if (!string.IsNullOrEmpty(param.EmployeeName))
            {
                AddCriteries(x => x.Employee.Name.Contains(param.EmployeeName));
            }

            if (!string.IsNullOrEmpty(param.EmployeeSection))
            {
                AddCriteries(x => x.Employee.Section.StartsWith(param.EmployeeSection));
            }
            if (param.Amount.HasValue)
            {
                AddCriteries(x => x.Amount == (param.Amount.Value));
            }
            if (param.SubsriptionId.HasValue)
            {
                AddCriteries(x => x.SubscriptionId.Equals(param.SubsriptionId.Value));
            }
            ApplyPaging(param.pageIndex, param.PageSize);
        }
    }
}
