using Domain.Primitives;
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

        public int? EmployeeBankId { get; set; }
        [NotMapped]
        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }

        public ICollection<EmployeePartTime>? PartTimeDurations { get; set; }

        public bool EmployeeInPartTime { get => PartTimeDurations.Any(x => x.EndAt == null); }

        public ICollection<EmployeeOrder>? EmployeeOrders { get; set; }
        public ICollection<EmployeeSubscription>? EmployeeSubscriptions { get; set; }
        public ICollection<EmployeeGrade>? EmployeeGrades { get; set; }
        public ICollection<PeriodicSubscription>? PeriodicSubscriptions { get; set; }
        public ICollection<EmployeeBasicSallary> EmployeeBasicSallaries { get; set; }
        public ICollection<EmployeeCollection>? EmployeeCollection { get; set; }

        //PeriodicSubscription
        public EmployeeBank? EmployeeBank { get; set; }




    }
}
