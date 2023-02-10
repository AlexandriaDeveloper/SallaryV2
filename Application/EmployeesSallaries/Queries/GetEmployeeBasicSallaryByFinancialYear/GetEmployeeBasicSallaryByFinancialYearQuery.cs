using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public record GetEmployeeBasicSallaryQuery(int? EmployeeId, int? FinancialYearId) : IQuery<EmployeeBasicSallary>;
    public class GetEmployeeBasicSallaryByFinancialYearQueryHandler : IQueryHandler<GetEmployeeBasicSallaryQuery, EmployeeBasicSallary>
    {
        private readonly IUOW _uow;

        public GetEmployeeBasicSallaryByFinancialYearQueryHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result<EmployeeBasicSallary>> Handle(GetEmployeeBasicSallaryQuery request, CancellationToken cancellationToken)
        {
            ISpecification<EmployeeBasicSallary> spec = new GetEmployeeBasicSallaryByFinancialYearSpecification(request);


            var result = await _uow.EmployeeBasicSallaryRepository.GetBySingleOrDefaultAsync(spec);
            if (result == null)
            {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            return Result<EmployeeBasicSallary>.Success(result);
        }
    }


}
