using Domain.Primitives;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
#nullable enable
    public class Employee : Entity
    {
        [MaxLength(14)]
        [Required]

        public string NationalId { get; set; } = "";
        [MaxLength(5)]
        public string? TabCode { get; set; }
        [MaxLength(5)]
        public string? TegaraCode { get; set; }

        [MaxLength(20)]
        public string? CollageName { get; set; }
        [MaxLength(40)]
        public string? Section { get; set; }
        [Required]
        public int QanonId { get; set; } 

        public int? EmployeeBankId { get; set; }
        [NotMapped]
        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }

        public ICollection<RegisterdEmployeeSubscription>? RegisterdEmployeeSubscriptions { get; set; }
        public ICollection<EmployeeGrade>? EmployeeGrades { get; set; }
        public ICollection<EmployeeCollection>? EmployeeCollection { get; set; }
        public ICollection<EmployeeBasicFinancialData> EmployeesBasicFinancialData { get; set; }
        public ICollection<FormEmployee> FormEmployees { get; set; }
        //PeriodicSubscription
        public EmployeeBankAccount? EmployeeBank { get; set; }
        public Qanon? Qanon { get; set; }




    }
}
