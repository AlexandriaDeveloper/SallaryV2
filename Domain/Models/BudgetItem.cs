using Domain.Primitives;

namespace Domain.Models
{
    public class BudgetItem : Entity
    {
        public ICollection<FormEmployeeOrderExecuation>? EmployeeOrderExecuations { get; set; }
    }
}
