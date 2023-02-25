namespace Domain.Employees
{
    public class EmployeeDto
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string NationalId { get; set; }

        public string TabCode { get; set; }

        public string TegaraCode { get; set; }

        public string? CollageName { get; set; }

        public string? Section { get; set; }


        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }
        public int? EmployeeBankId { get; set; }
    }

    public class EmployeeDetailsDto
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string NationalId { get; set; }

        public string TabCode { get; set; }

        public string TegaraCode { get; set; }

        public string Grade { get; set; }

        public string? CollageName { get; set; }

        public string? Section { get; set; }
        public bool IsDeleted { get; set; }
        public bool EmployeeInPartTime { get; set; }
        public int? Next { get; set; }
        public int? Previous { get; set; }

        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }
        public int? EmployeeBankId { get; set; }
    }


}
