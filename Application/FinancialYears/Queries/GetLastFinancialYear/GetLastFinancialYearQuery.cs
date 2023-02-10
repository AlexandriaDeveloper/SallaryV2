using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;

namespace Application.FinancialYears.Queries
{
    public record GetLastFinancialYearQuery : IQuery<FinancialYearDto>;
    public class GetLastFinancialYearQueryHandler : IQueryHandler<GetLastFinancialYearQuery, FinancialYearDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetLastFinancialYearQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<FinancialYearDto>> Handle(GetLastFinancialYearQuery request, CancellationToken cancellationToken)
        {
            var specs = new GetFinancialYearDescQuerySpecification();
            var lastYear = await _uow.FinancialYearRepository
                 .GetBySingleOrDefaultAsync(specs, false);

            if (lastYear == null)
            {
                return Result.Failure<FinancialYearDto>(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var resultToReturn = _mapper.Map<FinancialYearDto>(lastYear);
            return Result<FinancialYearDto>.Success(resultToReturn);
        }
    }
}
