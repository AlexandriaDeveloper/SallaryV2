using Domain.Shared;

namespace Application.FinancialYears.Queries
{
    public class GetFinancialYearDescQuerySpecification : Specification<Domain.Models.FinancialYear>
    {

        public GetFinancialYearDescQuerySpecification() : base()
        {
            AddOrderByDescending(x => x.Id);
        }
    }
}
