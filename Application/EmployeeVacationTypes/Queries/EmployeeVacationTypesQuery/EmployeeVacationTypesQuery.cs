using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.EmployeeVacationTypes.Queries.EmployeeVacationTypesQuery
{
    public record EmployeeVacationTypesQuery(EmployeeVacationTypesQueryParam param) : IQuery<IReadOnlyList<EmployeeVacationTypeDto>>;
    public class EmployeeVacationTypesQueryHandler : IQueryHandler<EmployeeVacationTypesQuery, IReadOnlyList<EmployeeVacationTypeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public EmployeeVacationTypesQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<IReadOnlyList<EmployeeVacationTypeDto>>> Handle(EmployeeVacationTypesQuery request, CancellationToken cancellationToken)
        {

            EmployeeVacationTypesQuerySpecification spec = new EmployeeVacationTypesQuerySpecification(request.param);

            var empVacation = await _uow.EmployeeVacationTypeRepository.GetAllBySpecAsync(spec);

            if (empVacation == null)
            {
                return Result<IReadOnlyList<EmployeeVacationTypeDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empVacationToReturn = _mapper.Map<IReadOnlyList<EmployeeVacationTypeDto>>(empVacation);

            return Result.Success(empVacationToReturn);


        }
    }


    public class EmployeeVacationTypesQuerySpecification : Specification<EmployeeVacationType>
    {

        public EmployeeVacationTypesQuerySpecification(EmployeeVacationTypesQueryParam param)
        {
            if (param.Id.HasValue)
            {
                AddCriteries(x => x.Id == param.Id.Value);
            }
            if (param.VacationTypeId.HasValue)
            {
                AddInclude(x => x.Vacation);
                AddCriteries(x => x.Vacation.Id == param.VacationTypeId.Value);
            }
            if (param.EmployeeId.HasValue)
            {

                AddInclude(x => x.EmployeeOrder.Employee);
                AddCriteries(x => x.EmployeeOrder.EmployeeId == (param.EmployeeId));
            }
            if (param.FormId.HasValue)
            {
                AddInclude(x => x.EmployeeOrder.EmployeeOrderType);
                AddInclude(x => x.EmployeeOrder.EmployeeOrderType.Form);
                AddCriteries(x => x.EmployeeOrder.EmployeeOrderType.FormId == (param.FormId));
            }
            if (param.StartAt.HasValue)
            {
                AddCriteries(x => x.StartAt >= param.StartAt.Value);
            }
            if (param.EndAt.HasValue)
            {
                AddCriteries(x => x.EndAt <= param.EndAt.Value);
            }

            if (param.Quantity.HasValue)
            {
                AddCriteries(x => x.Qunatity.Value.Equals(param.Quantity));
            }
        }


    }


    public class EmployeeVacationTypesQueryParam
    {
        public int? Id { get; set; }
        public int? VacationTypeId { get; set; }
        public int? EmployeeId { get; set; }
        public int? EmployeeOrderId { get; set; }
        public int? FormId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? StartAt { get; set; }
        public DateTime? EndAt { get; set; }

    }
}
