using Domain.Models;
using Domain.Shared;

namespace Domain.Employees.Queries.GetEmployeesListQuery
{
    public class GetEmployeeListQuerySpecification : Specification<Employee>
    {
        public GetEmployeeListQuerySpecification(GetEmployeeListQueryParam param) : base()
        {
            if (!string.IsNullOrEmpty(param.Name))
            {
                AddCriteries(x => x.Name.Contains(param.Name));
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
            if (!string.IsNullOrEmpty(param.Section))
            {
                AddCriteries(x => x.Section.Contains(param.Section));
            }
            if (param.EmployeeHasBank is not null && param.EmployeeHasBank == (true))
            {

                AddCriteries(x => x.EmployeeBank != null);
            }
            if (param.EmployeeHasBank is not null && param.EmployeeHasBank == (false))
            {

                AddCriteries(x => x.EmployeeBank == null);
            }
            if (!string.IsNullOrEmpty(param.SortBy) && !string.IsNullOrEmpty(param.Sort))
            {
                if (param.SortBy.Equals("name"))
                {
                    if (param.Sort == "asc")
                        AddOrderBy(x => x.Name);
                    if (param.Sort == "desc")
                        AddOrderByDescending(x => x.Name);
                }

                if (param.SortBy.Equals("tabCode"))
                {
                    if (param.Sort == "asc")
                        AddOrderBy(x => x.TabCode);
                    if (param.Sort == "desc")
                        AddOrderByDescending(x => x.TabCode);
                }
                if (param.SortBy.Equals("tegaraCode"))
                {
                    if (param.Sort == "asc")
                        AddOrderBy(x => x.TegaraCode);
                    if (param.Sort == "desc")
                        AddOrderByDescending(x => x.TegaraCode);
                }
                if (param.SortBy.Equals("nationalId"))
                {
                    if (param.Sort == "asc")
                        AddOrderBy(x => x.NationalId);
                    if (param.Sort == "desc")
                        AddOrderByDescending(x => x.NationalId);
                }
                if (param.SortBy.Equals("section"))
                {
                    if (param.Sort == "asc")
                        AddOrderBy(x => x.Section);
                    if (param.Sort == "desc")
                        AddOrderByDescending(x => x.Section);
                }

            }
            ApplyPaging(param.pageIndex, param.PageSize);

        }
    }



}
