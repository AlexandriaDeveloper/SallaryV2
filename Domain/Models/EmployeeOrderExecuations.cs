using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Models
{
    public class EmployeeOrderTypeExecuation : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        public int? BudgetItemId { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeOrderTypeId { get; set; }
        public EmployeeOrderType EmployeeOrderType { get; set; }
        public BudgetItem? BudgetItem { get; set; }
    }



}
