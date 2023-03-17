using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
#nullable enable
    public class EmployeeOrder : Entity
    {
        [NotMapped]
        public override string Name { get; set; }
        [MaxLength(5)]
        public string? OrderNumber { get; set; }
        [MaxLength(200)]
        public string? Details { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public EmployeeOrderType EmployeeOrderType { get; set; }
        public EmployeeVacationType? EmployeeVacationType { get; set; }
        public EmployeeOrder()
        {
        }
    }
}
