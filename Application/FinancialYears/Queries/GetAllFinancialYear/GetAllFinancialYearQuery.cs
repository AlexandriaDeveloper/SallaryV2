using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.FinancialYears.Queries.GetAllFinancialYear
{
    public record GetAllFinancialYearQuery() : IQuery<IReadOnlyList<FinancialYearDto>>;
    public class GetAllFinancialYearQueryHandler : IQueryHandler<GetAllFinancialYearQuery, IReadOnlyList<FinancialYearDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetAllFinancialYearQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<IReadOnlyList<FinancialYearDto>>> Handle(GetAllFinancialYearQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetFinancialYearDescQuerySpecification();
            var financialYears = await _uow.FinancialYearRepository.GetAllBySpecAsync(spec);
            if (financialYears.Data == null)
            {
                return Result<IReadOnlyList<FinancialYearDto>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var resultToReturn = _mapper.Map<IReadOnlyList<FinancialYearDto>>(financialYears.Data);

            return Result<IReadOnlyList<FinancialYearDto>>.Success(resultToReturn);
        }
    }
}
