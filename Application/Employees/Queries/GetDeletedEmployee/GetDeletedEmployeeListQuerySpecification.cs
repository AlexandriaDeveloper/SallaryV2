using Domain.Models;
using Domain.Shared;

namespace Domain.Employees.Queries.GetDeletedEmployee
{
    public partial class GetDeletedEmployeesQueryHandler
    {
        internal class GetDeletedEmployeeListQuerySpecification : Specification<Employee>
        {
            public GetDeletedEmployeeListQuerySpecification(GetDeltetdEmployeeListQueryParam param) : base()
            {
                if (!string.IsNullOrEmpty(param.Name))
                {
                    AddCriteries(x => x.Name!.Contains(param.Name));
                }
                if (!string.IsNullOrEmpty(param.TabCode))
                {
                    AddCriteries(x => x.TabCode.Equals(param.TabCode));
                }
                if (!string.IsNullOrEmpty(param.TegaraCode))
                {
                    AddCriteries(x => x.TegaraCode.Equals(param.TegaraCode));
                }
                if (!string.IsNullOrEmpty(param.NationalId))
                {
                    AddCriteries(x => x.NationalId.Equals(param.NationalId));
                }

            }
        }
    }


}
