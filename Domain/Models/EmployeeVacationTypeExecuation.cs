using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeVacationExecuation : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        public int? BudgetItemId { get; set; }
        public decimal Amount { get; set; }
        public int FormEmployeeVacationId { get; set; }
        public  FormEmployeeVacation? FormEmployeeVacation { get; set; }
        public BudgetItem? BudgetItem { get; set; }
    }
}
