using Domain.Primitives;

namespace Domain.Models
{
    public class BudgetItem : Entity
    {

        public ICollection<EmployeeOrderExecuation>? EmployeeOrderExecuations { get; set; }
    }
}
