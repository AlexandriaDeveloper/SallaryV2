using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeVacationTypeExecuation : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        public int? BudgetItemId { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeVacationTypeId { get; set; }
        public EmployeeVacationType EmployeeVacationType { get; set; }
        public BudgetItem? BudgetItem { get; set; }
    }
}
