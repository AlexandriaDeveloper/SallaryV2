using Domain.Shared;

namespace Domain.Employees.Queries.GetEmployeesListQuery
{
    public class GetEmployeeListQueryParam : Param
    {
        public string? Name { get; set; }
        public string? TabCode { get; set; }
        public string? TegaraCode { get; set; }
        public string? CollageName { get; set; }
        public string? Section { get; set; }
        public string? NationalId { get; set; }
        public bool? EmployeeHasBank { get; set; }
    };



}
