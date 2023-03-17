using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Application.VacationTypes.Queries.GetVacationTypeList
{
    public record GetVacationTypeListQuery(GetVacationTypeListQueryParam param) : IQuery<IReadOnlyList<VacationTypeDto>>;
    public class GetVacationTypeListQueryHandler : IQueryHandler<GetVacationTypeListQuery, IReadOnlyList<VacationTypeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetVacationTypeListQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<Result<IReadOnlyList<VacationTypeDto>>> Handle(GetVacationTypeListQuery request, CancellationToken cancellationToken)
        {
            GetVacationTypeListQuerySpecification spec = new(request.param);
            PagedList<Vacation> vacationTypes = await _uow.VacationTypeRepository.GetAllBySpecAsync(spec);

            if (vacationTypes.Data == null)
            {
                return Result<IReadOnlyList<VacationTypeDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }




            IReadOnlyList<VacationTypeDto> vacationTypeDtos = _mapper.Map<IReadOnlyList<VacationTypeDto>>(vacationTypes.Data);

            return Result.Success(vacationTypeDtos);

        }
    }


    public class GetVacationTypeListQuerySpecification : Specification<Vacation>
    {

        public GetVacationTypeListQuerySpecification(GetVacationTypeListQueryParam param)
        {
            AddInclude(x => x.EmployeeVacationTypes);

            if (param.Id.HasValue)
            {
                AddCriteries(x => x.Id == param.Id.Value);
            }
            if (!string.IsNullOrEmpty(param.Name))
            {
                AddCriteries(x => x.Name.Contains(param.Name));
            }



        }
    }
    public class GetVacationTypeListQueryParam
    {

        public int? Id { get; set; }
        public string? Name { get; set; }




    }
}
