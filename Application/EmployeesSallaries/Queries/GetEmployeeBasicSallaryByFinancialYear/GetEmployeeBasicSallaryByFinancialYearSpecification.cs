using Domain.Models;
using Domain.Shared;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public class GetEmployeeBasicSallaryByFinancialYearSpecification : Specification<EmployeeBasicSallary>
    {
        public GetEmployeeBasicSallaryByFinancialYearSpecification(GetEmployeeBasicSallaryQuery param) : base()
        {
            if (param.EmployeeId.HasValue)
            {
                AddCriteries(x => x.EmployeeId.Equals(param.EmployeeId));
            }
            if (param.FinancialYearId.HasValue)
            {
                AddCriteries(x => x.FinancialYearId.Equals(param.FinancialYearId));
            }

        }
    }


}
